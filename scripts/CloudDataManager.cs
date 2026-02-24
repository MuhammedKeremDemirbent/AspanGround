using System;
using System.Text;
using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace AspanGround_2
{
    public class CloudDataManager
    {
        private MqttClient client;
        private string clientId;
        private string brokerHost;
        private string topic = "aspan/uav/telemetry"; // Gateway bu başlığa veri basacak
        
        // Form1'e veri iletmek için bir event tanımlıyoruz
        public event Action<byte[]> OnPacketReceived;
        public event Action<bool> OnConnectionStatusChanged;

        public bool IsConnected => client != null && client.IsConnected;

        public CloudDataManager(string brokerHost = "broker.emqx.io")
        {
            this.brokerHost = brokerHost;
            try
            {
                client = new MqttClient(brokerHost);
                clientId = Guid.NewGuid().ToString();

                // Event handlers
                client.MqttMsgPublishReceived += Client_MqttMsgPublishReceived;
                client.ConnectionClosed += (s, e) => OnConnectionStatusChanged?.Invoke(false);
                
                Console.WriteLine($"MQTT Başlatıldı: {brokerHost}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("MQTT Başlatma Hatası: " + ex.Message);
            }
        }

        public void Connect()
        {
            if (client == null || client.IsConnected) return;

            try
            {
                client.Connect(clientId);
                if (client.IsConnected)
                {
                    client.Subscribe(new string[] { topic }, new byte[] { MqttMsgBase.QOS_LEVEL_AT_LEAST_ONCE });
                    OnConnectionStatusChanged?.Invoke(true);
                    Console.WriteLine($"MQTT Bağlantısı Başarılı! Server: {brokerHost}, Topic: {topic}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("MQTT Bağlantı Hatası: " + ex.Message);
                OnConnectionStatusChanged?.Invoke(false);
            }
        }

        public void Disconnect()
        {
            if (client != null && client.IsConnected)
            {
                client.Disconnect();
                OnConnectionStatusChanged?.Invoke(false);
            }
        }

        private void Client_MqttMsgPublishReceived(object sender, MqttMsgPublishEventArgs e)
        {
            Console.WriteLine($"[MQTT ANALİZ] Yeni mesaj geldi! Topic: {e.Topic}, Byte Sayısı: {e.Message.Length}");
            try
            {
                byte[] packet = e.Message;

                // Eğer uzunluk 20 değilse, gelen veriyi string olarak yorumlayıp hex dönüştürmeyi dene
                if (packet.Length != 20)
                {
                    string rawString = Encoding.UTF8.GetString(e.Message).Trim('"');
                    Console.WriteLine($"MQTT Ham Metin Geldi: {rawString}");

                    // "0x46, 0x43, ..." veya "46 43 ..." formatlarını temizle
                    string cleanHex = rawString.Replace("0x", "").Replace(",", "").Replace(" ", "").Replace("-", "").Replace("\n", "").Replace("\r", "");
                    
                    if (cleanHex.Length >= 40) // 20 byte = 40 karakter
                    {
                        byte[] converted = new byte[cleanHex.Length / 2];
                        for (int i = 0; i < converted.Length; i++)
                        {
                            converted[i] = Convert.ToByte(cleanHex.Substring(i * 2, 2), 16);
                        }
                        packet = converted;
                        Console.WriteLine($"MQTT Metni Byte dizisine dönüştürüldü. Uzunluk: {packet.Length}");
                    }
                }

                Console.WriteLine($"MQTT Paket İşleniyor. Uzunluk: {packet.Length}");

                if (packet.Length >= 20 && packet[0] == 0x46 && packet[1] == 0x43)
                {
                    Console.WriteLine("MQTT Paket Doğrulandı. Ham: " + BitConverter.ToString(packet));
                    OnPacketReceived?.Invoke(packet);
                }
                else
                {
                    Console.WriteLine($"MQTT Hata: Paket geçersiz. Uzunluk: {packet.Length}, İlk 2 byte: {(packet.Length > 0 ? packet[0].ToString("X2") : "??")} {(packet.Length > 1 ? packet[1].ToString("X2") : "??")}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("MQTT Veri İşleme Hatası: " + ex.Message);
            }
        }
        }
    }


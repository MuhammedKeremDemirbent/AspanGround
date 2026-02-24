using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace AspanGround_2
{
    public partial class AspanGround
    {
        private void InitializeCloudUI()
        {
            // Not: buttonCloud artık Designer (Form1.Designer.cs) tarafından oluşturuluyor.
            // Burada sadece event'leri ve başlangıç durumlarını bağlayalım.
            
            if (buttonCloud != null)
            {
                buttonCloud.Click -= buttonCloud_Click; // Varsa eskiyi temizle
                buttonCloud.Click += buttonCloud_Click;
            }

            // Bağlantı durumu değişince butonu güncelle
            cloudManager.OnConnectionStatusChanged += (connected) =>
            {
                this.Invoke(new Action(() =>
                {
                    if (buttonCloud == null) return;

                    if (connected)
                    {
                        buttonCloud.Text = "Cloud Online";
                        buttonCloud.FillColor = Color.FromArgb(39, 174, 96); // Yeşil
                    }
                    else
                    {
                        buttonCloud.Text = "Cloud Connect";
                        buttonCloud.FillColor = Color.FromArgb(41, 128, 185); // Mavi
                    }
                }));
            };
        }

        private void buttonCloud_Click(object sender, EventArgs e)
        {
            if (cloudManager == null) return;

            if (!cloudManager.IsConnected)
            {
                cloudManager.Connect();
                
                if (cloudManager.IsConnected)
                {
                    // TestPublish kaldırıldı
                }
                
                // Bulut bağlantısı kurulduğunda SQL oturumu başlatılmamışsa başlat
                if (currentSessionId <= 0)
                {
                    try
                    {
                        currentSessionId = dbManager.StartNewSession("Cloud Connection");
                        Console.WriteLine($"[CLOUD SQL] Yeni oturum başlatıldı: ID {currentSessionId}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"[KRİTİK SQL] Oturum başlatma hatası: {ex.Message}");
                        if (ex.InnerException != null) Console.WriteLine($"[KRİTİK SQL] Detay: {ex.InnerException.Message}");
                        // Oturum başlatılamazsa SQL kaydını başlatma
                        isSqlLogging = false;
                        timerSQL.Stop();
                        Console.WriteLine($"[CLOUD SQL] SQL Log: Pasif (Oturum hatası)");
                        return; // Oturum başlatılamadığı için daha fazla işlem yapma
                    }
                }
                
                Console.WriteLine($"[CLOUD SQL] Oturum Durumu: {currentSessionId}, SQL Log: Aktif");
                isSqlLogging = true;
                timerSQL.Start();
                Console.WriteLine($"[CLOUD SQL] SQL Timer Durumu: Başlatıldı");
            }
            else
            {
                cloudManager.Disconnect();
                // Bulut bağlantısı kesildiğinde SQL kaydını durdur
                isSqlLogging = false;
                timerSQL.Stop();
                Console.WriteLine($"[CLOUD SQL] SQL Timer Durumu: Durduruldu");
                Console.WriteLine($"[CLOUD SQL] SQL Log: Pasif (Bulut bağlantısı kesildi)");
            }
        }
    }
}

using System;

namespace AspanGround_2
{
    public struct PIDController
    {
        public float P;
        public float I;
        public float D;
        public float IMAX;
        public float FF;

        public PIDController(float p = 0, float i = 0, float d = 0, float imax = 0, float ff = 0)
        {
            P = p;
            I = i;
            D = d;
            IMAX = imax;
            FF = ff;
        }
    }

    public class PID
    {
        
        public PIDController ParsePid(byte[] packet, byte id)
        {
            float p = BitConverter.ToSingle(packet, 3);   // *** DEĞİŞTİR: P: byte 3-6 (firmware uyumlu)
            float i = BitConverter.ToSingle(packet, 7);   // I: byte 7-10
            float d = BitConverter.ToSingle(packet, 11);  // D: byte 11-14

            return new PIDController
            {
                P = p,
                I = i,
                D = d,
                IMAX = 0f,
                FF = 0f
            };
        }

        // Yeni: PID Okuma İsteği Gönder (header 'G' 'S', type 0x10)
        public byte[] EncodePidReadRequest(byte fwId)  // fwId: 0-5 single, 6=hepsi
        {
            byte[] packet = new byte[20];
            packet[0] = 0x47;  // 'G'
            packet[1] = 0x53;  // 'S'
            packet[2] = 0x10;  // Read komutu
            packet[3] = fwId;  // PID ID
            // [4-18]: 0x00
            for (int i = 4; i < 19; i++) packet[i] = 0x00;

            // Checksum
            byte sum = 0;
            for (int j = 0; j <= 18; j++) sum += packet[j];
            packet[19] = (byte)(0xFF - sum);

            return packet;
        }

        // Yeni: PID Yazma Paketi Oluştur (header 'G' 'S', [2]=fwId, data [3]=P)
        public byte[] EncodePidWrite(byte fwId, PIDController gains)
        {
            byte[] packet = new byte[20];
            packet[0] = 0x47;  // 'G'
            packet[1] = 0x53;  // 'S'
            packet[2] = fwId;  // Write: [2]=ID (0-5)
            // Float'ları byte'a (little-endian), ama P [3-6], I [7-10], D [11-14]
            BitConverter.GetBytes(gains.P).CopyTo(packet, 3);  // P: 3-6 (firmware &buf[3])
            BitConverter.GetBytes(gains.I).CopyTo(packet, 7);  // I: 7-10
            BitConverter.GetBytes(gains.D).CopyTo(packet, 11); // D: 11-14
            // [15-18]: 0x00
            packet[15] = packet[16] = packet[17] = packet[18] = 0x00;

            // Checksum
            byte sum = 0;
            for (int j = 0; j <= 18; j++) sum += packet[j];
            packet[19] = (byte)(0xFF - sum);

            return packet;
        }
    }
}
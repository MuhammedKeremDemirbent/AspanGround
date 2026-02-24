using System;
using static AspanGround_2.AspanGround;

// PID kontrolör yapısı ve işlevleri

namespace AspanGround_2
{
    public struct PIDController
    {
        public float P;
        public float I;
        public float D;
        public float Extra;
        //public float IMAX;
        //public float FF;

        public PIDController(float p = 0, float i = 0, float d = 0, float extra = 0)
        {
            P = p;
            I = i;
            D = d;
            Extra = extra;
            //IMAX = imax;
            //FF = ff;
        }
    }

    public class PID
    {
        
        public PIDController ParsePid(byte[] packet, byte id)
        {
            if (packet == null || packet.Length < 20)
                throw new Exception("Geçersiz PID paketi");


            float p = BitConverter.ToSingle(packet, 4);
            float i = BitConverter.ToSingle(packet, 8);
            float d = BitConverter.ToSingle(packet, 12);
            float extra = BitConverter.ToSingle(packet, 16);

            return new PIDController
            {
                P = p,
                I = i,
                D = d,
                Extra = extra,
                //IMAX = 0f,
                //FF = 0f
            };
        }

        // Yeni: PID Okuma İsteği Gönder (header 'G' 'S', type 0x10)
        public byte[] EncodePidReadRequest(byte fwId)  // fwId: 0-5 single, 6=hepsi
        {
            byte[] packet = new byte[20];
            packet[0] = 0x46;  
            packet[1] = 0x43;  
            packet[2] = (byte)PacketType.PidRead;
            packet[3] = fwId;
            // [4-18]: 0x00
            for (int i = 4; i < 19; i++) packet[i] = 0x00;

            // Checksum
            byte chk = 0xFF;
            for (int i = 0; i < 19; i++)
                chk -= packet[i];

            packet[19] = chk;

            return packet;
        }

      
        public byte[] EncodePidWrite(byte fwId, PIDController gains)
        {
            byte[] packet = new byte[20];
            packet[0] = 0x46;  
            packet[1] = 0x43;
            packet[2] = (byte)
            PacketType.PidWrite;
            packet[3] = fwId;

            BitConverter.GetBytes(gains.P).CopyTo(packet, 4);
            BitConverter.GetBytes(gains.I).CopyTo(packet, 8);
            BitConverter.GetBytes(gains.D).CopyTo(packet, 12);
            BitConverter.GetBytes(gains.Extra).CopyTo(packet, 16);

            // Checksum
            byte chk = 0xFF;
            for (int i = 0; i < 19; i++)
                chk -= packet[i];

            packet[19] = chk;

            return packet;
        }
    }
}
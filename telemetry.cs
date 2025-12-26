using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;

// Telemetry parse etme bölümü
namespace AspanGround_2
{
    internal class telemetry
    {
        public TelemetryData ParseTelemetry(byte[] packet)
        {
            short roll = BitConverter.ToInt16(packet, 3);
            short pitch = BitConverter.ToInt16(packet, 5);
            ushort yaw = BitConverter.ToUInt16(packet, 7);
            short baroAltFilt = BitConverter.ToInt16(packet, 9);
            short RH = BitConverter.ToInt16(packet, 11);
            short RV = BitConverter.ToInt16(packet, 13);
            ushort LH = BitConverter.ToUInt16(packet, 15);

            float roll_f = (roll / 100.0f)+180;
            float pitch_f = pitch / 100.0f;
            float yaw_f = yaw / 100.0f;
            float baroAltFilt_f = baroAltFilt / 10.0f;
            float RH_f = RH ;
            float RV_f = RV ;
            float LH_f = LH;

            // Verileri bir struct olarak döndür
            return new TelemetryData
            {
                Roll = roll_f,
                Pitch = pitch_f,
                Yaw = yaw_f,
                Altitude = baroAltFilt_f,
                RH = RH_f,
                RV = RV_f,
                LH = LH_f,
            };
        }
        public GpsData ParseGps(byte[] packet)
        {
            int lat = BitConverter.ToInt32(packet, 3);
            int lon = BitConverter.ToInt32(packet, 7);
        
            // Ölçeklendirme
            double Latitude_f = lat / 1e7;
            double Longitude_f = lon / 1e7;            

            return new GpsData 
             {
               Latitude = Latitude_f,
               Longitude =Longitude_f,
             };
        }

        public ModelData ParseModelInfo(byte[] packet)
        {
            
            short modelId = BitConverter.ToInt16(packet, 3);
         
            short free1 = BitConverter.ToInt16(packet, 5);

            byte ch7 = packet[7];
            byte ch8 = packet[8];

            return new ModelData
            {
                ModelID = modelId,
                Channel7 = ch7,
                Channel8 = ch8
            };
        }
    }

    public struct ModelData
    {
        public short ModelID;
        public byte Channel7;
        public byte Channel8;
    }

    public struct TelemetryData
        {
            public float Roll;
            public float Pitch;
            public float Yaw;
            public float Altitude;
            public float RH;
            public float RV;
            public float LH;
        }
        public struct GpsData
        {
            public double Latitude;
            public double Longitude;
        }
    }




using System;
using System.Windows.Forms;

namespace AspanGround_2
{
    public partial class AspanGround
    {
        #region PID 

        public enum PidAxis : byte
        {
            Roll = 0,
            Pitch = 1,
            Yaw = 2,
            Height = 3,
            East = 4,
            North = 5
        }

        private void WritePid(PidAxis axis, PIDController gains)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                MessageBox.Show("Seri port kapalı");
                return;
            }

            byte[] packet = PID.EncodePidWrite((byte)axis, gains);
            serialPort.Write(packet, 0, packet.Length);

            pidGains[(int)axis] = gains;
            pidValid[(int)axis] = true; ;

            UpdatePid(axis, gains);

            Console.WriteLine($"{axis} PID write gönderildi");
        }


        private void ReadPid(PidAxis axis)
        {
            int id = (int)axis;

            if (!pidValid[id])
            {
                Console.WriteLine($"PID cache boş: {axis}");
                return;
            }

            UpdatePid(axis, pidGains[id]);
        }

        private void UpdatePid(PidAxis axis, PIDController pid)
        {

            if (this.InvokeRequired)
            {
                Invoke(new Action(() => UpdatePid(axis, pid)));
                return;
            }

            try
            {
                switch (axis)
                {
                    case PidAxis.Roll:  // Roll
                        NumericPR.Value = (decimal)pid.P;
                        NumericIR.Value = (decimal)pid.I;
                        NumericDR.Value = (decimal)pid.D;
                        NumericEXTRAR.Value = (decimal)pid.Extra;
                        //NumericFILTR.Value = (decimal)pid.FF;
                        break;

                    case PidAxis.Pitch:  // Pitch
                        NumericPP.Value = (decimal)pid.P;
                        NumericIP.Value = (decimal)pid.I;
                        NumericDP.Value = (decimal)pid.D;
                        NumericIEXTRAP.Value = (decimal)pid.Extra;
                        //NumericFILTP.Value = (decimal)pid.FF;
                        break;

                    case PidAxis.Yaw:  // Yaw
                        NumericPY.Value = (decimal)pid.P;
                        NumericIY.Value = (decimal)pid.I;
                        NumericDY.Value = (decimal)pid.D;
                        NumericEXTRAY.Value = (decimal)pid.Extra;
                        //NumericFILTY.Value = (decimal)pid.FF;
                        break;

                    case PidAxis.Height: 
                        NumericPH.Value = (decimal)pid.P;
                        NumericIH.Value = (decimal)pid.I;
                        NumericDH.Value = (decimal)pid.D;
                        NumericEXTRAH.Value = (decimal)pid.Extra;
                        //NumericFILTR.Value = (decimal)pid.FF;
                        break;

                    case PidAxis.East:
                        NumericPE.Value = (decimal)pid.P;
                        NumericIE.Value = (decimal)pid.I;
                        NumericDE.Value = (decimal)pid.D;
                        NumericEXTRAE.Value = (decimal)pid.Extra;
                        //NumericFILTY.Value = (decimal)pid.FF;
                        break;

                    case PidAxis.North:  
                        NumericPN.Value = (decimal)pid.P;
                        NumericIN.Value = (decimal)pid.I;
                        NumericDN.Value = (decimal)pid.D;
                        NumericEXTRAN.Value = (decimal)pid.Extra;
                        //NumericFILTP.Value = (decimal)pid.FF;
                        break;
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"UI güncelleme hatası (uiId={axis}): {ex.Message}"); 
            }
        }
        private void ButtonRollWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.Roll, new PIDController(
            (float)NumericPR.Value,
            (float)NumericIR.Value,
            (float)NumericDR.Value,
            (float)NumericEXTRAR.Value
        ));
        }
        private void ButtonPitchWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.Pitch, new PIDController(
            (float)NumericPP.Value,
            (float)NumericIP.Value,
            (float)NumericDP.Value,
            (float)NumericIEXTRAP.Value
        ));
        }
        private void ButtonYawWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.Yaw, new PIDController(
            (float)NumericPY.Value,
            (float)NumericIY.Value,
            (float)NumericDY.Value,
            (float)NumericEXTRAY.Value
        ));
        }

        private void ButtonHeightWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.Height, new PIDController(
            (float)NumericPH.Value,
            (float)NumericIH.Value,
            (float)NumericDH.Value,
            (float)NumericEXTRAH.Value
               ));
        }

        private void ButtonNorthWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.North, new PIDController(
            (float)NumericPN.Value,
            (float)NumericIN.Value,
            (float)NumericDN.Value,
            (float)NumericEXTRAN.Value
               ));
        }

        private void ButtonEastWrite_Click(object sender, EventArgs e)
        {
            WritePid(PidAxis.East, new PIDController(
            (float)NumericPE.Value,
            (float)NumericIE.Value,
            (float)NumericDE.Value,
            (float)NumericEXTRAE.Value
               ));
        }

        private void ButtonRollRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.Roll);
        }
        private void ButtonPitchRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.Pitch);
        }
        private void ButtonYawRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.Yaw);
        }

        private void ButtonEastRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.East);
        }

        private void ButtonNorthRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.North);
        }

        private void ButtonHeightRefresh_Click(object sender, EventArgs e)
        {
            ReadPid(PidAxis.Height);
        }

        #endregion
    }
}

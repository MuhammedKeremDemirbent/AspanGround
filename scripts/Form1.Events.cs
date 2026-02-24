using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AspanGround_2
{
    public partial class AspanGround
    {
        #region OpeningClosing
        private void AspanGround_Load(object sender, EventArgs e)
        {
            InitializeWaypointTable();
            timerGauge.Start();
        }
        private void AspanGround_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
               
                DialogResult result = MessageBox.Show(
                    "Port bağlantısı hâlâ açık. Uygulamayı kapatmadan önce port bağlantısını kesiniz. ",
                    "Uygulamayı kapatmak ister misiniz?",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {                    
                    e.Cancel = true;
                    return;
                }
                else
                {
                    serialPort = null;
                    ButtonDisconnect_Click_1(null, EventArgs.Empty);
                    timerRCControls.Stop();                  
                    timerSerialCheck.Stop();
                   
                    if (isRecording && logWriter != null) //Loglama yeri 
                    {
                        try
                        {
                            logWriter.Close();
                        }
                        catch { }
                        isRecording = false;
                    }
                }
            }
        }
        #endregion

        #region Info
        private void linkLabelWebSitesi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/0/#inbox");
        }

        private void linkLabelSoruGorus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aspanuav/");
        }

        private void pictureBoxLinkedn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/company/aspan-uav/");
        }

        private void pictureBoxInstangram_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/aspanuav/");
        }

        private void pictureBoxMail_Click(object sender, EventArgs e)
        {
            string alici = "keremdmrbnt03@gmail.com";  ///////          
            string mailto = $"mailto:{alici}";

            try
            {
                Process.Start(mailto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mail uygulaması açılamadı: " + ex.Message);
            }
        }
        #endregion
    }
}

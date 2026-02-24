using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AspanGround_2
{
    public partial class AspanGround
    {
        #region ChartGraphics
        private void InitChartRP()
        {
            var mapper = Mappers.Xy<ObservablePoint>()
                .X(pt => pt.X)
                .Y(pt => pt.Y);
            Charting.For<ObservablePoint>(mapper);

            // Roll serisi
            _rollSeries = new LineSeries
            {
                Title = "Roll",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null

            };
            // Yaw serisi
            _yawSeries = new LineSeries
            {
                Title = "Yaw",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // Pitch serisi
            _pitchSeries = new LineSeries
            {
                Title = "Pitch",
                
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // RollSetpoint serisi
            _rollSetpointSeries = new LineSeries
            {
                Title = "RollSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // PitchSetpoint serisi
            _pitchSetpointSeries = new LineSeries
            {
                Title = "PitchSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };

            // YawSetpoint serisi
            _yawSetpointSeries = new LineSeries
            {
                Title = "YawSetpoint",
                Values = new ChartValues<ObservablePoint>(),
                PointGeometry = null
            };


            _series = new SeriesCollection();
            ChartRollPitchYaw.Series = _series;


            ChartRollPitchYaw.AxisX.Clear();
            ChartRollPitchYaw.AxisX.Add(new Axis
            {
                LabelFormatter = value => "", //X eksenini kaldırdı 
            });

            ChartRollPitchYaw.AxisY.Clear();
            ChartRollPitchYaw.AxisY.Add(new Axis
            {
                Title = "",
                MinValue = -360,
                MaxValue = +360,
                LabelFormatter = v => v.ToString("0"),

            });
            ChartRollPitchYaw.LegendLocation = LegendLocation.Top;
        }
        private double GetRollFromYourBoard()
        {
            return currentRoll;
        }
        private double GetYawFromYourBoard()
        {
            return currentYaw;
        }
        private double GetYawSetpointFromYourBoard()
        {            
            return yawSetpoint;
        }
        private double GetPitchFromYourBoard()
        {
            return currentPitch;
        }
        private double GetPitchSetpointFromYourBoard()
        {
            return pitchSetpoint;
        }
        private double GetRollSetpointFromYourBoard()
        {
            return rollSetpoint;
        }
        private void radioYaw_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _yawSeries.Stroke = System.Windows.Media.Brushes.DarkOrange;
                _yawSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_yawSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }                    
        }
        private void radioRoll_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioPitch_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioRollPitch_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }

        private void radioRollSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _rollSeries.Stroke = System.Windows.Media.Brushes.Red;
                _rollSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSeries.StrokeThickness = 3;

                _rollSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _rollSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _rollSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_rollSeries);
                ChartRollPitchYaw.Series.Add(_rollSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioPitchSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _pitchSeries.Stroke = System.Windows.Media.Brushes.Green;
                _pitchSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSeries.StrokeThickness = 3;

                _pitchSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _pitchSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _pitchSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_pitchSeries);
                ChartRollPitchYaw.Series.Add(_pitchSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioYawSetpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                _yawSeries.Stroke = System.Windows.Media.Brushes.DarkOrange;
                _yawSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSeries.StrokeThickness = 3;

                _yawSetpointSeries.Stroke = System.Windows.Media.Brushes.Blue;
                _yawSetpointSeries.Fill = System.Windows.Media.Brushes.Transparent;
                _yawSetpointSeries.StrokeThickness = 3;

                ChartRollPitchYaw.Series.Clear();
                ChartRollPitchYaw.Series.Add(_yawSeries);
                ChartRollPitchYaw.Series.Add(_yawSetpointSeries);
                timerGraphic.Start();
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı kurunuz...", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void radioNone_CheckedChanged(object sender, EventArgs e)
        {
            ChartRollPitchYaw.Series.Clear();
            timerGraphic.Stop();
        }
        private void ButtonStartLog_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (!isRecording)
                {
                    try
                    {

                        if (!Directory.Exists(logFolderPath)) //Klasör yoksa yeniden oluşturur.
                        {
                            Directory.CreateDirectory(logFolderPath);
                        }

                        string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss"); //Log txt ismi
                        string safeFileName = $"log_{timestamp}.txt";
                        string logFilePath = Path.Combine(logFolderPath, safeFileName);

                        ButtonStartLog.Text = "Logging...";

                        timerGraphic.Start();

                        logWriter = new StreamWriter(logFilePath, false, Encoding.UTF8);
                        logWriter.WriteLine("Roll\t  Pitch\t  Yaw\t  RollSetpoint\t  PitchSetpoint\t  YawSetpoint");

                        isRecording = true;

                        MessageBox.Show($"Kayıt başlatıldı. Log dizini:\n{logFolderPath}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (UnauthorizedAccessException uae)
                    {
                        MessageBox.Show($"Yazma izni yok: {uae.Message}\n\nLütfen uygulamayı yönetici olarak çalıştır ya da izin verilen bir klasör kullan.", "İzin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonStartLog.Text = "Start Log";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Log başlatılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ButtonStartLog.Text = "Start Log";
                    }
                }
                else
                {
                    MessageBox.Show("Kayıt zaten başlatılmış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Kart ile bağlantı sağlanmadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                radioNone.Checked = true;
            }
        }
        private void ButtonSaveLog_Click(object sender, EventArgs e)
        {
            if (serialPort != null && serialPort.IsOpen)
            {
                if (isRecording)
                {
                    try
                    {
                        logWriter?.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Log kapanırken hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        isRecording = false;
                        ButtonStartLog.Text = "Start Log";
                    }
                    MessageBox.Show("Kayıt durduruldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    radioNone.Checked = true;
                }
                else
                {
                    MessageBox.Show("Kayıt başlatılmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Bağlantı sağlanmamış.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void timerSQL_Tick(object sender, EventArgs e)
        {
            if (isSqlLogging && dbManager != null && currentSessionId > 0)
            {
                dbManager.SaveTelemetry(lastTelem, currentSessionId);
                dbManager.SaveGps(lastGps, currentSessionId);
            }
        }
        private void ButtonOpenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                if (Directory.Exists(logFolderPath))
                {
                    Process.Start("explorer.exe", logFolderPath);
                }
                else
                {
                    MessageBox.Show("Log klasörü bulundu değil.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Klasör açılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerGraphic_Tick(object sender, EventArgs e)
        {
            var idx2 = _sampleIndex++;

            _rollSeries.Values.Add(new ObservablePoint(idx2, GetRollFromYourBoard()));
            _pitchSeries.Values.Add(new ObservablePoint(idx2, GetPitchFromYourBoard()));
            _yawSeries.Values.Add(new ObservablePoint(idx2, GetYawFromYourBoard()));
            _rollSetpointSeries.Values.Add(new ObservablePoint(idx2, GetRollSetpointFromYourBoard()));
            _pitchSetpointSeries.Values.Add(new ObservablePoint(idx2, GetPitchSetpointFromYourBoard()));
            _yawSetpointSeries.Values.Add(new ObservablePoint(idx2, GetYawSetpointFromYourBoard()));

            if (_rollSeries.Values.Count > WindowSize) _rollSeries.Values.RemoveAt(0);
            if (_pitchSeries.Values.Count > WindowSize) _pitchSeries.Values.RemoveAt(0);
            if (_yawSeries.Values.Count > WindowSize) _yawSeries.Values.RemoveAt(0);
            if (_rollSetpointSeries.Values.Count > WindowSize) _rollSetpointSeries.Values.RemoveAt(0);
            if (_pitchSetpointSeries.Values.Count > WindowSize) _pitchSetpointSeries.Values.RemoveAt(0);
            if (_yawSetpointSeries.Values.Count > WindowSize) _yawSetpointSeries.Values.RemoveAt(0);

            ChartRollPitchYaw.AxisX[0].MinValue = idx2 - WindowSize + 1;
            ChartRollPitchYaw.AxisX[0].MaxValue = idx2;

            if (isRecording && logWriter != null)
            {
                try
                {
                    // Log satırı
                    string logLine = $"{currentRoll}\t{currentPitch}\t{currentYaw}\t{rollSetpoint}\t{pitchSetpoint}\t{yawSetpoint}";
                    logWriter.WriteLine(logLine);
                }
                catch (UnauthorizedAccessException uae)
                {
                    isRecording = false;
                    logWriter?.Close();
                    MessageBox.Show($"Log yazılamadı, izin hatası: {uae.Message}", "İzin Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonStartLog.Text = "Start Log";
                }
                catch (Exception ex)
                {      
                    isRecording = false;
                    logWriter?.Close();
                    MessageBox.Show($"Log yazılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ButtonStartLog.Text = "Start Log";
                }
            }
        }

        #endregion
    }
}

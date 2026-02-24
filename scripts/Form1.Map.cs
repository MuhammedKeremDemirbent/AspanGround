using Microsoft.Web.WebView2.Core;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AspanGround_2
{
    public partial class AspanGround
    {
        #region Map and DatasetGridWiew
        private void InitializeWaypointTable()
        {       
            dataGridViewWaypoints.Rows.Clear();
        }

        int wpcounter = 1;
        private void webViewMap_WebMessageReceived(object sender, Microsoft.Web.WebView2.Core.CoreWebView2WebMessageReceivedEventArgs e)
        {
            string json = e.WebMessageAsJson;

            try
            {                
                var jobj = Newtonsoft.Json.Linq.JObject.Parse(json);
                var action = jobj.Value<string>("action") ?? string.Empty;

                int idx = jobj.TryGetValue("idx", out var idxTok) && idxTok.Type == Newtonsoft.Json.Linq.JTokenType.Integer
                          ? idxTok.Value<int>()
                          : -1;

                if (action == "add")
                {
                    
                    if (!TryGetDouble(jobj, "lat", out double lat) ||
                        !TryGetDouble(jobj, "lng", out double lng))
                    {
                        
                        Debug.WriteLine("Add mesajı eksik lat/lng.");
                        return;
                    }
                     
                    
                    double alt = TryGetDouble(jobj, "alt", out double tmpAlt) ? tmpAlt : 0.0;

                    int insertIndex = Math.Max(0, Math.Min(idx, dataGridViewWaypoints.Rows.Count));

                    dataGridViewWaypoints.Rows.Insert(insertIndex, new object[]
                    {
                insertIndex,
                "WAYPOINT-" + wpcounter,
                alt.ToString(),
                lng.ToString("F6"),
                lat.ToString("F6"),
                    });
                    wpcounter++;

                    // Idx sütunlarını güncelle
                    for (int r = insertIndex + 1; r < dataGridViewWaypoints.Rows.Count; r++)
                    {
                        dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
                    }
                }
                else if (action == "remove" || action == "removed")
                {
                    // idx kontrolü
                    if (idx >= 0 && idx < dataGridViewWaypoints.Rows.Count)
                    {
                        dataGridViewWaypoints.Rows.RemoveAt(idx);
                        for (int r = idx; r < dataGridViewWaypoints.Rows.Count; r++)
                        {
                            dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
                        }
                    }
                }
                else if (action == "update")
                {
                    if (!TryGetDouble(jobj, "lat", out double lat) ||
                        !TryGetDouble(jobj, "lng", out double lng))
                    {
                        Debug.WriteLine("Update mesajı eksik lat/lng.");
                        return;
                    }

                    double alt = TryGetDouble(jobj, "alt", out double tmpAlt) ? tmpAlt : 0.0;

                    if (idx >= 0 && idx < dataGridViewWaypoints.Rows.Count)
                    {
                        dataGridViewWaypoints.Rows[idx].Cells["Latitude"].Value = lat.ToString("F6");
                        dataGridViewWaypoints.Rows[idx].Cells["Longitude"].Value = lng.ToString("F6");
                        dataGridViewWaypoints.Rows[idx].Cells["Altitude"].Value = alt.ToString();
                    }
                }
                else
                {
                    Debug.WriteLine($"Bilinmeyen action: {action}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Mesaj işlenirken hata: " + ex.Message);
            }
        }

        // Yardımcı: JObject'ten güvenli double alma
        private bool TryGetDouble(Newtonsoft.Json.Linq.JObject jobj, string propName, out double value)
        {
            value = 0;
            if (!jobj.TryGetValue(propName, out var tok)) return false;

            if (tok.Type == Newtonsoft.Json.Linq.JTokenType.Float || tok.Type == Newtonsoft.Json.Linq.JTokenType.Integer)
            {
                value = tok.Value<double>();
                return true;
            }
            if (tok.Type == Newtonsoft.Json.Linq.JTokenType.String)
            {
                return double.TryParse(tok.Value<string>(), System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out value);
            }
            return false;
        }
        private async void ButtonDeleteWaypoint_Click(object sender, EventArgs e)
        {
            if (dataGridViewWaypoints.Rows.Count == 0) return;

            // Her zaman son satırın index'ini al (seçimden bağımsız)
            int idx = dataGridViewWaypoints.Rows.Count - 1;

            // DataGridView'den kaldır
            dataGridViewWaypoints.Rows.RemoveAt(idx);

            // Idx sütunlarını güncelle (son silindiği için loop çalışmayacak, ama güvenli olsun)
            for (int r = idx; r < dataGridViewWaypoints.Rows.Count; r++)
            {
                dataGridViewWaypoints.Rows[r].Cells["idx"].Value = r;
            }

            wpcounter = Math.Max(1, wpcounter - 1);

            // Web tarafına da remove bilgisini gönder (idx JS array'inde de son index olmalı)
            string jsCode = $"removeWaypointFromJS({idx});";
            if (webViewMap?.CoreWebView2 != null)
            {
                await webViewMap.CoreWebView2.ExecuteScriptAsync(jsCode);
            }
        }


        private async Task InitializeWebView2Async()
        {
            // Eğer zaten başlatılmışsa veya başlatılıyorsa çık
            if (webViewMap == null || webViewMap.CoreWebView2 != null) return;

            try
            {
                // 1) UserDataFolder yolu
                string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                string userDataFolder = Path.Combine(localAppData, "AspanMap");

                // 2) Klasörü oluştur
                Directory.CreateDirectory(userDataFolder);

                // 3) Ortamı oluştur
                var env = await CoreWebView2Environment.CreateAsync(
                    browserExecutableFolder: null,
                    userDataFolder: userDataFolder);

                // 4) Sadece bir kez Ensure çağrıldığından emin ol
                if (webViewMap.CoreWebView2 == null)
                {
                    await webViewMap.EnsureCoreWebView2Async(env);
                    
                    // 5) Başlatıldıktan sonra kaynağı set et
                    string htmlPath = Path.Combine(Application.StartupPath, "Resources", "map.html");
                    if (File.Exists(htmlPath))
                    {
                        webViewMap.Source = new Uri(htmlPath);
                        Console.WriteLine("Map WebView2 başarıyla başlatıldı ve yüklendi.");
                    }
                    else
                    {
                        Console.WriteLine("Hata: map.html bulunamadı! Yol: " + htmlPath);
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"WebView2 Başlatma Hatası: {ex.Message}");
                Console.WriteLine($"WebView2 Başlatma Hatası: {ex.Message}");
            }
        }

    
        private async void UpdateDroneOnMap(double latitude, double longitude, double altitude, float roll, float pitch, float yaw)
        {
            if (webViewMap?.CoreWebView2 == null) return;

            try
            {

                string jsCode = $"updateIhaPosition({longitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {latitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {altitude.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {yaw.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {pitch.ToString(System.Globalization.CultureInfo.InvariantCulture)}, {roll.ToString(System.Globalization.CultureInfo.InvariantCulture)});";

                await webViewMap.CoreWebView2.ExecuteScriptAsync(jsCode);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"JS update hatası: {ex.Message}");
            }
        }
        #endregion
    }
}

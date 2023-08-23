using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;

namespace Vejr_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void GetWeatherButton_Click(object sender, RoutedEventArgs e) {
            string apiKey = "ee9567c7599dc716faa331deb5653851";
            string city = "København"; // Skal ændres så den får input fra et "søgefelt" istedet for.
            string apiUrl = $"http://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}";

            using (HttpClient client = new HttpClient()) {
                try {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseContent = await response.Content.ReadAsStringAsync();

                    string filePath = "C:\\Users\\phill\\OneDrive - TECHCOLLEGE\\Programmering\\WPF - Opgaver - Thomas\\Den Store Opgave\\Weather App\\Vejr App\\Vejr App\\api_data.json"; // Sti og filnavn for JSON-filen
                    // Den Store Opgave\Weather App\Vejr App\Vejr App\api_data.json
                    string jsonResponse1 = JsonConvert.SerializeObject(responseContent);

                    File.WriteAllText(filePath, jsonResponse1);

                    // Dekodér JSON-svaret
                    dynamic jsonResponse = JsonConvert.DeserializeObject(responseContent);
                    string cityName = jsonResponse.name;
                    double temperature = jsonResponse.main.temp;
                    string weatherDescription = jsonResponse.weather[0].description;

                    // Eksempel på opdatering af UI-elementer
                    cityNameLabel.Content = cityName;
                    temperatureLabel.Content = temperature.ToString();
                    weatherDescriptionLabel.Content = weatherDescription;
                }
                catch (HttpRequestException ex) {
                    MessageBox.Show($"Fejl ved hentning af vejrdata: {ex.Message}");
                }
            }
        }
    }
}

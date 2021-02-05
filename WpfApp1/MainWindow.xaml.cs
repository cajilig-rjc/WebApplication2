using System.Windows;
using WpfApp1.Services;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DGWeatherForecast.ItemsSource = await new WeatherDataStore().WeatherForecasts();
        }
    }
}

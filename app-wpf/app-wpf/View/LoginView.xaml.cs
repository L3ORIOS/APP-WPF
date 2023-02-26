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
using System.Windows.Shapes;
using System.Net.Http;
using Newtonsoft.Json;


namespace app_wpf.View
{
    /// <summary>
    /// Lógica de interacción para LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            this.AddHandler(Button.ClickEvent, new RoutedEventHandler(BtnGetUser_ClickAsync));

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e) 
        {
            if (e.LeftButton == MouseButtonState.Pressed) {
                DragMove();
            }
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();       
        }

        private async void BtnGetUser_ClickAsync(object sender, RoutedEventArgs e)
        {
            var url = "http://127.0.0.1:3505/user/4"; // URL de la API que devuelve JSON
            var httpClient = new HttpClient();

            var response = await httpClient.GetAsync(url); // Realiza una solicitud HTTP GET

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync(); // Obtiene el contenido de la respuesta en formato JSON
                var data = JsonConvert.DeserializeObject(jsonResponse); // Deserializa el JSON a un objeto de C#
                 tb_aqui.Text = data?.ToString();                               // ... Haz algo con los datos obtenidos
            }
            else
            {
                // ... Maneja el caso de que la solicitud no haya sido exitosa
            }
           


        }
    }
}

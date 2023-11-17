using Microsoft.UI.Xaml.Controls;

namespace Unidad5Ejercicio_HolaMundo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            
            if (!String.IsNullOrEmpty(txtNombre.Text))
            {

                /*  lblSaludo.Text = "Hola " + txtNombre.Text+" !"; */

                /*Mostrar saludo en ventana emergente:
                 * 
                 * hola
                 * 
                 * hola bri
                 * 
                 *           OK
                 * 
                 * 
                 * await DisplayAlert("Hola", "Hola " + txtNombre.Text, "OK");           */

                string apellidos = await DisplayPromptAsync("Hola", "Introduzca sus apellidos: ");

                await DisplayAlert("Hola", "Hola " + txtNombre.Text+" "+apellidos, "OK");
            }

        }
    }
}
using Microsoft.Maui.ApplicationModel.Communication;

namespace Tema7.Views
{
    public partial class MainPage : ContentPage
    {
       
        public MainPage()
        {
            InitializeComponent();
        }
        private async void btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PaginaTabbed());
        }

        private async void btnP4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina4());
        }
        private async void btnP5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina5());
        }
    }
}
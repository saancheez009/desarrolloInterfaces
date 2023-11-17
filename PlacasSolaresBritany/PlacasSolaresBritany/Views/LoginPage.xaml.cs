using PlacasSolaresBritany.Views;

namespace PlacasSolaresBritany
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }
        private async void btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

    }
}
namespace Ejercicio6
{
    public partial class MainPage : ContentPage
    {
        Boolean botonCreado = false;

        public MainPage()
        {
            InitializeComponent();
        }

        private void boton2_Clicked(object sender, EventArgs e)
        {
            if (botonCreado == false)
            {
                Button button = new Button()
                {
                    Text="boton3",
                    BackgroundColor=Colors.Blue,
                    FontAttributes=FontAttributes.Bold,
                    FontFamily="Verdana",
                    FontSize=16,
                    BorderColor=Colors.Yellow,
                    Margin=30,
                    HorizontalOptions=LayoutOptions.Center,
                    VerticalOptions=LayoutOptions.Center
                };
                
                boton2.Text = "Crear controles en tiempo de ejecución mola";
                botonCreado = true;
            }
        }
    }
}
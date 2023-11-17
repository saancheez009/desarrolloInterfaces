namespace Tema7.Views;

public partial class Pagina3 : ContentPage
{
	public Pagina3()
	{
		InitializeComponent();
	}
	private  void btn3_Clicked(object sender, EventArgs e)
	{
        Navigation.PopAsync();
    }
}
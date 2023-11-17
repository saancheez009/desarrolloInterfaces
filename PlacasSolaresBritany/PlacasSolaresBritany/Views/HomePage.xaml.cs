using System.Collections.ObjectModel;

namespace PlacasSolaresBritany.Views;

public partial class HomePage : ContentPage
{
	
    public class Cliente
    {
        public string Nombre { get; set; }
    }

    ObservableCollection<Cliente> personas = new ObservableCollection<Cliente>();
    public ObservableCollection<Cliente> Personas { get { return personas; } }

    public HomePage()
    {
        InitializeComponent();

        personas.Add(new Cliente() { Nombre = "Reda Santos Pardo" });
        personas.Add(new Cliente() { Nombre = "Yessenia �lvarez Cort�s" });
        personas.Add(new Cliente() { Nombre = "Jay Montes Largo" });
        personas.Add(new Cliente() { Nombre = "Emanuel Aranjuez Bard�n" });
        personas.Add(new Cliente() { Nombre = "Leticia Barullo B�ez" });

        ListaPersonas.ItemsSource = personas;

    }

    private async void  btn_Cliente(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ClientePage());
    }
}
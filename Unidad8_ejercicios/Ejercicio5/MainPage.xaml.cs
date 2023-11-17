using System.Collections.ObjectModel;
namespace Ejercicio5
{
    public partial class MainPage : ContentPage
    {
        public class Persona
        {
            public string Nombre { get; set; }
        }

        ObservableCollection<Persona> personas = new ObservableCollection<Persona>();
        public ObservableCollection<Persona> Personas { get { return personas; } }

        public MainPage()
        {
            InitializeComponent();

            personas.Add(new Persona() { Nombre = "Reda Santos Pardo" });
            personas.Add(new Persona() { Nombre = "Yessenia Álvarez Cortés" });
            personas.Add(new Persona() { Nombre = "Jay Montes Largo" });
            personas.Add(new Persona() { Nombre = "Emanuel Aranjuez Bardón" });
            personas.Add(new Persona() { Nombre = "Leticia Barullo Báez" });

            ListaPersonas.ItemsSource = personas;

        }
    }
}
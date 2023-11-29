using Ejercicio4.ViewModels;

namespace Ejercicio4.Views;

public partial class Vista1 : ContentPage
{
    public Vista1()
    {
        InitializeComponent();
        BindingContext = new PersonaVM();
    }
}
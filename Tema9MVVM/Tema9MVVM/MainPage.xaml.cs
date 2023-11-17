using Microsoft.Maui.Controls;

namespace Tema9MVVM
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MyViewModel();
        }

        public class MyViewModel : BindableObject
        {
            double sliderValue;
            public double SliderValue
            {
                get { return sliderValue; }
                set
                {
                    if (sliderValue != value)
                    {
                        sliderValue = value;
                        OnPropertyChanged();
                    }
                }
            }

            double fontSizeValue;
            public double FontSizeValue
            {
                get { return fontSizeValue; }
                set
                {
                    if (fontSizeValue != value)
                    {
                        fontSizeValue = value;
                        OnPropertyChanged();
                    }
                }
            }

        }
    }
}
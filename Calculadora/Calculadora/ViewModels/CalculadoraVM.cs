using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.ViewModels
{
    public class CalculadoraVM : BindableObject
    {
        private double _firstNumber;
        private double _secondNumber;
        private string _operation;
        private string _result;

        public double FirstNumber
        {
            get => _firstNumber;
            set
            {
                if (_firstNumber != value)
                {
                    _firstNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public double SecondNumber
        {
            get => _secondNumber;
            set
            {
                if (_secondNumber != value)
                {
                    _secondNumber = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Operation
        {
            get => _operation;
            set
            {
                if (_operation != value)
                {
                    _operation = value;
                    OnPropertyChanged();
                }
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;
using CoreSpotlight;
using System.ComponentModel;

namespace Ejercicio4.ViewModels
{
    public class PersonaVM : INotifyPropertyChanged
    {
        private string nombre;
        private clsPersona persona;

        public clsPersona Persona
        {
            get { return persona; }
            set
            {
                persona = value;
            }
        }

        public string Nombre
        {
            get { return nombre; }
            set
            {
                nombre = value;
                OnPropertyChanged(nameof(Nombre));

            }
        }

        public PersonaVM()
        {
            Persona = new clsPersona("Yeray");
            Nombre = Persona.Nombre;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
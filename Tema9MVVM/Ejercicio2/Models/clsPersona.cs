using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Ejercicio2.Models

{
    // All the code in this file is included in all platforms.
    public class clsPersona :INotifyPropertyChanged
    {
        #region atributos

        public string nombre;
        public string apellidos;
        #endregion


        #region constructores
        public clsPersona()
        {
            nombre = "Britany";
        }

        public clsPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion


        #region propiedades
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value;
                OnPropertyChanged();
            }

        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private void OnPropertyChanged([CallerMemberName] string atributo = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(atributo));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public String NombreCompleto
        {
            get { return $"Su nombre completo es: {nombre}{apellidos}"; }
        }
        #endregion

        #region funciones y metodos
        public string FuncionNombreCompleto()
        {
            return $"Su nombre completo es: {nombre}{apellidos}";
        }
        #endregion
    }
}

   
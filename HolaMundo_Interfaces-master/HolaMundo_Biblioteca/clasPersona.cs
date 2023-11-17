using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo_Biblioteca
{
    internal class clasPersona
    {
        #region atributos

        public string nombre;
        public string apellidos;
        #endregion


        #region constructores
        public clasPersona()
        {
            nombre = "" ;
            apellidos = "";
        }

        public clasPersona(string nombre, string apellidos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
        }
        #endregion


        #region propiedades
        public String Nombre
        {
            get{ return nombre; }
            set { nombre = value; }
        }

        public string Apellidos { 
            get { return apellidos; }
            set { apellidos = value; } 
        }

        public String Direccion { get; set ; }

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

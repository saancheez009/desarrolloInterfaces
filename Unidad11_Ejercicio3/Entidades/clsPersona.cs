using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class clsPersona
    {
        #region atributos
        private int id;
        private string nombre;
        private string apellido;
        private int idDepartamento;
        private DateTime fNac;
        private String tlf;
        private String direccion;
        #endregion

        #region constructores
        public clsPersona()
        {
            id = 0;
            nombre = "";
            apellido = "";
            idDepartamento = 0;
            fNac = DateTime.Now;
            
        }

        public clsPersona(string nombre, string apellido, int idDepartamento, int id, DateTime fNac, String tlf, String direccion)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.idDepartamento = idDepartamento;
            this.fNac = fNac;
            this.tlf = tlf;
            this.direccion = direccion;
        }
        #endregion

        #region propiedades

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Tlf
        {
            get { return tlf; }
            set { tlf = value; }
        }

        public String Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime FNac
        {
            get { return fNac; }
            set { fNac = value; }
        }


        public String NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        #endregion
    }
}

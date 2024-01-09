using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    internal class clsDepartamento
    {
        public int idDepartamento { get; set; }
        public string nombreDepartamento { get; set; }

        public clsDepartamento()
        {
            idDepartamento = 0;
            nombreDepartamento = string.Empty;
        }

        public clsDepartamento(int idDepartamento, string nombreDepartamento)
        {
            this.idDepartamento = idDepartamento;
            this.nombreDepartamento = nombreDepartamento;
        }
    }
}

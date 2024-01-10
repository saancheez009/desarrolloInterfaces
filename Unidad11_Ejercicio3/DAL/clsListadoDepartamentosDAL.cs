using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    internal class clsListadoDepartamentosDAL
    {
        public static ObservableCollection<clsDepartamento> listadoCompletoDepartamentos()
        {
            ObservableCollection<clsDepartamento> listadoDepartamento = new ObservableCollection<clsDepartamento>() {
                new clsDepartamento(1,"Finanzas"),
                new clsDepartamento(2,"Marketing"),
                new clsDepartamento(3,"RRHH"),
                new clsDepartamento(4,"Comida"),

            };

            return listadoDepartamento;

        }
    }
}

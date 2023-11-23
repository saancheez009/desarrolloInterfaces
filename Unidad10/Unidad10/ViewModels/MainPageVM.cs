using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unidad10.Models.DAL;
using Unidad10.Models.Entidades;
using Unidad10.ViewModels.Utilidades;

namespace Unidad10.ViewModels
{
    internal class MainPageVM: clsVMBase
    {
        #region
        DelegateCommand buscarCommand;
        DelegateCommand eliminarCommand;
        List<clsPersona> listadoPersonas;
        clsPersona personaSeleccionada;
        String textoBusqueda;
        #endregion

        #region Constructores
        public MainPageVM()
        {
            listadoPersonas = ListaPersonas.listadoCompletoPersonas();
            buscarCommand = new DelegateCommand(buscarCommandExecute, buscarCommandCanExecute);
            eliminarCommand = new DelegateCommand(eliminarCommandExecute, eliminarCommandCanExecute);
        }

        #endregion

        #region Propiedades
        public DelegateCommand BuscarCommand
        {
            get { return buscarCommand; } 
        }

        public DelegateCommand EliminarCommand
        {
            get { return eliminarCommand; }
        }

            public List<clsPersona> ListadoPersonas
        {
            get { return listadoPersonas; }
        }

        public clsPersona PersonaSeleccionada
        {
            set { personaSeleccionada = value; }
        }

        public String TextoBusqueda
        {
            get { return textoBusqueda;}
        }
        #endregion

        #region Comandos
        private bool eliminarCommandCanExecute()
        {
            bool habilitadoEliminar = false;
            if(personaSeleccionada != null)
            {
                habilitadoEliminar = true;
            }
            return habilitadoEliminar;
        }
        private void eliminarCommandExecute()
        {
            listadoPersonas.Remove(personaSeleccionada);
            NotifyPropertyChanged("ListadoPersonas");
        }

        private bool buscarCommandCanExecute()
        {
            bool habilitadoBuscar=false;
            if(String.IsNullOrEmpty(textoBusqueda))
            {
                habilitadoBuscar = true;
            }
            return habilitadoBuscar;
        }

        private void buscarCommandExecute()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Métodos y Funciones
        #endregion
    }
}

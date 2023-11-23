using Unidad10.Models.Entidades;

namespace Unidad10.Models.DAL
{
    public static class ListaPersonas
    {
        /// <summary>
        /// Funcion que devuelve un listado de personas completo
        /// Pre.ninguna
        /// Post:
        /// </summary>
        /// <returns></returns>

        public static List<clsPersona> listadoCompletoPersonas()
        {
            List<clsPersona> listadoPersona = new List<clsPersona>()
            {
                new clsPersona("Britany", "Sánchez",1,1),
                new clsPersona("Aron", "González",2,2),
                new clsPersona("Marta", "Real",3,3),
                new clsPersona("Paula", "Santos",4,4)

            };

            
            return listadoPersona;

        }
    }
}

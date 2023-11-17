namespace Biblioteca
{
    // All the code in this file is included in all platforms.
    public class clsPersona
    {
        #region atributos

        public string nombre;
        public string apellidos;
        #endregion


        #region constructores
        public clsPersona()
        {
            nombre = "";
            apellidos = "";
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
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public String Direccion { get; set; }

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

   
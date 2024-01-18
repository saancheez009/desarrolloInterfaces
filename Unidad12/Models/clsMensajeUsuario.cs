namespace Models
{
    public class clsMensajeUsuario
    {
        #region atributos
        private string nombreUsuario;
        private string mensajeUsuario;
        #endregion

        #region constructores
        public clsMensajeUsuario()
        {
            nombreUsuario = "";
            mensajeUsuario = "";

        }

        public clsMensajeUsuario(string nombreUsuario, string mensajeUsuario)
        {
            this.nombreUsuario = nombreUsuario;
            this.mensajeUsuario = mensajeUsuario;
        }
        #endregion

        #region propiedades

        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        public String MensajeUsuario
        {
            get { return mensajeUsuario; }
            set { mensajeUsuario = value; }
        }
        #endregion
    }
}

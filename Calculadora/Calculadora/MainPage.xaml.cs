namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        int primerNumero = 0;
        int segundoNumero = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click de los botones que realizarán una operación entre el primer número y el segundo número
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operacion(object sender, EventArgs e)
        {
            //Casteamos el sender a button y se lo asignamos a botonPulsado
            Button botonPulsado = (Button)sender;
            string operacionSeleccionada = botonPulsado.Text;

            double resultado = 0;
            switch (operacionSeleccionada)
            {
                case "-":
                    resultado = primerNumero - segundoNumero;

                    break;

                case "+":
                    resultado= primerNumero + segundoNumero;
                    break;

                case "*":
                    resultado = primerNumero * segundoNumero;
                    break;

                case "%":
                    resultado = primerNumero / segundoNumero;
                    break;

                case "x2":
                    resultado = primerNumero * primerNumero;
                    break;

                case "C":

                    break;
            }
            
        }

        /// <summary>
        /// Evento asociado al click del botón " = ", mostrará el resultado de la operación por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resultado(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Evento asociado al click de los botones números, asigna el valor del texto del botón al primer número de la operación o al segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Numeros(object sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            primerNumero = Int32.Parse(botonPulsado.Text);
            segundoNumero = Int32.Parse(botonPulsado.Text);

        }

    }
}
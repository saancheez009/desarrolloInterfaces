namespace Calculadora
{
    public partial class MainPage : ContentPage
    {
        double primerNumero = 0;
        double segundoNumero = 0;
        double resultado = 0;
        bool dosNumerosSeleccionados = false;
        bool pulsaOperacion = false;
        string operacionSeleccionada = "";

        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evento asociado al click de los botones que asignarán a la variable "operacionSeleccionada" la operación a realizar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Operacion(object sender, EventArgs e)
        {
            //Casteamos el sender a button y se lo asignamos a botonPulsado
            Button botonPulsado = (Button)sender;
            operacionSeleccionada = botonPulsado.Text; // Asigna el texto del botón a la variable operacionSeleccionada
            pulsaOperacion = true; //Comprueba que se pulsa el botón de operación para realizarla
            LblResultado.Text = "0"; // Limpia el texto de la etiqueta de resultado

        }

        /// <summary>
        /// Evento asociado al click del botón " = ", mostrará el resultado de la operación por pantalla
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Resultado(object sender, EventArgs e)
        {
            if (dosNumerosSeleccionados == true)
            {
                switch (operacionSeleccionada)
                {
                    case "-":
                        resultado = primerNumero - segundoNumero;

                        break;

                    case "+":
                        resultado = primerNumero + segundoNumero;
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
                        resultado = 0;
                        primerNumero = 0;
                        segundoNumero = 0;
                        dosNumerosSeleccionados = false;
                        LblResultado.Text = "0";
                        break;
                }
                LblResultado.Text = resultado.ToString();
                primerNumero = resultado;
                segundoNumero = 0;
            }
        }
    

        /// <summary>
        /// Evento asociado al click de los botones números, asigna el valor del texto del botón al primer número de la operación o al segundo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Numeros(object sender, EventArgs e)
        {
            String numero;
            Button botonPulsado = (Button)sender;
            numero = botonPulsado.Text; // Obtiene el texto del botón pulsado
            LblResultado.Text += numero; // Muestra el número en la etiqueta de resultado

            // Determina si es el primer número o el segundo
            if (!pulsaOperacion)
            {
                primerNumero = int.Parse(numero);
                dosNumerosSeleccionados = true;
            }
            else
            {
                segundoNumero = int.Parse(numero);
                pulsaOperacion = false;
            }

        }

    }
}
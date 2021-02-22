using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CalculadoraTheDrummerCoding
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        //DECLARACION DE CAMPOS DE CLASE PARA LOS METODOS
        long numero1 = 0;
        long numero2 = 0;
        string operacion = "";
        
        public MainWindow()
        {
            InitializeComponent();
        }

        //BOTONES NUMEROS Y SU LOGICA DE EMPALMAR VARIOS EN FUNCION DE LA LONGITUD QUE SE QUIERA
        private void Boton1(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 1;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 1;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton2(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 2;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 2;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton3(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 3;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 3;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton4(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 4;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 4;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton5(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 5;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 5;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton6(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 6;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 6;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton7(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 7;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 7;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton8(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 8;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 8;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton9(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 9;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 9;
                txtResultado.Text = numero2.ToString();

            }

        }

        private void Boton0(object sender, RoutedEventArgs e)
        {
            if (operacion == "")
            {
                numero1 = (numero1 * 10) + 0;
                txtResultado.Text = numero1.ToString();

            }
            else
            {
                numero2 = (numero2 * 10) + 0;
                txtResultado.Text = numero2.ToString();

            }

        }

        //BOTONES OPERADORES Y SU LÓGICA

        private void BotonMas(object sender, RoutedEventArgs e)
        {

            operacion = "+";
            txtResultado.Text = "0";

        }

        private void BotonMenos(object sender, RoutedEventArgs e)
        {
            operacion = "-";
            txtResultado.Text = "0";


        }

        private void BotonMultiplicar(object sender, RoutedEventArgs e)
        {
            operacion = "*";
            txtResultado.Text = "0";

        }

        private void BotonDivision(object sender, RoutedEventArgs e)
        {
            operacion = "/";
            txtResultado.Text = "0";


        }

        //BOTON IGUAL Y SU LÓGICA

        private void BotonIgual(object sender, RoutedEventArgs e)
        {
            switch(operacion)
            {
                case "+":
                    txtResultado.Text = (numero1 + numero2).ToString();
                    break;

                case "-":
                    txtResultado.Text = (numero1 - numero2).ToString();
                    break;

                case "*":
                    txtResultado.Text = (numero1 * numero2).ToString();
                    break;

                case "/":
                    txtResultado.Text = ((double)numero1 / (double)numero2).ToString();
                    break;

            }

            numero1 = 0;
            numero2 = 0;
            operacion = "";


        }

        //BOTON +- Y SU LÓGICA

        private void BotonMasyMenos(object sender, RoutedEventArgs e)
        {
            txtResultado.Text = (-1 * int.Parse(txtResultado.Text)).ToString();

        }

        //BOTON LIMPIAR TODO:

        private void BotonC(object sender, RoutedEventArgs e)
        {
            numero1 = 0;
            numero2 = 0;
            operacion = "";
            txtResultado.Text = "0";
        }

        //BOTON PUNTO Y SU LÓGICA

        
        private void BotonPunto(object sender, RoutedEventArgs e)
        {
            operacion = ".";
            txtResultado.Text = numero1 + ".";

            double numero2D = (double)numero2 / 10;

           

        }

        





    }
}

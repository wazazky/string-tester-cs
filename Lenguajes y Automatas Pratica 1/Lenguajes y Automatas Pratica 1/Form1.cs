using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lenguajes_y_Automatas_Pratica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Console.Write("Ingresa una cadena: ")
            //Console.ReadKey();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        static bool EsIdentificador(string cadena)
        {
            // Un identificador debe empezar con una letra o un guión bajo,
            // y puede estar seguido por letras, números o guiones bajos.
            return System.Text.RegularExpressions.Regex.IsMatch(cadena, @"^[a-zA-Z_][a-zA-Z0-9_]*$");
        }

        static bool EsNumero(string cadena)
        {
            double resultado;
            return double.TryParse(cadena, out resultado);
        }

        static bool EsUrl(string cadena)
        {
            // Una URL debe empezar con "http://" o "https://",
            // seguida por cualquier combinación de letras, números, guiones y puntos,
            // y terminar con un dominio de dos o tres letras.
            return System.Text.RegularExpressions.Regex.IsMatch(cadena, @"^(http|https)://[a-zA-Z0-9\-\.]+(\.[a-zA-Z]{2,3}){1,2}(/[\w\-\./?%&=]*)?$");
        }

        static bool EsCorreo(string cadena)
        {
            // Un correo electrónico debe tener la forma "usuario@dominio",
            // donde "usuario" puede contener letras, números, guiones y puntos,
            // y "dominio" debe tener al menos un punto y contener sólo letras y puntos.
            return System.Text.RegularExpressions.Regex.IsMatch(cadena, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string entrada = textBox1.Text; ;
            // Identificador
            if (EsIdentificador(entrada))
            {
                labelTipo.Text = "La cadena es un identificador.";
            }
            // Número
            else if (EsNumero(entrada))
            {
                labelTipo.Text = "La cadena es un número.";
            }
            // URL
            else if (EsUrl(entrada))
            {
                labelTipo.Text = "La cadena es una URL.";
            }
            // Correo electrónico
            else if (EsCorreo(entrada))
            {
                labelTipo.Text = "La cadena es un correo electrónico.";
            }
            // Ninguna de las anteriores
            else
            {
              labelTipo.Text="La cadena no es un identificador, número, URL o correo electrónico.";
            }
        }

       
    }
}

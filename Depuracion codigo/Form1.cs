using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depuracion_codigo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbOrdinario.Checked = true; // Marca "Ordinario" como opción predeterminada
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {

            string textoTelegrama;
            bool esUrgente = rbUrgente.Checked; // Verifica si es urgente directamente
            int numPalabras = 0;
            double coste;

            // Leo el telegrama  
            textoTelegrama = txtTelegrama.Text;

            // Obtengo el número de palabras que forma el telegrama  
            string[] palabras = textoTelegrama.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            numPalabras = palabras.Length;
           

            // Calculo el coste dependiendo de si es urgente o no
            if (!esUrgente) // Telegrama ordinario
            {
               

                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else // Telegrama urgente
            {
                if (numPalabras <= 10)
                {
                    coste = 5;
                }
                else
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
            }

            // Muestro el coste en el textbox
            txtPrecio.Text = coste.ToString("0.00") + " euros";
        }

    }
}

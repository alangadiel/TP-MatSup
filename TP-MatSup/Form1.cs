using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatSup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_convertir_Click(object sender, EventArgs e)
        {
            try
            {
                var input = txtbox_conv.Text;
                if (input == "") throw new Exception("Ingrese un numero.");
                var num = new NumeroComplejo(input);
                object num2;
                if(num.FormaBinomica != null)
                {
                    num2 = NumeroComplejo.BinomicaAPolar(num.FormaBinomica);
                }
                else
                {
                    num2 = NumeroComplejo.PolarABinomica(num.FormaPolar);
                }
                label_resul_conv.Text = "Resultado: " + num2.ToString();
                label_resul_conv.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

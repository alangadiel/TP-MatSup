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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void boton_a_polar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtReal.Text == "" || txtImg.Text == "") throw new Exception("Ingrese los datos");
                var num = new FormaBinomica { ParteReal = double.Parse(txtReal.Text), ParteImaginaria = double.Parse(txtImg.Text) };
                label_resul_a_polar.Text = NumeroComplejo.BinomicaAPolar(num).ToString();
                label_resul_a_polar.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void boton_a_binomico_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_radio.Text == "" || txt_angulo.Text == "") throw new Exception("Ingrese los datos");
                var num = new FormaPolar { Radio = double.Parse(txt_radio.Text), Angulo = double.Parse(txt_angulo.Text) };
                label_res_a_binomico.Text = NumeroComplejo.PolarABinomica(num).ToString();
                label_res_a_binomico.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

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
        public enum OperacionesBasicas { Suma, Resta, Multiplicacion, Division };
        public Form1()
        {
            InitializeComponent();
            comboBoxOB.DataSource = Enum.GetValues(typeof(OperacionesBasicas));
        }

        private void BotonConvClick(object sender, EventArgs e)
        {
            try
            {
                labelResulConv.Text = "Resultado: " 
                    + NumeroComplejo.Parse(textBoxConv.Text).Convertir().ToString();
                labelResulConv.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            botonOB.Enabled = true;
        }

        private void BotonOBClick(object sender, EventArgs e)
        {
            try
            {
                var num1 = NumeroComplejo.Parse(textBoxOB1.Text);
                var num2 = NumeroComplejo.Parse(textBoxOB2.Text);
                NumeroComplejo res = null;
                switch((OperacionesBasicas)comboBoxOB.SelectedItem)
                {
                    case OperacionesBasicas.Suma:
                        res = num1 + num2;
                        break;
                    case OperacionesBasicas.Resta:
                        res = num1 - num2;
                        break;
                    case OperacionesBasicas.Multiplicacion:
                        res = num1 * num2;
                        break;
                    case OperacionesBasicas.Division:
                        res = num1 / num2;
                        break;
                }
                labelResulOB.Text = "Resultado: " + res.ToString();
                labelResulOB.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

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
        public enum OperacionesAvanzadas { Potenciacion, Radicacion };
        public Form1()
        {
            InitializeComponent();
            comboBoxOB.DataSource = Enum.GetValues(typeof(OperacionesBasicas));
            comboBoxOA.DataSource = Enum.GetValues(typeof(OperacionesAvanzadas));
            comboBoxFun1.DataSource = Enum.GetValues(typeof(Fasor.FunTrig));
            comboBoxFun2.DataSource = Enum.GetValues(typeof(Fasor.FunTrig));
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

        private void BotonOBClick(object sender, EventArgs e)
        {
            try
            {
                var num1 = NumeroComplejo.Parse(textBoxOB1.Text);
                var num2 = NumeroComplejo.Parse(textBoxOB2.Text);
                NumeroComplejo res = null;
                switch ((OperacionesBasicas)comboBoxOB.SelectedItem)
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
                    default:
                        throw new Exception("Seleccione una operacion");
                }
                labelResulOB.Text = "Resultado: " + res.ToString();
                labelResulOB.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BotonOA_Click(object sender, EventArgs e)
        {
            try
            {
                var num1 = NumeroComplejo.Parse(textBoxOA1.Text);
                var num2 = int.Parse(textBoxOA2.Text);
                if (num2 <= 0) throw new Exception("Debe ingresar un numero natural.");
                Raiz[] res;
                switch ((OperacionesAvanzadas)comboBoxOA.SelectedItem)
                {
                    case OperacionesAvanzadas.Potenciacion:
                        res = new Raiz[1];
                        res[0] = new Raiz { NumeroComplejo = num1.Pow(num2) };
                        break;
                    case OperacionesAvanzadas.Radicacion:
                        res = num1.Root(num2);
                        break;
                    default:
                        throw new Exception("Seleccione una operacion");
                }
                listBoxOA.DataSource = res;
                labelResulOA.Visible = listBoxOA.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BotonSF_Click(object sender, EventArgs e)
        {
            try
            {
                var f1 = new Fasor(textBoxAmp1.Text, (Fasor.FunTrig)comboBoxFun1.SelectedItem, textBoxFrec1.Text, textBoxFase1.Text);
                var f2 = new Fasor(textBoxAmp2.Text, (Fasor.FunTrig)comboBoxFun2.SelectedItem, textBoxFrec2.Text, textBoxFase2.Text);

                var res = f1 + f2;
                labelResulSF.Text = "Resultado: " + res.ToString();
                labelResulSF.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

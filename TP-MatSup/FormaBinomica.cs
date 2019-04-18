using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatSup
{
    public class FormaBinomica : NumeroComplejo
    {
        double real;
        double img;
        public override double ParteReal => real;
        public override double ParteImaginaria => img;
        public FormaBinomica(double real, double img)
        {
            this.real = real;
            this.img = img;
        }
        public override double Modulo => Math.Sqrt(Math.Pow(ParteReal, 2) + Math.Pow(ParteImaginaria, 2));
        public override double Argumento
        {
            get
            {
                var angulo = Math.Atan2(ParteImaginaria, ParteReal);
                if (ParteReal < 0)
                {
                    angulo += Math.PI;
                }
                else if (ParteImaginaria < 0)
                {
                    angulo += 2 * Math.PI;
                }
                return angulo;
            }
        }

        public override NumeroComplejo Convertir() => new FormaPolar(Modulo, Argumento);
        public override string ToString() => "Z = " + ParteReal.MyToString() + " + (" + ParteImaginaria.MyToString() + ")*j";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MatSup
{
    public class FormaBinomica
    {
        public double ParteReal;
        public double ParteImaginaria;

        public double Modulo => Math.Sqrt(Math.Pow(ParteReal, 2) + Math.Pow(ParteImaginaria, 2));
        public double Argumento
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

        public override string ToString() => "Z = " + ParteReal.ToString("F") + " + (" + ParteImaginaria.ToString("F") + ")*j";
    }
}

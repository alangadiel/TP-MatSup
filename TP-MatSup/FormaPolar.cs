using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class FormaPolar
    {
        public double Radio;
        private double angulo;
        public double Angulo
        {
            get => angulo;
            set => angulo = value % (2 * Math.PI); //Chequea que esté en el primer giro positivo
        }

        public double ParteReal => Radio * Math.Cos(Angulo);
        public double ParteImaginaria => Radio * Math.Sin(Angulo);

        public override string ToString() => "Z = [ " + Radio.ToString("F") + " ; " + Angulo.ToString("F") + " ]";
    }
}

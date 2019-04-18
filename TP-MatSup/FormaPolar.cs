using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class FormaPolar
    {
        public double Modulo;
        private double argumento;
        public double Argumento
        {
            get => argumento;
            set => argumento = value % (2 * Math.PI); //Chequea que esté en el primer giro positivo
        }

        public FormaPolar(double modulo, double argumento)
        {
            Modulo = modulo;
            Argumento = argumento;
        }

        public double ParteReal => Modulo * Math.Cos(Argumento);
        public double ParteImaginaria => Modulo * Math.Sin(Argumento);

        public override string ToString() => "Z = [ " + Modulo.ToString("F") + " ; " + Argumento.ToString("F") + " ]";
    }
}

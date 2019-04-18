using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class FormaPolar : NumeroComplejo
    {
        double modulo;
        double argumento;
        public override double Modulo => modulo;
        public override double Argumento => argumento;

        public FormaPolar(double modulo, double argumento)
        {
            this.modulo = modulo;
            this.argumento = argumento % (2 * Math.PI); //primer giro positivo
        }

        public override double ParteReal => Modulo * Math.Cos(Argumento);
        public override double ParteImaginaria => Modulo * Math.Sin(Argumento);

        public override NumeroComplejo Convertir() => new FormaBinomica(ParteReal, ParteImaginaria);
        public override string ToString() => "Z = [ " + Modulo.MyToString() + " ; " + Argumento.MyToString() + " ]";
    }
}

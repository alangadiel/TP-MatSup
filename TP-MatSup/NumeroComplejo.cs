using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class NumeroComplejo
    {
        public FormaBinomica FormaBinomica;
        public FormaPolar FormaPolar;

        public static FormaPolar BinomicaAPolar(FormaBinomica numero)
        => new FormaPolar(numero.Modulo, numero.Argumento);

        public static FormaBinomica PolarABinomica(FormaPolar numero)
        => new FormaBinomica(numero.ParteReal, numero.ParteImaginaria);

        public NumeroComplejo(string num)
        {
            if (num.FirstOrDefault() == '(' && num.LastOrDefault() == ')' && num.Contains(','))
            {
                var n = num.Replace("(", "").Replace(")", "").Split(',');
                if(!double.TryParse(n[0], out var real)) throw new Exception("Formato de la componente real invalido.");
                if(!double.TryParse(n[1], out var img)) throw new Exception("Formato de la componente imaginaria invalido.");

                FormaBinomica = new FormaBinomica(real, img);
            }   
            else if (num.FirstOrDefault() == '[' && num.LastOrDefault() == ']' && num.Contains(";"))
            {
                var n = num.Replace("[", "").Replace("]", "").Split(';');
                if (!double.TryParse(n[0], out var modulo)) throw new Exception("Formato del modulo invalido.");
                if (!double.TryParse(n[1], out var argumento)) throw new Exception("Formato del argumento invalido.");

                FormaPolar = new FormaPolar(modulo, argumento);
            }
            else throw new Exception("Formato invalido.");
        }
    }
}

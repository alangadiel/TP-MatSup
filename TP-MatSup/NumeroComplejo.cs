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
        => new FormaPolar { Angulo = numero.Argumento, Radio = numero.Modulo };

        public static FormaBinomica PolarABinomica(FormaPolar numero)
        => new FormaBinomica { ParteReal = numero.ParteReal, ParteImaginaria = numero.ParteImaginaria };

    }
}

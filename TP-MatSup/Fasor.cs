using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class Fasor
    {
        public enum FunTrig { Sen, Cos };

        public double Amplitud;
        public FunTrig Funcion;
        public double Frecuencia;
        public double Fase;

        public Fasor() { }

        public Fasor(string amplitud, FunTrig funcion, string frecuencia, string fase)
        {
            Amplitud = NumeroComplejo.ParseDouble(amplitud, "Amplitud");
            Funcion = funcion;
            Frecuencia = NumeroComplejo.ParseDouble(frecuencia, "Frecuencia");
            Fase = NumeroComplejo.ParseDouble(fase, "Fase");
        }

        public static Fasor operator +(Fasor f1, Fasor f2)
        {
            if (f1.Frecuencia != f2.Frecuencia)
                throw new Exception("Las frecuencias deben coincidir.");

            if (f1.Funcion != FunTrig.Cos)
            {
                f1.Fase -= (Math.PI / 2.0);
                f1.Funcion = FunTrig.Cos;
            }
            if (f2.Funcion != FunTrig.Cos)
            {
                f2.Fase -= (Math.PI / 2.0);
                f2.Funcion = FunTrig.Cos;
            }

            var n1 = new FormaPolar(f1.Amplitud, f1.Fase);
            var n2 = new FormaPolar(f2.Amplitud, f2.Fase);
            var suma = n1 + n2;

            return new Fasor
            {
                Amplitud = suma.Modulo,
                Funcion = f1.Funcion,
                Frecuencia = f1.Frecuencia,
                Fase = suma.Argumento,
            };
        }

        public override string ToString()
            => Amplitud.MyToString() + " . " + Funcion.ToString() + "( " + Frecuencia.MyToString() + "t + " + Fase.MyToString() + ")";
    }
}

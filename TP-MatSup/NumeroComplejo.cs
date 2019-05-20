using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_MatSup;

namespace TP_MatSup
{
    public abstract class NumeroComplejo
    {
        public abstract double Modulo { get; }
        public abstract double Argumento { get; }
        public abstract double ParteReal { get; }
        public abstract double ParteImaginaria { get; }
        public abstract NumeroComplejo Convertir();
        public static double ParseDouble(string num, string nombre)
        {
            try
            {
                return double.Parse(num, CultureInfo.InvariantCulture);
            }
            catch
            {
                throw new Exception(num == "" ? "Ingrese " + nombre : "Formato de " + nombre + " invalido.");
            }
        }
        public static NumeroComplejo Parse(string num)
        {
            if (num == "") throw new Exception("Ingrese los datos.");

            if (num.FirstOrDefault() == '(' && num.LastOrDefault() == ')' && num.Contains(','))
            {
                var n = num.Replace("(", "").Replace(")", "").Split(',');
                var real = ParseDouble(n[0], "componente real");
                var img = ParseDouble(n[1], "componente imaginaria");

                return new FormaBinomica(real, img);
            }
            else if (num.FirstOrDefault() == '[' && num.LastOrDefault() == ']' && num.Contains(";"))
            {
                var n = num.Replace("[", "").Replace("]", "").Split(';');
                var modulo = ParseDouble(n[0], "modulo");
                var argumento = ParseDouble(n[1], "argumento");

                return new FormaPolar(modulo, argumento);
            }
            else throw new Exception("Formato invalido.");
        }

        //Operaciones Basicas
        public static NumeroComplejo operator +(NumeroComplejo n1, NumeroComplejo n2)
            => new FormaBinomica(n1.ParteReal + n2.ParteReal, n1.ParteImaginaria + n2.ParteImaginaria);
        public static NumeroComplejo operator -(NumeroComplejo n1, NumeroComplejo n2)
            => new FormaBinomica(n1.ParteReal - n2.ParteReal, n1.ParteImaginaria - n2.ParteImaginaria);
        public static NumeroComplejo operator *(NumeroComplejo n1, NumeroComplejo n2)
            => new FormaPolar(n1.Modulo * n2.Modulo, n1.Argumento + n2.Argumento);
        public static NumeroComplejo operator /(NumeroComplejo n1, NumeroComplejo n2)
            => new FormaPolar(n1.Modulo / n2.Modulo, n1.Argumento - n2.Argumento);

        //Operaciones Avanzadas
        public NumeroComplejo Pow(int n)
            => new FormaPolar(Math.Pow(Modulo, n), Argumento * n);
        
        public Raiz[] Root(int n)
        {
            var vec = new Raiz[n];
            for (int k = 0; k < n; k++)
            {
                vec[k] = new Raiz();
                vec[k].NumeroComplejo = new FormaPolar(Math.Pow(Modulo, 1.0 / n), (Argumento + 2 * k * Math.PI) / n);
                vec[k].EsPrimitiva = Helper.MCD(n, k) == 1;
            }
            return vec;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public class Raiz
    {

        public NumeroComplejo NumeroComplejo;
        public bool EsPrimitiva = false;

        public override string ToString()
            => NumeroComplejo.ToString() + (EsPrimitiva ? " (Primitiva)" : "");
    }
}

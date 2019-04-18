using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MatSup
{
    public static class DoubleExtensions
    {
        public static string MyToString(this double n)
            => n.ToString("F", CultureInfo.InvariantCulture);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba3.ClassLibrary;

namespace Laba3.WpfApp.Models
{
    class Model
    {
        public bool IsNumeric(object value)
        {
            return value is sbyte || value is byte ||
                   value is short || value is ushort ||
                   value is int || value is uint ||
                   value is long || value is ulong ||
                   value is decimal || value is float ||
                   value is double;
        }
        public static double GetSquare(double r, double R, double l)
        {
            double result = new ClassSquare().S(r, R, l);
            return result;
        }
    }
}

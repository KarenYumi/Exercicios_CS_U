using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Courser
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;
        public static double Conversor(double dolar, double reais)
        {
            double Total = reais * dolar;
            return Total + (IOF * Total);
        }
        
    }
}

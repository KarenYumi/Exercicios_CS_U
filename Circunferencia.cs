using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser
{
    internal class Circunferencia
    {
        static double pi = 3.14;
        static void Main(string[] args)
        {
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = Circunfe(raio);
            double volume = Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + pi.ToString("F2", CultureInfo.InvariantCulture)) ;
        }

        static double Circunfe(double r)
        {
            return 2.0 * pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * pi * Math.Pow(r, 3.0);
        }
    }
}

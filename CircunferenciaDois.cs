using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser
{
    internal class CircunferenciaDois
    {
        static void Main(string[] args)
        {
            //instanciamos a classe
            ClasseCircunferenciaDois calculadora = new ClasseCircunferenciaDois();
            Console.Write("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double circ = calculadora.Circunfe(raio);
            double volume = calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de PI: " + calculadora.pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

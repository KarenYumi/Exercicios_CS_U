using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser.Retangulo
{
    internal class Retangulo
    {
        static void Main(string[] args)
        {
            ClasseRetangulo p = new ClasseRetangulo();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            p.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Área= " + p.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro= " + p.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal= " + p.Diagonal().ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

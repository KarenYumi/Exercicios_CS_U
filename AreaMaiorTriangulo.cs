﻿using System;
using System.Globalization;
namespace Courser
{
    internal class AreaMaiorTriangulo
    {
        static void Main(string[] args)
        {
            //Leia as medidas de dois triângulos. Em seguida, mostre o valor das áreas dos triangulos e aponte o triângulo com maior área.
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Insira as 3 medidas do triângulo X: ");
             x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p-x.A)*(p-x.B)*(p-x.C));
            

            Console.WriteLine("Insira as 3 medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p = (y.A +y.B +y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

            Console.WriteLine("Área do X: " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área do Y: " + areaY.ToString("F4", CultureInfo.InvariantCulture));
            if(areaX > areaY)
            {
                Console.WriteLine("O X tem área maior");
            }
            else
            {
                Console.WriteLine("O Y tem área maior");
            }

        }
    }
}

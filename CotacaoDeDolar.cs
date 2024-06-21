using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser
{
    internal class CotacaoDeDolar
    {
        static void Main(string[] args)
        {
            
            Console.Write("Qual é a cotação do dolar? ");
            double dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você cai comprar? ");
            double reais = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double resultado = ConversorDeMoeda.Conversor(dolar, reais);
            Console.WriteLine("Valor a ser pago em reais= " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

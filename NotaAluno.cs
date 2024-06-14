using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser
{
    internal class NotaAluno
    {
        static void Main(string[] args)
        {
            ClasseNotaAluno p = new ClasseNotaAluno();

            Console.Write("Nome do Aluno: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            p.NotaA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.NotaB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.NotaC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nNota Final = " + p.Media().ToString("F2", CultureInfo.InvariantCulture));

            if (p.Media() > 60.00)
            {
                Console.WriteLine("\nAPROVADO");
            }
            else
            {
                Console.WriteLine("\nREPROVADO");
                Console.WriteLine("Faltaram " + p.NotaFalta().ToString("F2", CultureInfo.InvariantCulture)+ " pontos");
            }

        }
        
    }
}

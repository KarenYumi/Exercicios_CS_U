using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courser
{
    internal class NomeMediaSal
    {
        static void Main(string[] args)
        {
            ClasseNomeMediaSal x, y;
            x = new ClasseNomeMediaSal();
            y = new ClasseNomeMediaSal(); 

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            x.nome = Console.ReadLine();
            Console.Write("Salário: ");
            x.salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            y.nome = Console.ReadLine();
            Console.Write("Salário: ");
            y.salario = double.Parse(Console.ReadLine());
            double media = (x.salario + y.salario)/2;
            Console.WriteLine("O salario médio: "+ media);

        }
    }
}

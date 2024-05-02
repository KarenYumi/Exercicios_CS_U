using System;

namespace Projeto2
{
     class SomaFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos números inteiros será somado? ");
            int n = int.Parse(Console.ReadLine());
            int soma = 0;
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Numero" + i + ":");
                int num = int.Parse(Console.ReadLine());
                soma += num;
            }
            
            Console.WriteLine("A soma é de" + soma);
        }
    }
}

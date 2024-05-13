using System;
//Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo)


namespace Courser
{
    class Intervalo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a quant de números:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite os " + num + " números");

            int k = 0;
            int c = 0;
            for (int i = 0; i < num; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    k = k + 1;


                }
                else
                {
                    c = c + 1;

                }
            }
            Console.WriteLine(k + " in");
            Console.WriteLine(c + " out");
        }
    }
}

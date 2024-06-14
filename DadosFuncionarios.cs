using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Courser
{
    internal class DadosFuncionarios
    {
        static void Main(string[] args)
        {
            ClasseDadosFuncionarios p = new ClasseDadosFuncionarios();
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            p.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            p.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Funcionário: " + p);

            Console.Write("\nDigite a porcentagem para aumentar o salário: ");
            double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //Lembrar: puxar a classe e colocar o readline dentro do parêntese;
            p.AumentarSalario(porc);

            Console.WriteLine("\nDados Atualizados: " + p);



        }
    }
}

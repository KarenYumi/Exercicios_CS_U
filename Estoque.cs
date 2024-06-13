using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courser
{
     class Estoque {
        static void Main(string[] args) {

            ClasseEstoque p = new ClasseEstoque();

            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados do produto: " + p);

            Console.Write("\n\nDigite o número de produtos a ser adicionado ao estoque: " );
            int quant = int.Parse(Console.ReadLine());
            // chamamos a operação AddProduto que é capaz de receber o valor como entrada (quant) e armazenar na quantidade dentro da Classe
            p.AdicionarProdutos(quant);
            Console.WriteLine("Dados atualizados: " + p);

            Console.Write("\nDigite o número de produtos a ser removido do estoque: ");
            quant = int.Parse(Console.ReadLine());
            p.RemoverProdutos(quant);
            Console.WriteLine("Dado atualizados: " + p);
            Console.WriteLine();


        }
    }
}

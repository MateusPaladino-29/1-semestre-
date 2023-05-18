using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Produto
    {
        public int Codigo { get; private set; }
        public string NomeProduto { get; private set; }
        public float Preco { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string CadastradoPor { get; private set; }
        List<Produto> ListaDeProduto = new List<Produto>();



        public void CadastrarProduto()
        {

            Produto produto = new Produto();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Informe o Nome do produto");
            produto.NomeProduto = Console.ReadLine()!;
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Informe o preço do produto");
            produto.Preco = int.Parse(Console.ReadLine()!);
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Infome o nome de quem esta cadastrando:");
            produto.CadastradoPor = Console.ReadLine()!;
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Informe o codigo do produto");
            produto.Codigo = int.Parse(Console.ReadLine()!);
            Console.ResetColor();


            produto.DataCadastro = DateTime.UtcNow;

            ListaDeProduto.Add(produto);

        }

        public void ListarProduto()
        {
            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine(@$"
                
            Nome do produto: {item.NomeProduto}
            Preço do produto: {item.Preco}
            Nome de quem esta cadastrando: {item.CadastradoPor}
            Código do produto: {item.Codigo}
            Data de Criação do produto: {item.DataCadastro}

                ");

            }
        }

        public void DeletarProduto(int codigoproduto)
        {

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"tem certeza que Deseja deletar algum produto? s/n");
            Console.ResetColor();
            char deletar = char.Parse(Console.ReadLine()!);

            if (deletar == 's')
            {

                Produto P = ListaDeProduto.Find(x => x.Codigo == codigoproduto);
                ListaDeProduto.Remove(P);

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Marca deletada da lista ");
                Console.ResetColor();
            }

            else
            {

                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"Certo nao deletaremos nada");
                Console.ResetColor();

            }


        }








    }
}
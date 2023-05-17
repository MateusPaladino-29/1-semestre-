using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; }
        public string CadastradoPor { get; set; }
        List<Produto> ListaDeProduto = new List<Produto>();

        public void Cadastrar()
        {
            Console.WriteLine($"Informe o Nome do produto");
            NomeProduto = Console.ReadLine()!;

            Console.WriteLine($"Informe o preço do produto");
            Preco = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Infome o nome de quem esta cadastrando:");
            CadastradoPor = Console.ReadLine()!;

            Console.WriteLine($"Informe o codigo do produto");
            Codigo = int.Parse(Console.ReadLine()!);


            DataCadastro = DateTime.UtcNow;

            Console.WriteLine(@$"
            
            Nome do produto: {NomeProduto}
            Preço do produto: {Preco}
            Nome de quem esta cadastrando: {CadastradoPor}
            Código do produto: {Codigo}
            Data de cadastro: {DataCadastro}           
            ");
        }

        public void Listar()
        {
            foreach (var item in ListaDeProduto)
            {
                Console.WriteLine(@$"
                
            Nome do produto: {item.NomeProduto}
            Preço do produto: {item.Preco}
            Nome de quem esta cadastrando: {item.CadastradoPor}
            Código do produto: {item.Codigo}

                ");

            }
        }

        public void Deletar(int codigoproduto)
        {
          Console.WriteLine($"Deseja deletar algum produto? s/n");
            char deletar = char.Parse(Console.ReadLine()!);

            if (deletar == 's')
            {

                Produto P = ListaDeProduto.Find(x => x.Codigo == codigoproduto);
                ListaDeProduto.Remove(P);
                
                Console.WriteLine($"Marca deletada da lista ");
            }

            else
            {
                Console.WriteLine($"Certo nao deletaremos nada");

            }

           
        }








    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DateCadastro { get; set; }

        List<Marca> ListaDeMarca = new List<Marca>();


        Marca marca = new Marca();

        public void Cadastrar()
        {
           

            Console.WriteLine($"Informe o código da marca que deseja cadastrar");
            Codigo = int.Parse(Console.ReadLine()!);

            Console.WriteLine($"Informe o nome da marca:");
            NomeMarca = Console.ReadLine()!;

            DateCadastro = DateTime.UtcNow;
        }

        // Pedir ajuda do professor para criar as listas pq faltei 
        public void Listar()
        {
            foreach (var item in ListaDeMarca)
            {
                Console.WriteLine(@$"       
                Nome da marca: {item.NomeMarca}
                Código da Marca: {item.Codigo}
                Data de criação; {item.DateCadastro}     
                ");

            }
        }

        public void Deletar(int codigomarca)
        {
            Console.WriteLine($"Deseja deletar alguma marca? s/n");
            char deletar = char.Parse(Console.ReadLine()!);

            if (deletar == 's')
            {

                Marca M = ListaDeMarca.Find(x => x.Codigo == codigomarca);
                ListaDeMarca.Remove(M);

                Console.WriteLine($"Marca deletada da lista ");
            }

            else
            {
                Console.WriteLine($"Certo nao deletaremos nada");

            }


        }









    }
}
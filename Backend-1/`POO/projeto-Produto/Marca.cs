
namespace projeto_Nome
{
    public class Marca
    {
        public int Codigo { get; private set; }
        public string NomeMarca { get; private set; }
        public string CadastradoPor { get; private set; }
        public DateTime DataCadastro { get; private set; }
        List<Marca> ListaDeMarca = new List<Marca>();


        public void CadastrarMarca()
        {
            Marca marca = new Marca();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Informe o código da marca que deseja cadastrar");
            marca.Codigo = int.Parse(Console.ReadLine()!);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Informe o nome da marca:");
            marca.NomeMarca = Console.ReadLine()!;
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Nome de quem esta cadastrando a marca:");
            marca.CadastradoPor = Console.ReadLine()!;
            Console.ResetColor();

            DataCadastro = DateTime.UtcNow;

            ListaDeMarca.Add(marca);


        }

        // Pedir ajuda do professor para criar as listas pq faltei 
        public void ListarMarca()
        {
            foreach (var item in ListaDeMarca)
            {
                Console.WriteLine(@$"
                
            Nome do produto: {item.NomeMarca}
            Nome de quem esta cadastrando: {item.CadastradoPor}
            Código do produto: {item.Codigo}
            Data de cadastro: {item.DataCadastro}

                ");

            }

        }

        public void DeletarMarca(int codigomarca)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Tem certeza que deseja deletar alguma marca? s/n");
            Console.ResetColor();
            char deletar = char.Parse(Console.ReadLine()!);

            if (deletar == 's')
            {

                Marca M = ListaDeMarca.Find(x => x.Codigo == codigomarca);
                ListaDeMarca.Remove(M);

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Marca deletada da lista ");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"Certo nao deletaremos nada");
                Console.ResetColor();

            }


        }









    }
}
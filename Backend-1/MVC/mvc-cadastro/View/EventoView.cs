using mvc_cadastro.Model;
namespace mvc_cadastro.View
{
    public class EventoView
    {
        


        public void Listar(List<Evento> evento)
        {
            foreach (var item in evento)
            {
                Console.WriteLine($"\n Nome: {item.Nome}");
                Console.WriteLine($"Descrição:{item.Descricao} ");
                Console.WriteLine($"Data: {item.Data}");            
            }
        }

        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o nome do evento:");
            novoEvento.Nome = Console.ReadLine();
            
            Console.WriteLine($"Informe a descrição do evento");
            novoEvento.Descricao = Console.ReadLine();
            
            Console.WriteLine($"Informe a data do evento: ");
            novoEvento.Data = DateTime.Parse(Console.ReadLine()!);

            return novoEvento;

        }


         public void MenuAmor()
        {

            
            Console.WriteLine(@$"
            
            [1] Cadastro de evento

            [2] Lista de evento
            
            ");

            Console.WriteLine($"Qual opção deseja escolher? 1 ou 2");
            int opcao = int.Parse(Console.ReadLine()!);

        }

    }
    
}
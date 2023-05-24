
using Produto_mvc.Model;

namespace Produto_mvc.View
{
    public class ProdutoView
    {
        // metodo psrs exibir os dados da lista no console 

        public void Listar(List<Produto> produto)
        {
            foreach (var item in produto)
            {
                Console.WriteLine($"\nCódigo: {item.Codigo}");
                Console.WriteLine($"Nome: {item.Nome}");
                Console.WriteLine($"Preço: {item.Preco:C}");               
            }
        }
    }
}

using Produto_mvc.Model;
using Produto_mvc.View;

namespace Produto_mvc.Controller
{
    public class ProdutoController
    {

        // instancia de classes de Produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();



        // Metodo controlador para acessar a listagem de produtos cadastrados 
        public void ListarProduto()
        {
            List<Produto> produtos = produto.Ler();

            produtoView.Listar(produtos);
        }

        public void CadastrarProduto()
        {
            
            Produto Produtinho = produtoView.Cadastrar();          
            produto.Inserir(Produtinho);

        }
    }
}

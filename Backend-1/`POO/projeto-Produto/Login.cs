
namespace projeto_Nome
{
    public class Login
    {
        public bool Logado { get; set; }

        // Construtor
        public Login()
        {

            Usuario user = new Usuario();


            Logar(user);

            if (Logado == true)
            {
               GerarMenu();
            }

        }

        public void Logar(Usuario usuario)
        {
            Console.WriteLine($"Informe o Email:");
            String EmailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe a senha:");
            string SenhaDigitada = Console.ReadLine()!;

            if (EmailDigitado == usuario.Email && SenhaDigitada == usuario.Senha)
            {
                this.Logado = true;
                Console.WriteLine($"Login efetuado com sucesso");
                
            }
            else
            {
                this.Logado = false;
                Console.WriteLine($"Falha ao executar Login");
                
            }
        }

        public void Deslogar()
        {
            this.Logado = false;
        }

        public void GerarMenu()
        {

            Produto produto = new Produto();

            Marca marca = new Marca();

        menu:
            // fazer menu

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"
            MENUZINHO DO AMOR 
            **********************
            [1] Cadastrar Produto
            [2] Listar Produto 
            [3] Deletar Produto
           *************************
            [4] Cadastrar Marca 
            [5] Listar Marca 
            [6] Deletar Marca

            [0] Sair do programa

            ");
            Console.ResetColor();
            
            Console.WriteLine($"Escolha uma opção do nosso menu");           
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1:
                    // Cadastrar produto; produto.Cadastrar 
                    produto.CadastrarProduto();

                    goto menu;
                    // goto
                    break;

                case 2:
                    // Listar produto: produto.listar
                    produto.ListarProduto();
                    goto menu;

                    // goto
                    break;

                case 3:
                    // exluir o codigo do produto: produto.Deletar(codigoproduto) codigoproduto

                    Console.WriteLine($"Informe o codigo da marca que deseja ser removido:");
                    int codigoproduto = int.Parse(Console.ReadLine()!);

                    produto.DeletarProduto(codigoproduto);
                    goto menu;

                    // goto
                    break;

                case 4:
                    // cadastrar marca : marca.cadastrar()

                    marca.CadastrarMarca();
                    goto menu;

                    // goto
                    break;

                case 5:
                    // listar marcas: marca.Listar()

                    marca.ListarMarca();
                    goto menu;

                    // goto
                    break;

                case 6:
                    // deletar: marca.Deletar(codigoMarca) 

                    Console.WriteLine($"Informe o codigo da marca que deseja ser removido:");
                    int codigomarca = int.Parse(Console.ReadLine()!);
                    marca.DeletarMarca(codigomarca);
                    goto menu;

                    // goto
                    break;

                case 0:
                    Console.WriteLine($"Saindo do programinha do amor");
                    Environment.Exit(0);
                    break;
                default:

                    break;
            }


        }

    }
}
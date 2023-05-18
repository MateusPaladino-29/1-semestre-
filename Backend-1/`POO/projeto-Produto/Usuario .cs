using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Usuario
    {
        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }

        public Usuario()
        {
            Cadastrar();
            Deletar();
        }

        public void Cadastrar()
        {
            Console.WriteLine($"Informe o seu nome");
            Nome = Console.ReadLine()!;

            Console.WriteLine($"Informe seu email");
            Email = Console.ReadLine()!;

            Console.WriteLine($"Informe sua senha");
            Senha = Console.ReadLine()!;

            Console.WriteLine($"Informe o codigo de cadastro de sua preferencia");
            Codigo = int.Parse(Console.ReadLine()!);

            DataCadastro = DateTime.Now;


            Console.WriteLine(@$"
            
            Nome: {Nome}

            Email: {Email}

            Senha: {Senha}

            Codigo: {Codigo}

            Data: {DataCadastro}
            
            ");
        }

        public void Deletar()

        {
            Console.WriteLine($"Deseja excluir seu cadastro? S(Sim) // N (Nao)");
            char delete = char.Parse(Console.ReadLine()!.ToUpper());


            if (delete == 'S')
            {
                Nome = "";
                Email = "";
                Senha = "";
                Codigo = 0;
            }

            else
            {
                Console.WriteLine($"Tudo bem, contiaremos para o Login");
            }
        }
    }
}
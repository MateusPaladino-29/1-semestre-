using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Usuario 
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public Usuario()
        {
          Cadastrar();
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
        
            DataCadastro = DateTime.UtcNow;


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
              Console.WriteLine(@$"
            
            Nome: {Nome}

            Email: {Email}

            Senha: {Senha}

            Codigo: {Codigo}

            Data: {DataCadastro}
            
            ");
            
          }

        }      
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_Nome
{
    public class Marca
    {
        public Marca(string codigo, DateTime dateCadastro) 
        {
            this.Codigo = codigo;
    this.DateCadastro = dateCadastro;
   
        }
                public string Codigo { get; set; }
        public string NomeMarca { get; set; }
        public DateTime DateCadastro { get; set; }

        private string Cadastrar( Marca _cadastro)
        {

            codigo:
            Console.WriteLine($"Informe o código do produto que deseja cadastrar");
            Codigo = (Console.ReadLine()!); 

            if (Codigo == Codigo)
            {
                Console.WriteLine($"codigo validado");
                
            }

            else
            {
                Console.WriteLine($"codigo invalido");
                goto codigo;
            }

            Console.WriteLine($"Informe o nome da marca:");
            NomeMarca = Console.ReadLine()!;
            

            DateCadastro = DateTime.Now;
          
            return "Marca de Cadastro com Sucesso";  
        }

        // Pedir ajuda do professor para criar as listas pq faltei 
        public string Listar(Marca _lista )
        {
            List<Marca> ListaDeMarca = new List<Marca>();

            Marca M = new Marca();

            ListaDeMarca.Add(M);
            
            return "Lista de Marcas" ; 
        }


        public string Deletar(Marca _listagem)
        {
            Console.WriteLine($"Deseja deletar alguma marca? sim/nao");
            string deletar = Console.ReadLine()!;

            List<Marca> ListaDeMarca = new List<Marca>();
            
            if (deletar == "sim")
            {
                
                 
                               
                Console.WriteLine($"Marca deletada da lista ");  
            }

            else 
            {
                Console.WriteLine($"Certo nao detaremos nada");
                
            }   

            return NomeMarca;        
        }



        
        
        
        
        
        
    }
}
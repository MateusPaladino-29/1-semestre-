using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROJETO_GAMER.Models
{
    public class Jogador 
    {
        [Key]
        public int IdJogador { get; set; }
        public string? nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }

        // Chamando a classe equipe e criando uma chave estrangeira
        [ForeignKey("Equipe")]
        public int IdEquipe { get; set; }
        public Equipe Equipe { get; set; }
        
        
        
        
        
        
        
        
    }
}


using Microsoft.EntityFrameworkCore;
using PROJETO_GAMER.Models;

namespace PROJETO_GAMER.Infra
{
    public class Context : DbContext
    {
        public Context()
        {

        }

        public Context(DbContextOptions<Context> options ) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
           {
             optionsBuilder.UseSqlServer("Data Source = NOTE23-S15; Initial catalog = projetoGamer; integrated Security = true; TrustServerCertificate = true ");
           }
        }

        public DbSet<Jogador> Jogador {get; set;}
        public DbSet<Equipe> Equipe {get; set;}
     
    }
}
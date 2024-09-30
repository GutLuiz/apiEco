using api.model;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace api.infraestrutura
{
    public class Conexaobd : DbContext
    {
        public DbSet<login> login { get; set; }

        public DbSet<agendamento> agendamento {  get; set; }           
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql("Server=Localhost;Port=5432;Database=eco;User id=postgres;Password=root;")
                .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        }

    }
}

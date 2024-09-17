using api.model;
using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace api.infraestrutura
{
    public class Conexaobd : DbContext
    {
        public DbSet<login> logins { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
            "Server=Localhost;" +
            "Port=5432;Database=eco;"+
            "User id=postgres;" +
            "Password=root;"
            );


    }
}

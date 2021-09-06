using BR_JS.Dominio.Modelos;
using BR_JS.Infraestrutura.Mapeamento;
using Microsoft.EntityFrameworkCore;

namespace BR_JS.Infraestrutura.Dados
{
    public class DadosEmContexto : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Password=Password;Persist Security Info=True;User ID=user;Initial Catalog=master;Data Source=Null";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapa());
        }
    }
}

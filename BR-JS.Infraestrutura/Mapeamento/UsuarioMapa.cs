using BR_JS.Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BR_JS.Infraestrutura.Mapeamento
{
    public class UsuarioMapa : IEntityTypeConfiguration<Usuario>
    {

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Nome).HasMaxLength(60).IsRequired();

            builder.Property(x => x.Email).IsRequired();

            builder.Property(x => x.Senha).IsRequired();
        }
    }
}

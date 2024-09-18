using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using swegger.Models;


namespace swegger.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(x => x.ID_USU);
            builder.Property(x => x.NOME_USU).IsRequired().HasMaxLength(255);
            builder.Property(x => x.MATR_USU).IsRequired().HasMaxLength(10);
            builder.Property(x => x.DATA_NASC).IsRequired();
            builder.Property(x => x.EMAIL).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ORIGEM).IsRequired().HasMaxLength(1);
        }
    }
}

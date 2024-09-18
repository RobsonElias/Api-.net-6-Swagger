using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using swegger.Models;

namespace swegger.Data.Map
{
    public class TipoDeUsuarioMap : IEntityTypeConfiguration<TipoDeUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoDeUsuario> builder)
        {
            builder.HasKey(x => x.ID_TIPOUSUARIO);
            builder.Property(x => x.ORIGEM).IsRequired().HasMaxLength(1);
            builder.Property(x => x.DESCR).IsRequired().HasMaxLength(100);
        }
    }
}

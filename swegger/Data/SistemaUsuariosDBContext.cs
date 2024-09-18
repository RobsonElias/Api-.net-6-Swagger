using Microsoft.EntityFrameworkCore;
using swegger.Data.Map;
using swegger.Models;

namespace swegger.Data
{
    public class SistemaUsuariosDBContext : DbContext
    {
        public SistemaUsuariosDBContext(DbContextOptions<SistemaUsuariosDBContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoDeUsuario> TiposDeUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new TipoDeUsuarioMap());

            base.OnModelCreating(modelBuilder);
        }



    }
}

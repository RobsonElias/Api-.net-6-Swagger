using Microsoft.EntityFrameworkCore;
using swegger.Data;
using swegger.Models;
using swegger.Repositorios.Interfaces;

namespace swegger.Repositorios

{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly SistemaUsuariosDBContext _dbContext;
        public UsuarioRepositorio(SistemaUsuariosDBContext sistemaUsuariosDBContext)
        {
            _dbContext = sistemaUsuariosDBContext;
        }
        public async Task<Usuario> BuscarPorId(int id)
        {
            return await _dbContext.Usuario.FirstOrDefaultAsync(x => x.ID_USU == id);
        }
        
        public async Task<List<Usuario>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuario.ToListAsync();
        }

        public async Task<Usuario> Incluir(Usuario usuario)
        {
            await _dbContext.Usuario.AddAsync(usuario);
            _dbContext.SaveChanges();

            return usuario;
        }
                
        public async Task<List<Usuario>> BuscarTodosUsuariosOrigem(string tipo)
        {
            string sql = $"sp_GetUsuariosPorOrigem {tipo}";
            return await _dbContext.Set<Usuario>()
                                    .FromSqlRaw(sql)
                                    .ToListAsync();
        }
        
    }
}

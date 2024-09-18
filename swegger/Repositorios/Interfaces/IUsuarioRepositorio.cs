
using swegger.Models;

namespace swegger.Repositorios.Interfaces
{
    public interface IUsuarioRepositorio
    {

        Task<List<Usuario>> BuscarTodosUsuarios();
        Task<Usuario> BuscarPorId(int id);
        Task<Usuario> Incluir(Usuario usuario);
        Task<List<Usuario>> BuscarTodosUsuariosOrigem(string origem);
    }
}

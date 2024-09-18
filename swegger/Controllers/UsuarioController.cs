using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using swegger.Models;
using swegger.Repositorios.Interfaces;

namespace swegger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<Usuario>>> BuscarUsuarios()
        {

            List<Usuario> usuarios = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Usuario>> BuscarPorId(int id)
        {

            Usuario usuario = await _usuarioRepositorio.BuscarPorId(id);
            return Ok(usuario);
        }

        [HttpGet("buscar/{origem}")]
        public async Task<ActionResult<Usuario>> BuscarPorOrigem(string origem)
        {

            List<Usuario> usuarios = await _usuarioRepositorio.BuscarTodosUsuariosOrigem(origem);
            return Ok(usuarios);
        }

        [HttpPost]
        public async Task<ActionResult<Usuario>> Incluir([FromBody] Usuario usuario)
        {
            Usuario usuarioFinal = await _usuarioRepositorio.Incluir(usuario);
            return Ok();
        }
    }
}

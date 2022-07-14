using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagoServicio.Application.Service.Interfaces;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using System.Threading.Tasks;

namespace PagoServicio.API.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }
        
        [HttpPost]
        [Route("ConsultarUsuario")]
        public async Task<UsuarioModel> ConsultarUsuario(Usuario usuario)
        {
            return await _usuarioService.ConsultarUsuario(usuario);
        }
    }
}

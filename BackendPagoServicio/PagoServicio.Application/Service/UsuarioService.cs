using PagoServicio.Application.Service.Interfaces;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using PagoServicio.Dominio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Application.Service
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioService(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public async Task<UsuarioModel> ConsultarUsuario(Usuario usuario)
        {
            UsuarioModel model = new UsuarioModel();
            try
            {
                model = await _usuarioRepository.ConsultarUsuario(usuario);
                if (model!=null)
                {
                    model.Estado = true;
                    model.Mensaje = Constantes.Constantes.MensajeUsuarioCorrecto;
                }
                else
                {
                    model = new UsuarioModel();
                    model.Estado = true;
                    model.Mensaje = Constantes.Constantes.MensajeUsuarioNoExiste;
                }
            }
            catch (Exception ex)
            {
                model.Estado = false;
                model.Mensaje = Constantes.Constantes.MensajeError;

            }
            return model;
        }
    }
}

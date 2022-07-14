using Microsoft.EntityFrameworkCore;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using PagoServicio.Dominio.Repository;
using PagoServicio.Infraestructure.Mapeador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Infraestructure.Data
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly pagoservicioContext _context;
        private readonly IMapear _mapear;

        public UsuarioRepository(pagoservicioContext context, IMapear mapear)
        {
            _context = context;
            _mapear = mapear;
        }

        public async Task<UsuarioModel> ConsultarUsuario(Usuario usuario)
        {
            UsuarioModel model = new UsuarioModel();
            Usuario user = new Usuario();
            user = await _context.Usuarios.Where(x => x.Contrasenia == usuario.Contrasenia && x.CorreoElectronico == usuario.CorreoElectronico).FirstOrDefaultAsync();
            model = _mapear.mapper.Map(user, new UsuarioModel());
            return model;
        }
    }
}

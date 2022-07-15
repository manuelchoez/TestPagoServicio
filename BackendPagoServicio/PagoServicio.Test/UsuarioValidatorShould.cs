using Moq;
using PagoServicio.API.Controllers;
using PagoServicio.Application.Service.Interfaces;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace PagoServicio.Test
{
    public class UsuarioValidatorShould
    {
        [Fact]
        public async void When_Search_User_ReturnUser()
        {
            //datos

            Usuario model = new Usuario();
            model.Contrasenia = "1234";
            model.CorreoElectronico = "manuelchoez@gmail.com";
            UsuarioModel usermodel = new UsuarioModel();
            usermodel.CorreoElectronico = "manuelchoez@gmail.com";
            usermodel.Contrasenia = "1234";
            usermodel.Mensaje = "Usuario Correcto";
            var usuarioService = new Mock<IUsuarioService>();
            usuarioService.Setup(_ => _.ConsultarUsuario(model)).ReturnsAsync(usermodel);
            UsuarioController userController = new UsuarioController(usuarioService.Object);                        

            //accion
            var resultado = await userController.ConsultarUsuario(model);

            //afirmacion
            Assert.Equal(usermodel.Mensaje, resultado.Mensaje);


        }
    }
}

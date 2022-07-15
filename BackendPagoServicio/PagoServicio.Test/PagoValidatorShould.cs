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
    public class PagoValidatorShould
    {
        [Fact]
        public async void When_Add_Pago_ReturnMensajePagoExitoso()
        {
            //datos
            Pago p = new Pago();
            p.FechaPago = DateTime.Now;
            p.PagoProcesado = true;
            p.CedulaCliente = "1312677881";
            p.IdServicio = 1;
            PagoModel model = new PagoModel();
            model.Mensaje = "Se realizo el pago del servicio";
            var pagoServicio = new Mock<IPagoService>();
            pagoServicio.Setup(_ => _.RealizarPago(p)).ReturnsAsync(model);
            PagoController pagoController = new PagoController(pagoServicio.Object);

            //accion
            var resultado = await pagoController.RealizarPago(p);

            //afirmacion
            Assert.Equal(model.Mensaje, resultado.Mensaje);


        }
    }
}

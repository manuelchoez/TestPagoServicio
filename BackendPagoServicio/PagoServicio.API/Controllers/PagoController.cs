using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PagoServicio.Application.Service.Interfaces;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using System.Threading.Tasks;

namespace PagoServicio.API.Controllers
{
    [Route("api/pago")]
    [ApiController]
    public class PagoController : ControllerBase
    {
        private readonly IPagoService _pagoServicio;
        public PagoController(IPagoService pagoServicio)
        {
            _pagoServicio = pagoServicio;
        }

        [HttpPost]
        [Route("RealizarPago")]
        public async Task<PagoModel> RealizarPago(Pago pago)
        {
            return await _pagoServicio.RealizarPago(pago);
        }
    }
}

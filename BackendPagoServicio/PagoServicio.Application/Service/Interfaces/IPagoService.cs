using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Application.Service.Interfaces
{
    public interface IPagoService
    {
        Task<PagoModel> RealizarPago(Pago pago);
    }
}

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
    public class PagoService: IPagoService
    {
        private readonly IPagoRepository _pagoRepository;
        
        public PagoService(IPagoRepository pagoRepository)
        {
            _pagoRepository = pagoRepository;
        }

        public async Task<PagoModel> RealizarPago(Pago pago)
        {
            PagoModel model = new PagoModel();
            try
            {             
                model = await   _pagoRepository.RealizarPago(pago);
                model.Estado = true;
                model.Mensaje = Constantes.Constantes.MensajePagoServiciocorrecto;
            }
            catch (Exception ex)
            {
                model.Estado = true;
                model.Mensaje = Constantes.Constantes.MensajeError;                
            }
            return model;
        }
    }
}

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
    public class PagoRepository : IPagoRepository
    {
        private readonly pagoservicioContext _context;
        private readonly IMapear _mapear;

        public PagoRepository(pagoservicioContext context, IMapear mapear)
        {
            _context = context;
            _mapear = mapear;
        }

        public async Task<PagoModel> RealizarPago(Pago pago)
        {
            PagoModel p = new PagoModel();
             _context.Pagos.Add(pago);
            await _context.SaveChangesAsync().ConfigureAwait(true);
            p = _mapear.mapper.Map<PagoModel>(pago);
            return p;
        }
    }
}

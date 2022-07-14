﻿using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Dominio.Repository
{
    public interface IPagoRepository
    {
        Task<PagoModel> RealizarPago(Pago pago);
    }
}

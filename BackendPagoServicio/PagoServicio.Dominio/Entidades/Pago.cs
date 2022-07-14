using System;
using System.Collections.Generic;

#nullable disable

namespace PagoServicio.Dominio.Entidades
{
    public partial class Pago
    {
        public int IdPago { get; set; }
        public DateTime? FechaPago { get; set; }
        public string CedulaCliente { get; set; }
        public int? IdServicio { get; set; }
        public bool? PagoProcesado { get; set; }
    }
}

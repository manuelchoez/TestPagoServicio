using PagoServicio.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Dominio.Modelos
{
    public class PagoModel:Pago
    {
        public string Mensaje { get; set; }
        public bool Estado { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace PagoServicio.Dominio.Entidades
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string CorreoElectronico { get; set; }
        public string Contrasenia { get; set; }
    }
}

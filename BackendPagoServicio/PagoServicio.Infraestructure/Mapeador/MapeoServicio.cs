using AutoMapper;
using PagoServicio.Dominio.Entidades;
using PagoServicio.Dominio.Modelos;
using PagoServicio.Infraestructure.Mapeador.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoServicio.Infraestructure.Mapeador
{
    public class MapeoServicio: IMapear
    {
        public MapeoServicio()
        {
            MapperConfiguration config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Pago, PagoModel>().ReverseMap();
                cfg.CreateMap<Usuario, UsuarioModel>().ReverseMap();

            });
            mapper = config.CreateMapper();
        }
    }
}

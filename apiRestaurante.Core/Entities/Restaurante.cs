using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Restaurante
    {
        public Restaurante()
        {
            icSalones = new Collection<Salones>();
            icBodegas = new Collection<Bodegas>();
        }

        public int id_restaurante { get; set; }
        public string cedula_juridica { get; set; }
        public string razon_social { get; set; }
        public string razon_comercial { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public string logo { get; set; }
        public int id_pais { get; set; }
        public int id_provincia { get; set; }
        public int id_canton { get; set; }
        public int id_distrito { get; set; }
        public int direccion { get; set; }
        public ICollection<Salones> icSalones { get; set; }
        public ICollection<Bodegas> icBodegas { get; set; } 

    }
}

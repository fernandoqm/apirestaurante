using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Salones
    {
        public int id_salon { get; set; }
        public int id_restaurante { get; set; }
        public string descripcion { get; set; }
        public int capacidad { get; set; }
        public int tiempo_limpieza_minutos { get; set; }
        public string estado { get; set; }
        public int ubicacion { get; set; }
        public Restaurante objRestaurante { get; set; }

    }
}

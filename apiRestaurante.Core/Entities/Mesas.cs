using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Mesas
    {
        public int id_mesa { get; set; }
        public int id_salon { get; set; }
        public int id_restaurante { get; set; }
        public int capacidad { get; set; }
        public int alquilada { get; set; }
    }
}

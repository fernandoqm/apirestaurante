using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Bodegas
    {
        public int id_bodega { get; set; }
        public int id_restaurante { get; set; }
        public string nombre { get; set; }

    }
}

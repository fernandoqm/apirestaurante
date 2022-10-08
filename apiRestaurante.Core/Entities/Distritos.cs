using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Distritos
    {
        public int id_pais { get; set; }
        public int id_provincia { get; set; }
        public int id_canton { get; set; }
        public int id_distrito { get; set; }
        public string nombre_distrito { get; set; }

    }
}

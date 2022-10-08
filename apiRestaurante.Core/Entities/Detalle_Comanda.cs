using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Detalle_Comanda
    {
        public int id_comanda { get; set; }
        public int linea { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
        public int id_area_despacho { get; set; }
        public string despachada { get; set; }
        public string entregado { get; set; }
        public string usuario_solicita { get; set; }
        public string confirmado { get; set; }
        public int notas_linea { get; set; }
        public string fecha_solicita { get; set; }
        public Comanda objComanda { get; set; }

    }
}

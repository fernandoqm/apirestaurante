using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Productos
    {
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public double tiempo_preparacio { get; set; }
        public double existencias_min { get; set; }
        public double existencias_max { get; set; }
        public int id_bodega { get; set; }
        public int es_preparado { get; set; }
        public string activo { get; set; }
        public int es_receta { get; set; }
        public int id_receta { get; set; }
        public string imagen { get; set; }
        public double precio_venta { get; set; }
        public double impuesto { get; set; }
        public string solicita_cocina { get; set; }
        public int id_area_despacho { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apiRestaurante.Core.Entities
{
    public class Comanda
    {
        public Comanda()
        {
            icDetalle_Comanda = new Collection<Detalle_Comanda>();
        }
        public int id_comanda { get; set; }
        public int id_mesa { get; set; }
        public string fecha_comanda { get; set; }
        public string usuario_registra { get; set; }
        public int id_salon { get; set; }
        public string hora_apertura { get; set; }
        public string estado { get; set; }
        public string usuario_cierra { get; set; }
        public string hora_cierre { get; set; }
        public string notas { get; set; }
        public ICollection<Detalle_Comanda> icDetalle_Comanda { get; set; }


    }
}

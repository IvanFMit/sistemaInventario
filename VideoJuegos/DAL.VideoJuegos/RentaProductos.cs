using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VideoJuegos
{
    public class ProductosRenta
    {
        public int Id { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ConsolaDescripcion { get; set; }
        public DateTime Fecha { get; set; }
        public int TipoRentaId { get; set; }
        public string TipoRentaDescripcion { get; set; }
        public decimal Precio { get; set; }
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        public string TipoMovimiento { get; set; }
        public int cantidad { get; set; }
    }
}

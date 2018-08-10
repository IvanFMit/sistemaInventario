using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.VideoJuegos;

namespace Win.VideoJuegos
{
    public class ReporteProductosPorConsola
    {
        VideoJuegosBL _ef;

        public ReporteProductosPorConsola()
        {
            _ef = new VideoJuegosBL();
        }


        public List<ResultadoeporteProductosPorConsola> ObtenerDatosParaReporte()
        {
            var listaResultado = new List<ResultadoeporteProductosPorConsola>();

            foreach (var item in _ef.ObtenerTodosProductosConsolas())
            {
                listaResultado.Add(new ResultadoeporteProductosPorConsola()
                {
                    Id = item.Producto.Id,
                    ProductoDescripcion = item.Producto.Descripcion,
                    ConsolaDescripcion = item.Consola.Descripcion
                });
            }

            return listaResultado;
        }
    }

    public class ResultadoeporteProductosPorConsola
    {
        public int Id { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ConsolaDescripcion { get; set; }
    }
}

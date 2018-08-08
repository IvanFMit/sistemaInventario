using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.VideoJuegos
{
    public partial class VideoJuegosBL
    {
		public List<TipoRenta> ObtenerTipoRenta()
        {
            return _ef.TipoRenta.ToList();
            
        }
    }
}

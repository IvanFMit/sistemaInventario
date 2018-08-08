using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VideoJuegos
{
    public partial class VideoJuegosBL
    {
        public List<Cliente> ObtenerClientes(string buscar)
        {
            return _ef.Cliente.Where((r) => r.Nombre.Contains(buscar)
                || r.Telefono.Contains(buscar)).ToList();
        }
    }
}

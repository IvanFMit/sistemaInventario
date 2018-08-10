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

        public List<Cliente> ObtenerClientesLista()
        {
            return _ef.Cliente.ToList();
        }

        public void GuardarClientes(List<Cliente> clientes)
        {
            foreach (var cliente in clientes)
            {
                if (cliente.Id < 1)
                {
                    var nuevoCliente = new Cliente();
                    nuevoCliente.Nombre = cliente.Nombre;
                    nuevoCliente.Telefono = cliente.Telefono;
                    _ef.Cliente.Add(nuevoCliente);
                }
                else
                {
                    var clienteEnDB = _ef.Cliente.FirstOrDefault((r) => r.Id == cliente.Id);
                    if (clienteEnDB != null)
                    {
                        clienteEnDB.Nombre = cliente.Nombre;
                        clienteEnDB.Telefono = cliente.Telefono;
                    }
                }
            }
            _ef.SaveChanges();
        }
    }
}

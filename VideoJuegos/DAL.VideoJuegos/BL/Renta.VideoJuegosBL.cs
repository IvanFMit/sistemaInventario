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

     
        public bool GuardarRenta(List<ProductosRenta> listaProductosRenta)
        {
            try
            {
                foreach (var item in listaProductosRenta)
                {
                    var nuevaRenta = new Renta()
                    {
                        CodigoProductoConsola = item.Id,
                        Fecha = item.Fecha,
                        CodigoTipoRenta = item.TipoRentaId,
                        PrecioRenta = item.Precio,
                        TipoDocumento = item.TipoMovimiento,
                        CodigoCliente = item.ClienteId
                    };

                    var producto = _ef.ProductoConsola.First((r) => r.Id == item.Id);

                    if (item.TipoMovimiento == "Renta")
                    {
                        producto.Disponibilidad -= 1;
                    }
                    else
                    {
                        producto.Disponibilidad += 1;
                    }

                    _ef.Renta.Add(nuevaRenta);
                }

                _ef.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool GuardarInv(List<ProductosRenta> listaProductosRenta2)
        {
            try
            {
                foreach (var item in listaProductosRenta2)
                {
                    var nuevaRenta = new Renta()
                    {
                        CodigoProductoConsola = item.Id,
                        Fecha = item.Fecha,
                        CodigoTipoRenta = item.TipoRentaId,
                        PrecioRenta = item.Precio,
                        TipoDocumento = item.TipoMovimiento,
                        CodigoCliente = item.ClienteId
                                                                 };

                    var producto = _ef.ProductoConsola.First((r) => r.Id == item.Id);

                    if (item.TipoMovimiento == "Salida")
                    {
                        producto.Existencia -= item.cantidad;
                    }
                    else
                    {
                        producto.Existencia += item.cantidad;
                    }

                    _ef.Renta.Add(nuevaRenta);
                }

                _ef.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<Renta> ObtenerListadoRenta()
        {
            return _ef.Renta.ToList();
        }
    }
}

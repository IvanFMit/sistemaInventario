using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.VideoJuegos
{
    public partial class VideoJuegosBL
    {
        VideoJuegosDatabaseEntities _ef;

        public VideoJuegosBL()
        {
            _ef = new VideoJuegosDatabaseEntities();
        }

        public List<Producto> ObtenerProductos()
        {
            return _ef.Producto.ToList();
        }

        public List<Producto> ObtenerProductosFiltrados(string estado)
        {
            List<Producto> listaSinF = _ef.Producto.ToList();

            List<Producto> listaConF = new List<Producto>();
            if (estado != "Todos")
            {
                listaConF = (_ef.Producto.Where((x) => x.Estado == estado)).ToList();

                return listaConF;
            }
            else return listaSinF;
        }

        public void GuardarProductos(List<Producto> productos)
        {
            foreach (var producto in productos)
            {
                if (producto.Id == 0)
                {
                    var nuevoProducto = new Producto();
                    nuevoProducto.Descripcion = producto.Descripcion;
                    nuevoProducto.Estado = producto.Estado;
                    nuevoProducto.Existencia = producto.Existencia;
                    nuevoProducto.CodigoCategoria = producto.CodigoCategoria;
                    _ef.Producto.Add(nuevoProducto);
                }
                else
                {
                    var productoEnDB = _ef.Producto.FirstOrDefault((r) => r.Id == producto.Id);
                    if (productoEnDB != null)
                    {
                        productoEnDB.Descripcion = producto.Descripcion;
                        productoEnDB.Estado = producto.Estado;
                        productoEnDB.Existencia = producto.Existencia;
                        productoEnDB.CodigoCategoria = producto.CodigoCategoria;
                    }
                }
            }
            _ef.SaveChanges();
        }

        public List<Categoria> ObtenerCategorias()
        {
            return _ef.Categoria.ToList();
        }

        public void GuardarCategorias(List<Categoria> categorias)
        {
            foreach (var categoria in categorias)
            {
                if (categoria.Id == 0)
                {
                    var nuevaCategoria = new Categoria();
                    nuevaCategoria.Descripcion = categoria.Descripcion;
                    _ef.Categoria.Add(nuevaCategoria);
                }
                else
                {
                    var categoriaEnDB =_ef.Categoria.FirstOrDefault((r) => r.Id == categoria.Id);
                    if (categoriaEnDB != null)
                    {
                        categoriaEnDB.Descripcion = categoria.Descripcion;
                    }
                }
            }
            _ef.SaveChanges();
        }

        public List<Consola> ObtenerConsolas()
        {
            return _ef.Consola.ToList();
        }

        public void GuardarConsolas(List<Consola> consolas)
        {
            foreach (var consola in consolas)
            {
                if (consola.Id == 0)
                {
                    var nuevaConsola = new Consola();
                    nuevaConsola.Descripcion = consola.Descripcion;
                    _ef.Consola.Add(nuevaConsola);
                }
                else
                {
                    var consolaEnDB = _ef.Consola.FirstOrDefault((r) => r.Id == consola.Id);
                    if (consolaEnDB != null)
                    {
                        consolaEnDB.Descripcion = consola.Descripcion;
                    }
                }
            }
            _ef.SaveChanges();
        }

        public List<ProductoConsola> ObtenerProductosConsolas(string buscar, int consolaId)
        {
            if (consolaId == 0)
            {
                return _ef.ProductoConsola
                    .Where((r) => r.Producto.Descripcion.Contains(buscar) == true).ToList();
            }

            return _ef.ProductoConsola
                .Where((r) => r.Producto.Descripcion.Contains(buscar) == true
                    && r.CodigoConsola == consolaId).ToList();
        }
    }
}

using Ferreteria.BD;
using Ferreteria.Entidades;

namespace Ferreteria.Negocio
{
    public class ProductoNegocio
    {
        ListaProductos NegocioProd = new ListaProductos();

        public List<Producto> ObtenerProductos()
        {
            return NegocioProd.ObtenerProducto();
        }
    }
}

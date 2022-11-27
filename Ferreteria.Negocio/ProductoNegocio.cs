using Ferreteria.BD;
using Ferreteria.Entidades;
using System.Data;

namespace Ferreteria.Negocio
{
    public class ProductoNegocio
    {
        ListaProductos objDatosProducto = new ListaProductos();


        public int abmProducto(string accion, Producto objProducto)
        {
            return objDatosProducto.abmProducto(accion, objProducto);
        }
        public DataSet listadoProducto(string cual)
        {
            return objDatosProducto.listadoProducto(cual);
        }

        public List<Producto> ObtenerProducto()
        {
            return objDatosProducto.ObtenerProducto();
        }
    }
}

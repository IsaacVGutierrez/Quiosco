namespace Ferreteria.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string categoriaProducto;

        private string nombreProducto;

        private decimal precioProducto;

        protected int IdProducto { get => idProducto; set => idProducto = value; }
        protected string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        protected string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        protected decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }
    }
}
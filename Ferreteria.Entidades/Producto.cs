namespace Ferreteria.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string categoriaProducto;

        private string nombreProducto;

        private decimal precioProducto;

        private bool Existe_Producto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public bool ExisteProducto { get=>Existe_Producto; set=>Existe_Producto=value; }

        public Producto() { }

        public void ObtenerProductos() { }

    }
}
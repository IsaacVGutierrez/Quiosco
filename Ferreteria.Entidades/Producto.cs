namespace Ferreteria.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string categoriaProducto;

        private string nombreProducto;

        private decimal precioProducto;

        private bool ExisteProducto;

        public int IdProducto { get => idProducto; set => idProducto = value; }
        public string CategoriaProducto { get => categoriaProducto; set => categoriaProducto = value; }
        public string NombreProducto { get => nombreProducto; set => nombreProducto = value; }
        public decimal PrecioProducto { get => precioProducto; set => precioProducto = value; }
        public bool Existe_Prod { get=>ExisteProducto; set=>ExisteProducto=value; }
    }
}
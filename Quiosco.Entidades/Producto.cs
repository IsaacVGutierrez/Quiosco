namespace Quiosco.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string categoria;

        private string nombreProducto;

        private int precioProducto;

        public int Id
        {
            get { return idProducto; }
            set { idProducto = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; } 
        }

        public string NombreProducto
        {
            get { return nombreProducto;
        }
            set { nombreProducto = value; }
        
        
        }
        public decimal PrecioProducto 
        
        {
            get { return precioProducto;}
            set { precioProducto = (int)value; } 
        
        }


        public Producto() { }

        public Producto(string categProdu, string nombProdu, int precioProdu)
        {
            categoria = categProdu;      
            nombreProducto = nombProdu;
            precioProducto = precioProdu;
        }
    }
}
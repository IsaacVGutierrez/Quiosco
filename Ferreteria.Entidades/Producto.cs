namespace Ferreteria.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string categoria;

        private string nombreProducto;

        private decimal precioProducto;

        private bool Existe_Producto;




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
            set { precioProducto = value; } 
        
        }
        //public bool ExisteProducto 
        //{
        //    get { return Existe_Producto; }
        //    set { Existe_Producto = value; }
        //}


        public Producto() { }

        public Producto(string categProdu, string nombProdu, decimal precioProdu) //,bool existProdu)
        { 
          
            categoria =      categProdu;      
            nombreProducto =      nombProdu;
            precioProducto =      precioProdu;
            //Existe_Producto =       existProdu;
        }


        //public void ObtenerProductos() { }

    }
}
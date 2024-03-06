using System.Data.SqlTypes;

namespace Quiosco.Entidades
{
    public class Producto
    {

        private int idProducto;

        private string nombreProducto;

        private string marcaProducto;

        private decimal precioProducto;

        private int cantidadProducto;

        private SqlMoney precioCompra;

        private SqlMoney precioVenta;
               
        private int idCategoria;


        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }


        public string NombreProducto
        {
            get { return nombreProducto;
        }
            set { nombreProducto = value; }
        
        
        }


        public string MarcaProducto
        {
            get
            {
                return marcaProducto;
            }
            set { marcaProducto = value; }


        }
        public decimal PrecioProducto

        {
            get { return precioProducto; }
            set { precioProducto = (int)value; }

        }

        public int CantidadProducto
        {
            get { return cantidadProducto; }
            set { cantidadProducto = value; }
        }




        public SqlMoney PrecioCompra

        {
            get { return precioCompra; }
            set { precioCompra = (int)value; } 
        
        }

        public SqlMoney PrecioVenta
        {
            get { return precioVenta; }
            set { precioVenta = value; }
        }

        public int IdCategoria
        {
            get { return idCategoria; }
            set { idCategoria = value; }
        }



        public Producto() { }

        public Producto(string nombreProduct,  string marcaProduct, decimal precioProduct, int cantidadProduct, SqlMoney precioCompr, SqlMoney precioVent)
        {
            nombreProducto = nombreProduct;
            marcaProducto = marcaProduct;
            precioProducto = precioProduct;
            cantidadProducto = cantidadProduct;
            precioCompra = precioCompr;
            precioVenta = precioVent;
            
        }
    }
}
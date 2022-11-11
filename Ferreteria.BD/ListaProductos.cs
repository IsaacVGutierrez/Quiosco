


using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class ListaProductos:ConexionBD
    {



        public List<Producto> ObtenerProducto()
        {

            List<Producto> lista = new List<Producto>();

            string OrdenEjecucion = "Select IdProducto, CategoriaProducto , NombreProducto , PrecioProducto from Producto";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                AbrirConexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Producto producto = new Producto();

                    producto.IdProducto = dataReader.GetInt32(0);//instancia del objeto producto para obtener el campo id

                    producto.CategoriaProducto = dataReader.GetString(1);

                    producto.NombreProducto = dataReader.GetString(2);

                    producto.PrecioProducto = dataReader.GetInt32(3);

                    lista.Add(producto);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista de productos", e);
            }

            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return lista;
        }

    }
}

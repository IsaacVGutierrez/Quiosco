using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Ferreteria.BD
{
    public class ListaProductos : DatosConexionBD
    {

        public int abmProducto(string accion, Producto objProducto)
        {


            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")

                orden = $"insert into Producto values ('{objProducto.Categoria}','{objProducto.NombreProducto}','{objProducto.PrecioProducto}')";

            if (accion == "Modificar")
                orden = $"update Producto set Categoria = '{objProducto.Categoria}' where id = {objProducto.Id}; update Producto set NombreProducto = '{objProducto.NombreProducto}' where id = {objProducto.Id}; update Producto set PrecioProducto = '{objProducto.PrecioProducto}' where id = {objProducto.Id}; "; //;// update Producto set ExisteProducto = {objProducto.ExisteProducto} where id = {objProducto.IdProducto}; ";

            //if (accion == "Baja")

            //    orden = $"delete from Producto where Id = {objProducto.Id}";


            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error al tratar de guardar,borrar o modificar {objProducto} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoProducto(string id)
        {
            string orden = string.Empty;
            if (id != "Todos")
                orden = $"select * from Producto where id = {int.Parse(id)};";
            else
                orden = "select * from Producto;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);

                return ds;
            }
            catch (Exception e)
            {
                return ds = null;
                throw new Exception("Error al listar Producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            //return ds;
        }


        public List<Producto> ObtenerProducto()
        {

            List<Producto> lista = new List<Producto>();


            string OrdenEjecucion = "Select Id, Categoria , NombreProducto , PrecioProducto from Producto";

            


            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                Abrirconexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {


                    string productos = dataReader.GetString(2);
                    int precio = dataReader.GetInt32(3);
                    string productoprecio = $"{productos} , ${precio}";



                    Producto producto = new Producto();

                    producto.Id = dataReader.GetInt32(0);

                    //producto.Categoria = dataReader.GetString(1);

                    //producto.NombreProducto = dataReader.GetString(2);

                    //producto.PrecioProducto = dataReader.GetInt32(3);

                    producto.NombreProducto = productoprecio;

                    lista.Add(producto);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista de productos", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return lista;
        }

        public DataSet listarProductoBuscar(string cual)
        {
            string orden = $"select * from Producto where Id like '%{cual}%' or Categoria like '%{cual}%' or NombreProducto like '%{cual}%' or PrecioProducto like '%{cual}%';";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al buscar el producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet ListarProductoEliminar(string id)
        {
            string orden = $"delete from Producto where Id = {id};";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar el producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }



    }
}

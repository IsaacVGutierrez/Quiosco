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

            if (accion == "Baja")

                orden = $"delete from Producto where Id = {objProducto.Id}";

            if (accion == "Buscar")
                orden = $"select *from Producto where Id = {objProducto.Id}";

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
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Producto", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
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

                    producto.Id = dataReader.GetInt32(0);// obtener el campo id

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



        public List<Producto> SeleccionarProducto(Producto producto)
        {
           // Producto producto = new Producto();

            var lista = new List<Producto>();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = $"select Id, Categoria, NombreProducto, PrecioProducto from {producto} LIKE Categoria '%' {producto.Categoria} '%' ORDER BY NombreProducto {producto.NombreProducto}";

            try
            {

                Abrirconexion();

                cmd.Connection = conexion;

                var datareader = cmd.ExecuteReader();

                while (datareader != null && datareader.Read())
                {


                    var registro = new Producto();

                    registro.Id = (int)datareader["Id"];

                    registro.Categoria = (string)datareader["Categoria"];

                    registro.NombreProducto = (string)datareader["NombreProducto"];

                    registro.PrecioProducto = (int)datareader["PrecioProducto"];


                    lista.Add(registro);

                }


                //cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                //throw new Exception(e.Message);

                lista = null;

                throw new Exception(e.Message);
            }
            finally
            {
                conexion.Close();

                conexion.Dispose();
            }

            return lista;
        }

        
    }
}

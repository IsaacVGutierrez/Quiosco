

using System.Data;
using System.Data.OleDb;
using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class ListaProductos: DatosConexionBD
    {

        public int abmProducto(string accion, Producto objProducto)
        {

            int resultado = -1;
             string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Producto values ('{objProducto.Categoria}','{objProducto.NombreProducto}','{objProducto.PrecioProducto}')";//,{objProducto.ExisteProducto})";
            if (accion == "Modificar")
                orden = $"update Producto set Categoria = '{objProducto.Categoria}' where id = {objProducto.Id}; update Producto set NombreProducto = '{objProducto.NombreProducto}' where id = {objProducto.Id}; update Producto set PrecioProducto = '{objProducto.PrecioProducto}' where id = {objProducto.Id}; "; //;// update Producto set ExisteProducto = {objProducto.ExisteProducto} where id = {objProducto.IdProducto}; ";
            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
          resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar {objProducto} ", e);
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
                    Producto producto = new Producto();

                    producto.Id = dataReader.GetInt32(0);//instancia del objeto producto para obtener el campo id

                    producto.Categoria = dataReader.GetString(1);

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
                Cerrarconexion();
                cmd.Dispose();
            }

            return lista;
        }

    }
}

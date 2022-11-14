

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
                orden = $"insert into Producto values ({objProducto.CategoriaProducto}','{objProducto.NombreProducto},'{objProducto.PrecioProducto}',{objProducto.ExisteProducto})";
            if (accion == "Modificar")
                orden = $"update Producto set CategoriaProducto = {objProducto.CategoriaProducto} where id = {objProducto.IdProducto}; update Producto set NombreProducto = '{objProducto.NombreProducto}' where id = {objProducto.IdProducto}; update Producto set PrecioProducto = '{objProducto.PrecioProducto}' where id = {objProducto.IdProducto}; update Producto set ExisteProducto = {objProducto.ExisteProducto} where id = {objProducto.IdProducto}; ";
            
            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
          resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar ", e);
          }
             finally
          {
            Cerrarconexion();
          cmd.Dispose();
       }
        return resultado;
        }

          public DataSet listadoProducto(string cual)
      {
        string orden = string.Empty;
       if (cual != "Todos")
           orden = $"select * from Producto where id = {int.Parse(cual)};";
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

            string OrdenEjecucion = "Select IdProducto, CategoriaProducto , NombreProducto , PrecioProducto from Producto";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                Abrirconexion();

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
                Cerrarconexion();
                cmd.Dispose();
            }

            return lista;
        }

    }
}

using Quiosco.Entidades;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Quiosco.BD
{
    public class ListaMovimiento: DatosConexionBD
    {
        public int abmMovimiento(string accion, Movimiento objMovimiento)
        {

            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Movimiento values ('{objMovimiento.NombreCliente}','{objMovimiento.ApellidoCliente}' ,'{objMovimiento.DniCliente}' ,'{objMovimiento.MedioPago}')";

            if (accion == "Modificar")
                orden = $"update Movimiento set NombreCliente = '{objMovimiento.NombreCliente}' where id = {objMovimiento.Id}; update Movimiento set ApellidoCliente = '{objMovimiento.ApellidoCliente}' where id = {objMovimiento.Id}; update Movimiento set DniCliente = '{objMovimiento.DniCliente}' where id = {objMovimiento.Id};  update Movimiento set MedioPago = '{objMovimiento.MedioPago}' where id = {objMovimiento.Id} ";

            //if (accion == "Baja")
            //    orden = $"delete Movimiento where Id = {objMovimiento.Id}";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Error al tratar de guardar,borrar o modificar {objMovimiento} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoMovimiento(string id)
        {
            string orden = string.Empty;
            if (id != "Todos")
                orden = $"select * from Movimiento where id = {int.Parse(id)};";
            else
                orden = "select * from Movimiento;";
            SqlCommand cmd = new SqlCommand(orden, conexion);
            DataSet ds = new DataSet();//almacena datos de manera local en visual studio
            SqlDataAdapter da = new SqlDataAdapter();//lleva datos de un "almacen" del gestor de base de datos al dataset de visual studio
            try
            {
                Abrirconexion();
                cmd.ExecuteNonQuery();
                da.SelectCommand = cmd;
                da.Fill(ds);
            }
            catch (Exception e)
            {
                throw new Exception("Error al listar Movimiento", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }






        public List<Movimiento> ObtenerMovimiento()
        {
            List<Movimiento> lista = new List<Movimiento>();

            string OrdenEjecucion = "Select Id, NombreCliente , ApellidoCliente , DniCliente ,  MedioPago from Movimiento";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                Abrirconexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                    string nomcliente = dataReader.GetString(1);
                    string apellicliente = dataReader.GetString(2);
                    int  dnicliente = dataReader.GetInt32(3);
                    string pago = dataReader.GetString(4);
                    string comprobante = $"{nomcliente},{apellicliente},{dnicliente} ,{pago}";


                    Movimiento movimiento = new Movimiento();

                    movimiento.Id = dataReader.GetInt32(0);//instancia del objeto producto para obtener el campo id

                    movimiento.MedioPago = comprobante;         

                    lista.Add(movimiento);

                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista del movimiento productos que quiso adqurir el cliente", e);
            }

            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }

            return lista;
        }


        public DataSet listarMovimientoBuscar(string cual)
        {
            string orden = $"select * from Movimiento where Id like '%{cual}%' or NombreCliente like '%{cual}%' or ApellidoCliente like '%{cual}%'  or DniCliente like '%{cual}%' or MedioPago like '%{cual}%';";

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
                throw new Exception("Error al buscar los detalles del movimiento", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }

        public DataSet ListarMovimientoEliminar(string id)
        {
            string orden = $"delete Movimiento where Id = {id};";

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
                throw new Exception("Error al eliminar los detalles del movimiento", e);
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

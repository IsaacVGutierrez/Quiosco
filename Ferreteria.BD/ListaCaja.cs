using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.BD
{
    public class ListaCaja : DatosConexionBD
    {

       public int abmCaja(string accion, Caja objCaja)
        {

            int resultado = -1;
            string orden = string.Empty;
            if (accion == "Alta")
                orden = $"insert into Caja values ('{objCaja.TipoComprobante}')";//,'{objCaja.EntregaComprobante}')";
            if (accion == "Modificar")
                orden = $"update Caja set TipoComprobante = '{objCaja.TipoComprobante}' where id = {objCaja.Id}); ";//; update Caja set EntregaComprobante = '{objCaja.EntregaComprobante}' where id = {objCaja.IdCaja}; ";

            SqlCommand cmd = new SqlCommand(orden, conexion);
            try
            {
                Abrirconexion();
                resultado = cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception($"Errror al tratar de guardar,borrar o modificar {objCaja} ", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return resultado;
        }

        public DataSet listadoCaja(string id)
        {
            string orden = string.Empty;
            if (id != "Todos")
                orden = $"select * from Caja where id = {int.Parse(id)};";
            else
                orden = "select * from Caja;";
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
                throw new Exception("Error al listar Caja", e);
            }
            finally
            {
                Cerrarconexion();
                cmd.Dispose();
            }
            return ds;
        }



        public List<Caja> ObtenerCaja()
        {
            List<Caja> lista = new List<Caja>();

            string OrdenEjecucion = "Select IdCaja, TipoComprobante from Caja";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                Abrirconexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Caja caja = new Caja();

                    caja.Id = dataReader.GetInt32(0);
                    caja.TipoComprobante = dataReader.GetString(1);

                    //caja.EntregaComprobante = dataReader.GetBoolean(1);

                    lista.Add(caja);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista de valores de la caja", e);
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

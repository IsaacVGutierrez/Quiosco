using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.BD
{
    public class ListaCaja : ConexionBD
    {


        public List<Caja> ObtenerCaja()
        {
            List<Caja> lista = new List<Caja>();

            string OrdenEjecucion = "Select IdCaja, EntregaComprobante from Caja";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                AbrirConexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Caja caja = new Caja();

                    caja.IdCaja = dataReader.GetInt32(0);

                    caja.EntregaComprobante = dataReader.GetBoolean(1);

                    lista.Add(caja);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista de valores de la caja", e);
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

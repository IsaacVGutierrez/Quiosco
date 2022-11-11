using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ferreteria.BD
{
    public class ListaMovimiento:ConexionBD
    {




        public List<Movimiento> ObtenerMovimiento()
        {
            List<Movimiento> lista = new List<Movimiento>();

            string OrdenEjecucion = "Select IdMovimiento, NombreCliente , ApellidoCliente , MedioPago from Producto";

            SqlCommand cmd = new SqlCommand(OrdenEjecucion, conexion);

            SqlDataReader dataReader;

            try
            {
                AbrirConexion();

                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {
                    Movimiento movimiento = new Movimiento();

                    movimiento.IdMovimiento = dataReader.GetInt32(0);//instancia del objeto producto para obtener el campo id

                    movimiento.NombreCliente = dataReader.GetString(1);

                    movimiento.ApellidoCliente = dataReader.GetString(2);

                    movimiento.MedioPago = dataReader.GetString(3);

                    lista.Add(movimiento);
                }
            }
            catch (Exception e)
            {

                throw new Exception("Error al obtener la lista del movimiento productos que quiso adqurir el cliente", e);
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

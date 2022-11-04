using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Ferreteria.BD
{
    public class AdministracionConexion:ConexionBD
    {

        private ConexionBD Conexion = new ConexionBD();

        private SqlCommand comando = new SqlCommand();

        private SqlDataReader LeerFilasTablas;

        public DataTable ListarCaja()
        {
            DataTable Tablas = new DataTable();

            comando.Connection = Conexion.AbrirConexion();

            comando.CommandText = "ListaCaja";//hecho con procedimiento almacenado en sql server

            comando.CommandType = CommandType.StoredProcedure;

            LeerFilasTablas = comando.ExecuteReader();

            Tablas.Load(LeerFilasTablas);

            LeerFilasTablas.Close();

            Conexion.CerrarConexion();

            return Tablas;

        }


        public DataTable ListarMovimiento()
        {
            DataTable Tablas = new DataTable();

            comando.Connection = Conexion.AbrirConexion();

            comando.CommandText = "ListaMovimiento";//hecho con procedimiento almacenado en sql server

            comando.CommandType = CommandType.StoredProcedure;

            LeerFilasTablas = comando.ExecuteReader();

            Tablas.Load(LeerFilasTablas);

            LeerFilasTablas.Close();

            Conexion.CerrarConexion();

            return Tablas;

        }

        public DataTable ListarProducto()
        {
            DataTable Tablas = new DataTable();

            comando.Connection = Conexion.AbrirConexion();

            comando.CommandText = "ListaProducto";//hecho con procedimiento almacenado en sql server

            comando.CommandType = CommandType.StoredProcedure;

            LeerFilasTablas = comando.ExecuteReader();

            Tablas.Load(LeerFilasTablas);

            LeerFilasTablas.Close();

            Conexion.CerrarConexion();

            return Tablas;

        }

    }
}

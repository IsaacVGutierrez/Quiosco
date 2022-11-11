using System.Data;
using System.Xml;
using Ferreteria.Entidades;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class ConexionBD
    {
        public static string CadenaConexion = "Server=DESKTOP-7USE28D\\SQLEXPRESS;Database=Ferreteria;Integrated Security=true";

        private  SqlConnection Conexion = new SqlConnection(CadenaConexion);


        public SqlConnection conexion { get=>Conexion; set=>Conexion=value; }


        public SqlConnection AbrirConexion()
        {
            if (Conexion.State.Equals(ConnectionState.Closed)) { }
            
                Conexion.Open();
                
            return Conexion;
            
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State.Equals(ConnectionState.Open))
                Conexion.Close();
            return Conexion;
        }     
    }

}

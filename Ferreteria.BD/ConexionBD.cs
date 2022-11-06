using System.Data;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class ConexionBD
    {
        static private readonly string CadenaConexion = "Server=DESKTOP-7USE28D\\SQLEXPRESS;Database=Ferreteria;Integrated Security=true";

        private readonly SqlConnection Conexion = new SqlConnection(CadenaConexion);

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

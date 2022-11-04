using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class ConexionBD
    {
        static private string CadenaConexion = "Server=DESKTOP-7USE28D\\SQLEXPRESS;databse=Ferreteria;Integrated Security=true";

        private SqlConnection conexion =new SqlConnection(CadenaConexion);

        public SqlConnection AbrirConexion()
        {
            if (conexion.State.Equals(ConnectionState.Closed)) { }
            
                conexion.Open();
                
            return conexion;
            
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State.Equals(ConnectionState.Open))
                conexion.Close();
            return conexion;
        }

    }
}

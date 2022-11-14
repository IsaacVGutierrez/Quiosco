using System.Data;
using System.Xml;


using Ferreteria.Entidades;
using System.Data.OleDb;
using Microsoft.Data.SqlClient;

namespace Ferreteria.BD
{
    public class DatosConexionBD
    {
        protected SqlConnection conexion;
        protected string cadenaConexion = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Usuario\Ferreteria.mdf;Integrated Security=True;Connect Timeout=30";
      
        public DatosConexionBD()
        {
            conexion = new SqlConnection(cadenaConexion);
        }
        public void Abrirconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Broken || conexion.State ==
               ConnectionState.Closed)
                    conexion.Open();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de abrir la conexión", e);
            }
        }

       
        public void Cerrarconexion()
        {
            try
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al tratar de cerrar la conexión", e);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.BD;
using Ferreteria.Entidades;

namespace Ferreteria
{
    public partial class Ferreteria : Form
    {
        public Ferreteria()
        {
            InitializeComponent();

            
        }

        private void Ferreteria_Load(object sender, EventArgs e)
        {
            ListaProducto();
            ListaCaja();
        }


        private void ListaProducto()
        {
            AdministracionConexion objetoConexion = new AdministracionConexion();

            cmbCategoria.DataSource = objetoConexion.ListarProducto();

            cmbCategoria.DataSource = Enum.GetValues(typeof(Categoria_Producto));


        }

        private void ListaCaja()
        {
            AdministracionConexion conexion = new AdministracionConexion();

            cmbComprobante.DataSource = Enum.GetValues(typeof(TipoComprobante));

            cmbMedioPago.DataSource = Enum.GetValues(typeof(TipoPago));
        }

        private void lblMediospago_Click(object sender, EventArgs e)
        {

        }
    }
}

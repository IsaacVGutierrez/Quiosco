using Ferreteria.BD;
using Ferreteria.Entidades;
using Ferreteria.Negocio;
using System.Data;

namespace Ferreteria
{
    public partial class Ferreteria : Form
    {

        //Trabajo con un objeto de la capa Ferreteria.Entidades

        Producto objProdEnt = new Producto();

        Movimiento objMovEnt = new Movimiento();

        Caja objCajEnt = new Caja();

        //Trabajo con un objeto de la capa Ferreteroa.Negocios

        ProductoNegocio objNegProd = new ProductoNegocio();

        MovimientoNegocio objNegMov = new MovimientoNegocio();

        CajaNegocio objNegCaj = new CajaNegocio();

        public Ferreteria()
        {
            InitializeComponent();


            dgCajaValoresRelacionados.ColumnCount = 7;

            dgCajaValoresRelacionados.Columns[0].HeaderText = "Precio";

            dgCajaValoresRelacionados.Columns[1].HeaderText = "Nombre cliente";

            dgCajaValoresRelacionados.Columns[2].HeaderText = "Apellido cliente";

            dgCajaValoresRelacionados.Columns[3].HeaderText = "Nombre producto";

            dgCajaValoresRelacionados.Columns[4].HeaderText = "Categoria";

            dgCajaValoresRelacionados.Columns[5].HeaderText = "Comprobante";

            dgCajaValoresRelacionados.Columns[6].HeaderText = "Medio de pago";

            LlenarDg();
        }

        private void Ferreteria_Load(object sender, EventArgs e)
        {
            LlenarCombo();

            LlenarDg();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            Text_Box();
        }

        private void LlenarCombo()
        {
            var pro = new ListaProductos();

            cmbProductoCategoria.DataSource = pro.ObtenerProducto();

            cmbProductoCategoria.DisplayMember = "CategoriaProducto";
        }

        private void LlenarDg()
        {
            /*
             * Llenar el datagridview en base a lo especificado en el apunte a continuacion:
             * 
             * PrgII_2022_ApuntePasoAPasoCapas.pdf-->Este apunte
             * 
             * En el diseño del formulario estan especificado los campos que se deben ingresar y mostrar
             * 
             * mediante los textbox asignados

             */


            dgCajaValoresRelacionados.Rows.Clear();

            var data = new DataSet();




        }

        private void Text_Box()
        {
            objProdEnt.PrecioProducto = decimal.Parse(txtprecio.Text);

            objMovEnt.NombreCliente = txtNombreCliente.Text;

            objMovEnt.ApellidoCliente = txtApellidoCliente.Text;

            objProdEnt.NombreProducto = txtNombProd.Text;

            objProdEnt.CategoriaProducto = cmbProductoCategoria.Text;

            objCajEnt.TipoComprobante = cmbComprobante.Text;

            objMovEnt.MedioPago = cmbMedioPago.Text;

        }

        private void dgCajaValoresRelacionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}

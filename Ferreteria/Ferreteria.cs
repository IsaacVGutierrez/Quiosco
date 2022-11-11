using Ferreteria.BD;
using Ferreteria.Entidades;
using Ferreteria.Negocio;

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
        }

        private void Ferreteria_Load(object sender, EventArgs e)
        {
            LlenarCombo();

            LlenarDg();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

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
        }

    }
}

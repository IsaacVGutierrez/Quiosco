using System;
using Ferreteria;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ferreteria.Entidades;
using Ferreteria.Negocio;

namespace Ferreteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dgvProducto.ColumnCount = 4;
            dgvProducto.Columns[0].HeaderText = "Id";
            dgvProducto.Columns[1].HeaderText = "Categoria";
            dgvProducto.Columns[2].HeaderText = "NombreProducto";
            dgvProducto.Columns[3].HeaderText = "PrecioProducto";
            

            dgvMovimiento.ColumnCount = 4;
            dgvMovimiento.Columns[0].HeaderText = "Id";
            dgvMovimiento.Columns[1].HeaderText = "NombreCliente";
            dgvMovimiento.Columns[2].HeaderText = "ApellidoCliente";
            dgvMovimiento.Columns[3].HeaderText = "MedioPago";


             dgvCaja.ColumnCount = 4;
             dgvCaja.Columns[0].HeaderText = "Id";
             dgvCaja.Columns[1].HeaderText = "TipoComprobante";
            dgvCaja.Columns[2].HeaderText = "ProductoId ";
            dgvCaja.Columns[3].HeaderText = "MovimientoId ";



            LlenarDGVProducto();
            LlenarDGVMovimiento();
            LlenarDGVCaja();
            LlenarCombos();
            LlenarCombos2();


        }
        #region LlenadoDGVs
        private void LlenarDGVProducto()
        {
            dgvProducto.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProducto.listadoProducto("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvProducto.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3].ToString());
                }
            }
        }
        private void LlenarDGVMovimiento()
        {
            dgvMovimiento.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegMovimiento.listadoMovimiento("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvMovimiento.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3].ToString());
                }
            }
        }


       
            
          private void LlenarDGVCaja()
        {
            dgvCaja.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegCaja.listadoCaja("Todos");
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCaja.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3].ToString());
                }
            }
        } 
        


         


        #endregion

        #region DeclaracionVariables
        public Producto objEntProducto = new Producto();
        public Movimiento objEntMovimiento = new Movimiento();
        public Caja objEntCaja = new Caja();


        public ProductoNegocio objNegProducto = new ProductoNegocio();
        public MovimientoNegocio objNegMovimiento = new MovimientoNegocio();
        public CajaNegocio objNegCaja = new CajaNegocio();


        #endregion





         
        #region MetodoLlenadoCombo
        private void LlenarCombos()
        {
            cbCajaProducto.DataSource = objNegProducto.ObtenerProducto();
            cbCajaProducto.DisplayMember = "NombreProducto";                    
            cbCajaProducto.ValueMember = "Id";
        }

        private void LlenarCombos2()
        {
            cbCajaMovimiento.DataSource = objNegMovimiento.ObtenerMovimiento();
            cbCajaMovimiento.DisplayMember = "MedioPago";
            cbCajaMovimiento.ValueMember = "Id";
        }


        #endregion




        #region MetodosTxtAObj
        private void TxtBox_a_ObjProducto()
        {
            objEntProducto.Categoria = txtCategoriaProducto.Text;
            objEntProducto.NombreProducto = txtNombreProducto.Text;
            objEntProducto.PrecioProducto = int.Parse(txtPrecioProducto.Text);
          

        }
        private void TxtBox_a_ObjMovimiento()
        {
            objEntMovimiento.NombreCliente = txtNombreMovimiento.Text;
            objEntMovimiento.ApellidoCliente = txtApellidoCliente.Text;
            objEntMovimiento.MedioPago = txtMedioPago.Text;
         
        }




  
         
             private void TxtBox_a_ObjCaja()
        {
            objEntCaja.TipoComprobante = txtTipoCaja.Text;
            objEntCaja.productoId = int.Parse(cbCajaProducto.SelectedValue.ToString());
            objEntCaja.movimientoId = int.Parse(cbCajaMovimiento.SelectedValue.ToString());

        }



        #endregion

        #region MetodosValidacion
        public bool ValidacionCamposProducto()
        {

            //Categoria
            if (txtCategoriaProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una Categoria Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtCategoriaProducto.Text.Length > 50 || txtCategoriaProducto.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten categoria de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }



            //Nombre Producto
            if (txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Nombre Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreProducto.Text.Length > 50 || txtNombreProducto.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //Precio
            if (txtPrecioProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un Precio Producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPrecioProducto.Text.Length > 50 || txtPrecioProducto.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten precio entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtPrecioProducto.Text.Length > 200)
            {
                MessageBox.Show("La observación no puede superar los 200 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;


        }

        public bool ValidacionCamposMovimiento()

        {
            // Nombre Cliente

            if (txtNombreMovimiento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un NombreCliente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreMovimiento.Text.Length > 40 || txtNombreMovimiento.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 40 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //Apellido Cliente
            if (txtApellidoCliente.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un ApellidoCliente ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtApellidoCliente.Text.Length > 40 || txtApellidoCliente.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 40 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }


            //Medio Pago
            if (txtMedioPago.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un MedioPago ", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtMedioPago.Text.Length > 40 || txtMedioPago.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 40 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtMedioPago.Text.Length > 200)
            {
                MessageBox.Show("La observación no puede superar los 200 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;

        }

         
         
          public bool ValidacionCamposCaja()
        {
            if (txtTipoCaja.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un tipo de comprobante", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTipoCaja.Text.Length > 30 || txtTipoCaja.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 30 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTipoCaja.Text.Length > 200)
            {
                MessageBox.Show("La observación no puede superar los 200 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }




        #endregion

        #region MetodosCargar
        private void btnCargaProducto_Click(object sender, EventArgs e)
        {
             bool validar = ValidacionCamposProducto();
            int nGrabados = -1;
            if(validar == true)
            {
                TxtBox_a_ObjProducto();
                nGrabados = objNegProducto.abmProducto("Alta", objEntProducto); 
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar el Producto al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar al Producto con éxito");
                    LlenarDGVProducto();
                    LimpiarProducto();
                    LlenarCombos();
                    tabControl1.SelectTab(tabProducto);
                }
            }

        }
        private void btnCargaMovimiento_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposMovimiento();
            int nGrabados = -1;
            if (validar == true)
            {
                TxtBox_a_ObjMovimiento();
                nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar Movimiento al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar  Movimiento con éxito");
                    LlenarDGVMovimiento();
                    LimpiarMovimiento();
                    LlenarCombos2();
                    tabControl1.SelectTab(tabMovimiento);
                }
            }

        }

  
         
          private void btnCargaCaja_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposCaja();
            int nGrabados = -1;
            if (validar == true)
            {
                TxtBox_a_ObjCaja();
                nGrabados = objNegCaja.abmCaja("Alta", objEntCaja);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar  la caja al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar  la caja con éxito");
                    LlenarDGVCaja();
                    LimpiarCaja();
                    tabControl1.SelectTab(tabCaja);

                }
            }

        }

         
        


        #endregion

        #region MetodosLimpiar
        private void LimpiarProducto()
        {
            txtCategoriaProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
           
            
        }
        private void LimpiarMovimiento()
        {
            txtNombreMovimiento.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;           
            txtMedioPago.Text = string.Empty;
        }


       
           private void LimpiarCaja()
        {
            txtNombreMovimiento.Text = string.Empty;
            cbCajaProducto.SelectedIndex = 0;
            cbCajaMovimiento.SelectedIndex = 0;

        }


        #endregion

        #region MetodosDsATxt
        private void Ds_a_TxtBoxMovimiento(DataSet ds)
        {
            txtNombreMovimiento.Text = ds.Tables[0].Rows[0]["NombreCliente"].ToString();
            txtApellidoCliente.Text = ds.Tables[0].Rows[0]["ApellidoCliente"].ToString();
            txtMedioPago.Text = ds.Tables[0].Rows[0]["MedioPago"].ToString();
        }
        private void Ds_a_TxtBoxProducto(DataSet ds)
        {
                       
            txtCategoriaProducto.Text = ds.Tables[0].Rows[0]["Categoria"].ToString();
           txtNombreProducto.Text = ds.Tables[0].Rows[0]["NombreProducto"].ToString();
            txtPrecioProducto.Text = ds.Tables[0].Rows[0]["PrecioProducto"].ToString();
        }


       
         
         
          private void Ds_a_TxtBoxCaja(DataSet ds)
        {
           
            txtTipoCaja.Text = ds.Tables[0].Rows[0]["TipoComprobante"].ToString();
            cbCajaProducto.SelectedValue = System.Convert.ToInt32(ds.Tables[0].Rows[0]["ProductoId"].ToString());
            cbCajaMovimiento.SelectedValue = System.Convert.ToInt32(ds.Tables[0].Rows[0]["MovimientoId"].ToString());
        }

        


        #endregion

        #region MetodosModificar
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposProducto();
            int nResultado = -1;
            if (validar == true)
            {
                TxtBox_a_ObjProducto();
                nResultado = objNegProducto.abmProducto("Modificar", objEntProducto); 
                if (nResultado != -1)
                {
                    MessageBox.Show("El producto fue modificado con éxito");
                    LimpiarProducto();
                    LlenarDGVProducto();
                    btnModificarProducto.Visible = false;
                    btnCargarProducto.Visible = true;
                    btnCancelarProducto.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el Producto");
                }
            }
        }

        private void btnModificarMovimiento_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposMovimiento();
            int nResultado = -1;
            if (validar == true)
            {
                TxtBox_a_ObjMovimiento();
                nResultado = objNegMovimiento.abmMovimiento("Modificar", objEntMovimiento);
                if (nResultado != -1)
                {
                    MessageBox.Show("el Movimiento fue modificada con éxito");
                    LimpiarMovimiento();
                    LlenarDGVMovimiento();
                    btnModificarMovimiento.Visible = false;
                    btnCargaMovimiento.Visible = true;
                    btnCancelarMovimiento.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar el Movimiento");
                }
            }

        }


         
         private void btnModificarCaja_Click(object sender, EventArgs e)
        {
            bool validar = ValidacionCamposCaja();
            int nResultado = -1;
            if (validar == true)
            {
                TxtBox_a_ObjCaja();
                nResultado = objNegCaja.abmCaja("Modificar", objEntCaja);
                if (nResultado != -1)
                {
                    MessageBox.Show("el Caja fue modificada con éxito");
                    LimpiarCaja();
                    LlenarDGVCaja();
                    btnModificarCaja.Visible = false;
                    btnCargaCaja.Visible = true;
                    btnCancelarCaja.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar la Caja");
                }
            }

        }
         
         
         
       

        #endregion

        #region MetodosDgvClick
        private void dgvProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabProducto);
            DataSet ds = new DataSet();
            objEntProducto.Id = Convert.ToInt32(dgvProducto.CurrentRow.Cells[0].Value);
            ds = objNegProducto.listadoProducto(objEntProducto.Id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxProducto(ds);
                btnCargarProducto.Visible = false;
                btnModificarProducto.Visible = true;
                btnCancelarProducto.Visible = true;
            }
        }

        private void dgvMovimiento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabMovimiento);
            DataSet ds = new DataSet();
            objEntMovimiento.Id = Convert.ToInt32(dgvMovimiento.CurrentRow.Cells[0].Value);
            ds = objNegMovimiento.listadoMovimiento(objEntMovimiento.Id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxMovimiento(ds);
                btnCargaMovimiento.Visible = false;
                btnModificarMovimiento.Visible = true;
                btnCancelarMovimiento.Visible = true;
            }
        }



        
         
         
            private void dgvCaja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tabControl1.SelectTab(tabCaja);
            DataSet ds = new DataSet();
            objEntCaja.Id = Convert.ToInt32(dgvCaja.CurrentRow.Cells[0].Value);
            ds = objNegCaja.listadoCaja(objEntCaja.Id.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                Ds_a_TxtBoxCaja(ds);
                btnCargaCaja.Visible = false;
                btnModificarCaja.Visible = true;
                btnCancelarCaja.Visible = true;
            }
        }





        #endregion

        #region Validaciones




        private void txtCategoriaProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

         private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtPrecioProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

     

        private void txtNombreMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtMedioPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtNombreCaja_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

         
         
         
       


        #endregion

        #region MetodosBtnCancelar
        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            LimpiarProducto();
            btnCargarProducto.Visible = true;
            btnModificarProducto.Visible = true;
            btnCancelarProducto.Visible = true;
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            LimpiarMovimiento();
            btnCargaMovimiento.Visible = true;
            btnModificarMovimiento.Visible = true;
            btnCancelarMovimiento.Visible = true;
        }




       

        private void btnCancelarCaja_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            btnCargaCaja.Visible = true;
            btnModificarCaja.Visible = true;
            btnCancelarCaja.Visible = true;
        }

       
        #endregion

        private void dgvProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void lblNombreProducto_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblTelCaja_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnCargaCaja_Click_1(object sender, EventArgs e)
        {

        }

       
        private void txtMovimientoId_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabProducto_Click(object sender, EventArgs e)
        {

        }

        private void tabCaja_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreMovimiento_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCajaProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblProductoId_Click(object sender, EventArgs e)
        {

        }

        private void lblMovimientoId_Click(object sender, EventArgs e)
        {

        }

        private void cbCajaMovimiento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtApellidoCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategoriaProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvCaja_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvMovimiento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabMovimiento_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

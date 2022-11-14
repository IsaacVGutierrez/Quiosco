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

namespace GuarderiaMascotas
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


             dgvCaja.ColumnCount = 2;
             dgvCaja.Columns[0].HeaderText = "Id";
             dgvCaja.Columns[1].HeaderText = "TipoComprobante";
         
            cmbTipo.SelectedIndex = 1;
            LlenarDGVProducto();
            LlenarDGVMovimiento();
            LlenarDGVCaja();
            LlenarCombos();
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
                    dgvProducto.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3],dr[4].ToString());
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
                    dgvMovimiento.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4].ToString());
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
                    dgvCaja.Rows.Add(dr[0].ToString(), dr[1], dr[2].ToString());
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
            cbMovimiento.DataSource = objNegProducto.ObtenerProductos();
            cbMovimiento.DisplayMember = "nombreProducto";
            cbMovimiento.ValueMember = "idProducto";
        }
        #endregion

        #region MetodosTxtAObj
        private void TxtBox_a_ObjProducto()
        {
            objEntProducto.Categoria = txtDniProducto.Text;
            objEntProducto.NombreProducto = txtNombreProducto.Text;
            objEntProducto.PrecioProducto = decimal.Parse(txtApellidoProducto.Text);
          

        }
        private void TxtBox_a_ObjMovimiento()
        {
            objEntMovimiento.NombreCliente = txtNombreMovimiento.Text;
            objEntMovimiento.ApellidoCliente = cmbTipo.SelectedItem.ToString();
            objEntMovimiento.MedioPago = txtObsMovimiento.Text;
           /* objEntMovimiento.fechaNacimientoProp = dtpFechaNac.Value;
            objEntMovimiento.duenioIdProp = int.Parse(cbDueniosMascota.SelectedValue.ToString());
            bool retiradoABD = cbRetirado.Checked;
            objEntMovimiento.RetiradoM(retiradoABD);*/
        }




  
         
             private void TxtBox_a_ObjCaja()
        {
            objEntCaja.TipoComprobante = txtTipoCaja.Text;

          

        }
         
         
         
        #endregion

        #region MetodosValidacionesCampos
        public bool ValidacionCamposProducto()
        {
            if(txtNombreProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreProducto.Text.Length > 50 || txtNombreProducto.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Apellido
            if (txtApellidoProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un apellido", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtApellidoProducto.Text.Length > 50 || txtApellidoProducto.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten apellidos entre 2 y 50 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //Telefono
            if (txtTelProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un numero de telefono", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtTelProducto.Text.Length > 7 || txtTelProducto.Text.Length < 7)
            {
                MessageBox.Show("Solo se permiten numeros de 7 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            //DNI
            if (txtDniProducto.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un DNI", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtDniProducto.Text.Length > 8 || txtDniProducto.Text.Length <= 7)
            {
                MessageBox.Show("Solo se permiten DNI entre 7 y 8 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            return true;
        }
        public bool ValidacionCamposMovimiento()
        {
            if (txtNombreMovimiento.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un nombre de Movimiento", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtNombreMovimiento.Text.Length > 30 || txtNombreMovimiento.Text.Length < 2)
            {
                MessageBox.Show("Solo se permiten nombres menores a 30 caracteres y mayores a 2", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (txtObsMovimiento.Text.Length > 200)
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
        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposProducto();
            int nGrabados = -1;
            if(validado == true)
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
                    tabControl1.SelectTab(tabMovimiento);
                }
            }

        }
        private void btnCargaMovimiento_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposMovimiento();
            int nGrabados = -1;
            if (validado == true)
            {
                TxtBox_a_ObjMovimiento();
                nGrabados = objNegMovimiento.abmMovimiento("Alta", objEntMovimiento);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar a la Movimiento al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar a la Movimiento con éxito");
                    LlenarDGVMovimiento();
                    LimpiarMovimiento();
                }
            }

        }

  
         
          private void btnCargaCaja_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposCaja();
            int nGrabados = -1;
            if (validado == true)
            {
                TxtBox_a_ObjCaja();
                nGrabados = objNegCaja.abmCaja("Alta", objEntCaja);
                if (nGrabados == -1)
                {
                    MessageBox.Show("No se logró agregar a la caja al sistema");
                }
                else
                {
                    MessageBox.Show("Se logró agregar a la caja con éxito");
                    LlenarDGVCaja();
                    LimpiarCaja();
                }
            }

        }

         
        


        #endregion

        #region MetodosLimpiar
        private void LimpiarProducto()
        {
            txtDniProducto.Text = string.Empty;
            txtApellidoProducto.Text = string.Empty;
            txtNombreProducto.Text = string.Empty;
            txtTelProducto.Text = string.Empty;
        }
        private void LimpiarMovimiento()
        {
            txtNombreMovimiento.Text = string.Empty;
            txtObsMovimiento.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Today;
            cbRetirado.Checked = false;
            cmbTipo.SelectedIndex = 1;
            cbMovimiento.SelectedIndex = 0;
        }


       
           private void LimpiarCaja()
        {
            txtNombreMovimiento.Text = string.Empty;
            txtObsMovimiento.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Today;
            cbRetirado.Checked = false;
            cmbTipo.SelectedIndex = 1;
            cbMovimiento.SelectedIndex = 0;
        }
         
         
        #endregion

        #region MetodosDsATxt
        private void Ds_a_TxtBoxMovimiento(DataSet ds)
        {
            bool retirado;
            if (ds.Tables[0].Rows[0]["retirado"].ToString() == "si")
            {
                retirado = true;
            }
            else
            {
                retirado = false;
            }

            txtNombreMovimiento.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            cmbTipo.SelectedItem = ds.Tables[0].Rows[0]["tipo"].ToString();
            txtObsMovimiento.Text = ds.Tables[0].Rows[0]["observacion"].ToString();
            dtpFechaNac.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["fechaNacimiento"]);
            cbRetirado.Checked = retirado;
            cbMovimiento.SelectedValue = System.Convert.ToInt32(ds.Tables[0].Rows[0]["Id"].ToString());
        }
        private void Ds_a_TxtBoxProducto(DataSet ds)
        {
            txtDniProducto.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombreProducto.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellidoProducto.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelProducto.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
        }


       
         
         
          private void Ds_a_TxtBoxCaja(DataSet ds)
        {
            txtDniProducto.Text = ds.Tables[0].Rows[0]["DNI"].ToString();
            txtNombreProducto.Text = ds.Tables[0].Rows[0]["Nombre"].ToString();
            txtApellidoProducto.Text = ds.Tables[0].Rows[0]["Apellido"].ToString();
            txtTelProducto.Text = ds.Tables[0].Rows[0]["Telefono"].ToString();
        }

        


        #endregion

        #region MetodosModificar
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposProducto();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjProducto();
                nResultado = objNegProducto.abmProducto("Modificar", objEntProducto); 
                if (nResultado != -1)
                {
                    MessageBox.Show("El dueño fue modificado con éxito");
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
            bool validado = ValidacionCamposMovimiento();
            int nResultado = -1;
            if (validado == true)
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
                    MessageBox.Show("Se produjo un error al intentar modificar la Movimiento");
                }
            }

        }


         
         private void btnModificarCaja_Click(object sender, EventArgs e)
        {
            bool validado = ValidacionCamposCaja();
            int nResultado = -1;
            if (validado == true)
            {
                TxtBox_a_ObjCaja();
                nResultado = objNegCaja.abmCaja("Modificar", objEntCaja);
                if (nResultado != -1)
                {
                    MessageBox.Show("el Movimiento fue modificada con éxito");
                    LimpiarCaja();
                    LlenarDGVCaja();
                    btnModificarCaja.Visible = false;
                    btnCargaCaja.Visible = true;
                    tabControl1.Visible = false;
                }
                else
                {
                    MessageBox.Show("Se produjo un error al intentar modificar la Caja");
                }
            }

        }
         
         
         
       

        #endregion

        #region MetodosCellClick
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
                tabControl1.Visible = true;
            }
        }
         
        



        #endregion

        #region Validaciones
        private void txtNombreProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }


        private void txtApellidoProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permite letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtTelProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtDniProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txtObsMovimiento_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtObsCaja_KeyPress(object sender, KeyPressEventArgs e)
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
            btnModificarProducto.Visible = false;
            btnCancelarProducto.Visible = false;
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            LimpiarMovimiento();
            btnCargaMovimiento.Visible = true;
            btnModificarMovimiento.Visible = false;
            btnCancelarMovimiento.Visible = false;
        }




       

        private void btnCancelarCaja_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            btnCargaCaja.Visible = true;
            btnModificarCaja.Visible = false;
            tabControl1.Visible = false;
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
    }
}

using Ferreteria.BD;
using Ferreteria.Entidades;
using Ferreteria.Negocio;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

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
             
            dgvCaja.ColumnCount = 9;      
            dgvCaja.Columns[0].HeaderText = "Id";
            dgvCaja.Columns[1].HeaderText = "TipoComprobante";
            dgvCaja.Columns[2].HeaderText = "FechaCaja";
           dgvCaja.Columns[3].HeaderText = "Categoria ";
            dgvCaja.Columns[4].HeaderText = "NombreProducto ";
            dgvCaja.Columns[5].HeaderText = "PrecioProducto ";
            dgvCaja.Columns[6].HeaderText = "NombreCliente ";
            dgvCaja.Columns[7].HeaderText = "ApellidoCliente";
            dgvCaja.Columns[8].HeaderText = "MedioPago";
            




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
            ds = objNegCaja.Union();
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCaja.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4], dr[5], dr[6], dr[7], dr[8].ToString());
                }
            }
        }






        #endregion

        #region LlenarDgBusqueda

        private void LlenarDgProductoBuscar()
        {
            string cual = txtBuscarProducto.Text;
            dgvProducto.Rows.Clear();
            DataSet ds = new DataSet();
            ds = objNegProducto.listarProductoBuscar(cual);

            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvProducto.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2], dr[3]);  
                }
            }
        }

        private void LlenarDgMovimientoBuscar()
        {
            string cual = txtBuscarMovimiento.Text;
            dgvMovimiento.Rows.Clear();
            DataSet ds = new DataSet();

            ds = objNegMovimiento.listarMovimientoBuscar(cual);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvMovimiento.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                }
            }
        }


        private void LlenarDgCajaBuscar()
        {
            string cual = txtBuscarCaja.Text;
            dgvCaja.Rows.Clear();
            DataSet ds = new DataSet();

            ds = objNegCaja.listarCajaBuscar(cual);
            if (ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dgvCaja.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4],  dr[5], dr[6], dr[7], dr[8]);
                }
            }
         
        }

        #endregion

        #region EliminarIdDg


        public void DgEliminarProductoId()
        {
            string id = txtEliminarProducto.Text;
            dgvProducto.Rows.Clear();
            DataSet ds = new DataSet();

            try
            {
                ds = objNegProducto.ListarProductoEliminar(id);

                if (ds.Tables.Count >= 0)
                {
                    try
                    {
                        foreach (DataRow dr in ds.Tables)
                        {
                            dgvProducto.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        public void DgEliminarMovimientoId()
        {
            string id = txtEliminarMovimiento.Text;
            dgvMovimiento.Rows.Clear();
            DataSet ds = new DataSet();
            try
            {
                ds = objNegMovimiento.ListarMovimientoEliminar(id);
                if (ds.Tables.Count >= 0)
                {
                    try
                    {
                        foreach (DataRow dr in ds.Tables)
                        {
                            dgvMovimiento.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3]);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DgEliminarCajaId()
        {
            string id = txtEliminarCaja.Text;
            dgvCaja.Rows.Clear();
            DataSet ds = new DataSet();
            try
            {
                ds = objNegCaja.ListarCajaEliminar(id);
                if (ds.Tables.Count >= 0)
                {
                    try
                    {
                        foreach (DataRow dr in ds.Tables)
                        {
                            dgvMovimiento.Rows.Add(dr[0].ToString(), dr[1], dr[2], dr[3], dr[4] );
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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





         
        #region MetodoLlenarCombo
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
            objEntCaja.FechaCaja = dateTimeCaja.Value;
            objEntCaja.productoId = int.Parse(cbCajaProducto.SelectedValue.ToString());
            objEntCaja.movimientoId = int.Parse(cbCajaMovimiento.SelectedValue.ToString());


        }



        #endregion

        #region MetodosValidar
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
            txtBuscarProducto.Clear();
            txtEliminarProducto.Clear();
        }
        private void LimpiarMovimiento()
        {
            txtNombreMovimiento.Text = string.Empty;
            txtApellidoCliente.Text = string.Empty;           
            txtMedioPago.Text = string.Empty;
            txtBuscarMovimiento.Clear();
            txtEliminarMovimiento.Clear();
        }

        private void LimpiarCaja()
        {
            txtNombreMovimiento.Text = string.Empty;
            dateTimeCaja.Value = DateTime.Today;
            cbCajaProducto.SelectedIndex = 0;
            cbCajaMovimiento.SelectedIndex = 0;
            txtBuscarCaja.Clear();
            txtEliminarCaja.Clear();
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
            dateTimeCaja.Value = System.Convert.ToDateTime(ds.Tables[0].Rows[0]["FechaCaja"]);
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

        #region Validar




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
            LlenarDGVProducto();
        }

        private void btnCancelarMovimiento_Click(object sender, EventArgs e)
        {
            LimpiarMovimiento();
            btnCargaMovimiento.Visible = true;
            btnModificarMovimiento.Visible = true;
            btnCancelarMovimiento.Visible = true;
            LlenarDGVMovimiento();
        }




       

        private void btnCancelarCaja_Click(object sender, EventArgs e)
        {
            LimpiarCaja();
            btnCargaCaja.Visible = true;
            btnModificarCaja.Visible = true;
            btnCancelarCaja.Visible = true;
            LlenarDGVCaja();
        }

       
        #endregion

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            #region
            //bool validar = ValidacionCamposProducto();
            //int nGrabados = -1;
            //if (validar == true)
            //{
            //    TxtBox_a_ObjProducto();
            //    nGrabados = objNegProducto.abmProducto("Baja", objEntProducto);
            //    if (nGrabados == -1)
            //    {
            //        MessageBox.Show("No se logró eliminar el Producto del sistema");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Se logró eliminar el Producto con éxito");
            //        LlenarDGVProducto();
            //        LimpiarProducto();
            //        LlenarCombos();
            //        tabControl1.SelectTab(tabProducto);
            //    }
            //}
            #endregion

            if (true)
            {

                DgEliminarProductoId();

                LlenarDGVProducto();

                MessageBox.Show("Se elimino el producto");
            }
        }

        private void btnEliminarCaja_Click(object sender, EventArgs e)
        {
            #region
            //bool validar = ValidacionCamposCaja();
            //int nGrabados = -1;
            //if (validar == true)
            //{
            //    TxtBox_a_ObjCaja();
            //    nGrabados = objNegCaja.abmCaja("Baja", objEntCaja);
            //    if (nGrabados == -1)
            //    {
            //        MessageBox.Show("No se logró eliminar  del sistema");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Se logró eliminar la caja con éxito");
            //        LlenarDGVCaja();
            //        LimpiarCaja();
            //        LlenarCombos();
            //        tabControl1.SelectTab(tabProducto);
            //    }
            //}
            #endregion

            if (true)
            {

                DgEliminarCajaId();

                LlenarDGVCaja();

                MessageBox.Show("Se eliminaron los detalles de Caja");
            }
        }

        private void btnBuscarCaja_Click(object sender, EventArgs e)
        {
            LlenarDgCajaBuscar();
        }


        private void btnBuscarMovimiento_Click(object sender, EventArgs e)
        {
            LlenarDgMovimientoBuscar();
        }

        private void btnEliminarMovimiento_Click(object sender, EventArgs e)
        {
            #region
            //bool validar = ValidacionCamposMovimiento();
            //int nGrabados = -1;
            //if (validar == true)
            //{
            //    TxtBox_a_ObjMovimiento();
            //    nGrabados = objNegMovimiento.abmMovimiento("Baja", objEntMovimiento);
            //    if (nGrabados == -1)
            //    {
            //        MessageBox.Show("No se logró eliminar los detalles de Movimiento del sistema");
            //    }
            //    else
            //    {
            //        MessageBox.Show("Se logró eliminar los detalles de Movimiento con éxito");
            //        LlenarDGVMovimiento();
            //        LimpiarMovimiento();
            //        LlenarCombos2();
            //        tabControl1.SelectTab(tabMovimiento);
            //    }
            //}
            #endregion


            if (true)
            {

                DgEliminarMovimientoId();

                LlenarDGVMovimiento();

                MessageBox.Show("Se eliminaron los detalles del Movimiento");
            }


        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            LlenarDgProductoBuscar();
        }

        private void lblEliminarProducto_Click(object sender, EventArgs e)
        {

        }

        private void lblBuscarMovimiento_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtTipoCaja_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimeCaja_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Quiosco
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl1 = new TabControl();
            tabProducto = new TabPage();
            txtEliminarProducto = new TextBox();
            lblEliminarProducto = new Label();
            label4 = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            btnEliminarProducto = new Button();
            btnCancelarProducto = new Button();
            btnModificarProducto = new Button();
            btnCargarProducto = new Button();
            txtCategoriaProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtNombreProducto = new TextBox();
            lblCategoria = new Label();
            lblPrecioProducto = new Label();
            lblNombreProducto = new Label();
            tabMovimiento = new TabPage();
            txtDniCliente = new TextBox();
            lblDniCliente = new Label();
            txtEliminarMovimiento = new TextBox();
            lblEliminarMovimiento = new Label();
            lblBuscarMovimiento = new Label();
            txtBuscarMovimiento = new TextBox();
            btnEliminarMovimiento = new Button();
            btnBuscarMovimiento = new Button();
            txtMedioPago = new TextBox();
            txtApellidoCliente = new TextBox();
            btnCancelarMovimiento = new Button();
            btnModificarMovimiento = new Button();
            lblMovimiento = new Label();
            btnCargaMovimiento = new Button();
            txtNombreMovimiento = new TextBox();
            lblTipoMovimiento = new Label();
            lblNombreMovimiento = new Label();
            tabCaja = new TabPage();
            lblFechaCaja = new Label();
            dateTimeCaja = new DateTimePicker();
            txtEliminarCaja = new TextBox();
            lblEliminarCaja = new Label();
            txtBuscarCaja = new TextBox();
            lblBuscarCaja = new Label();
            btnBuscarCaja = new Button();
            btnEliminarCaja = new Button();
            cbCajaMovimiento = new ComboBox();
            cbCajaProducto = new ComboBox();
            btnModificarCaja = new Button();
            txtTipoCaja = new TextBox();
            lblMovimientoId = new Label();
            lblProductoId = new Label();
            lblTipoComprobante = new Label();
            btnCargaCaja = new Button();
            btnCancelarCaja = new Button();
            dgvProducto = new DataGridView();
            dgvMovimiento = new DataGridView();
            dgvCaja = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabProducto.SuspendLayout();
            tabMovimiento.SuspendLayout();
            tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimiento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabProducto);
            tabControl1.Controls.Add(tabMovimiento);
            tabControl1.Controls.Add(tabCaja);
            tabControl1.Location = new Point(539, 17);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(599, 298);
            tabControl1.TabIndex = 0;
            // 
            // tabProducto
            // 
            tabProducto.BackgroundImage = (Image)resources.GetObject("tabProducto.BackgroundImage");
            tabProducto.BackgroundImageLayout = ImageLayout.Stretch;
            tabProducto.BorderStyle = BorderStyle.Fixed3D;
            tabProducto.Controls.Add(txtEliminarProducto);
            tabProducto.Controls.Add(lblEliminarProducto);
            tabProducto.Controls.Add(label4);
            tabProducto.Controls.Add(txtBuscarProducto);
            tabProducto.Controls.Add(btnBuscarProducto);
            tabProducto.Controls.Add(btnEliminarProducto);
            tabProducto.Controls.Add(btnCancelarProducto);
            tabProducto.Controls.Add(btnModificarProducto);
            tabProducto.Controls.Add(btnCargarProducto);
            tabProducto.Controls.Add(txtCategoriaProducto);
            tabProducto.Controls.Add(txtPrecioProducto);
            tabProducto.Controls.Add(txtNombreProducto);
            tabProducto.Controls.Add(lblCategoria);
            tabProducto.Controls.Add(lblPrecioProducto);
            tabProducto.Controls.Add(lblNombreProducto);
            tabProducto.Cursor = Cursors.Hand;
            tabProducto.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabProducto.ForeColor = SystemColors.ActiveCaptionText;
            tabProducto.Location = new Point(4, 27);
            tabProducto.Margin = new Padding(4);
            tabProducto.Name = "tabProducto";
            tabProducto.Padding = new Padding(4);
            tabProducto.Size = new Size(591, 267);
            tabProducto.TabIndex = 0;
            tabProducto.Text = "Producto";
            tabProducto.UseVisualStyleBackColor = true;
            // 
            // txtEliminarProducto
            // 
            txtEliminarProducto.Location = new Point(378, 223);
            txtEliminarProducto.Name = "txtEliminarProducto";
            txtEliminarProducto.Size = new Size(118, 27);
            txtEliminarProducto.TabIndex = 38;
            // 
            // lblEliminarProducto
            // 
            lblEliminarProducto.AutoSize = true;
            lblEliminarProducto.BackColor = Color.Wheat;
            lblEliminarProducto.Location = new Point(305, 227);
            lblEliminarProducto.Margin = new Padding(4, 0, 4, 0);
            lblEliminarProducto.Name = "lblEliminarProducto";
            lblEliminarProducto.Size = new Size(66, 20);
            lblEliminarProducto.TabIndex = 37;
            lblEliminarProducto.Text = "Eliminar";
            lblEliminarProducto.Click += lblEliminarProducto_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.Location = new Point(8, 223);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 36;
            label4.Text = "Buscar";
            label4.Click += label4_Click;
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(71, 220);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(123, 27);
            txtBuscarProducto.TabIndex = 35;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Gold;
            btnBuscarProducto.Location = new Point(204, 215);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(84, 36);
            btnBuscarProducto.TabIndex = 30;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Gold;
            btnEliminarProducto.Location = new Point(500, 217);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(84, 36);
            btnEliminarProducto.TabIndex = 29;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.BackColor = Color.Gold;
            btnCancelarProducto.Location = new Point(399, 94);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(84, 36);
            btnCancelarProducto.TabIndex = 27;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = false;
            btnCancelarProducto.Click += btnCancelarProducto_Click;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.Gold;
            btnModificarProducto.Location = new Point(458, 34);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(84, 39);
            btnModificarProducto.TabIndex = 24;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            btnModificarProducto.Click += btnModificarProducto_Click;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.BackColor = Color.Gold;
            btnCargarProducto.Location = new Point(348, 35);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(84, 36);
            btnCargarProducto.TabIndex = 28;
            btnCargarProducto.Text = "Cargar";
            btnCargarProducto.UseVisualStyleBackColor = false;
            btnCargarProducto.Click += btnCargaProducto_Click;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(147, 43);
            txtCategoriaProducto.Margin = new Padding(4);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(173, 27);
            txtCategoriaProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(146, 157);
            txtPrecioProducto.Margin = new Padding(4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(176, 27);
            txtPrecioProducto.TabIndex = 5;
            txtPrecioProducto.KeyPress += txtPrecioProducto_KeyPress;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(147, 99);
            txtNombreProducto.Margin = new Padding(4);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(173, 27);
            txtNombreProducto.TabIndex = 4;
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Wheat;
            lblCategoria.ForeColor = SystemColors.ActiveCaptionText;
            lblCategoria.Location = new Point(39, 46);
            lblCategoria.Margin = new Padding(4, 0, 4, 0);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(76, 20);
            lblCategoria.TabIndex = 2;
            lblCategoria.Text = "Categoria";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BackColor = Color.Wheat;
            lblPrecioProducto.Location = new Point(49, 160);
            lblPrecioProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(52, 20);
            lblPrecioProducto.TabIndex = 1;
            lblPrecioProducto.Text = "Precio";
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.Wheat;
            lblNombreProducto.Location = new Point(8, 102);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(135, 20);
            lblNombreProducto.TabIndex = 0;
            lblNombreProducto.Text = "Nombre Producto";
            // 
            // tabMovimiento
            // 
            tabMovimiento.BackgroundImage = (Image)resources.GetObject("tabMovimiento.BackgroundImage");
            tabMovimiento.BackgroundImageLayout = ImageLayout.Stretch;
            tabMovimiento.BorderStyle = BorderStyle.Fixed3D;
            tabMovimiento.Controls.Add(txtDniCliente);
            tabMovimiento.Controls.Add(lblDniCliente);
            tabMovimiento.Controls.Add(txtEliminarMovimiento);
            tabMovimiento.Controls.Add(lblEliminarMovimiento);
            tabMovimiento.Controls.Add(lblBuscarMovimiento);
            tabMovimiento.Controls.Add(txtBuscarMovimiento);
            tabMovimiento.Controls.Add(btnEliminarMovimiento);
            tabMovimiento.Controls.Add(btnBuscarMovimiento);
            tabMovimiento.Controls.Add(txtMedioPago);
            tabMovimiento.Controls.Add(txtApellidoCliente);
            tabMovimiento.Controls.Add(btnCancelarMovimiento);
            tabMovimiento.Controls.Add(btnModificarMovimiento);
            tabMovimiento.Controls.Add(lblMovimiento);
            tabMovimiento.Controls.Add(btnCargaMovimiento);
            tabMovimiento.Controls.Add(txtNombreMovimiento);
            tabMovimiento.Controls.Add(lblTipoMovimiento);
            tabMovimiento.Controls.Add(lblNombreMovimiento);
            tabMovimiento.Cursor = Cursors.Hand;
            tabMovimiento.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabMovimiento.Location = new Point(4, 27);
            tabMovimiento.Margin = new Padding(4);
            tabMovimiento.Name = "tabMovimiento";
            tabMovimiento.Padding = new Padding(4);
            tabMovimiento.Size = new Size(591, 267);
            tabMovimiento.TabIndex = 1;
            tabMovimiento.Text = "Movimiento";
            tabMovimiento.UseVisualStyleBackColor = true;
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(170, 105);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.Size = new Size(132, 27);
            txtDniCliente.TabIndex = 42;
            // 
            // lblDniCliente
            // 
            lblDniCliente.AutoSize = true;
            lblDniCliente.BackColor = Color.Wheat;
            lblDniCliente.Location = new Point(25, 105);
            lblDniCliente.Margin = new Padding(4, 0, 4, 0);
            lblDniCliente.Name = "lblDniCliente";
            lblDniCliente.Size = new Size(89, 20);
            lblDniCliente.TabIndex = 41;
            lblDniCliente.Text = "DNI Cliente";
            // 
            // txtEliminarMovimiento
            // 
            txtEliminarMovimiento.Location = new Point(392, 226);
            txtEliminarMovimiento.Name = "txtEliminarMovimiento";
            txtEliminarMovimiento.Size = new Size(104, 27);
            txtEliminarMovimiento.TabIndex = 40;
            // 
            // lblEliminarMovimiento
            // 
            lblEliminarMovimiento.AutoSize = true;
            lblEliminarMovimiento.BackColor = Color.Wheat;
            lblEliminarMovimiento.Location = new Point(319, 229);
            lblEliminarMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblEliminarMovimiento.Name = "lblEliminarMovimiento";
            lblEliminarMovimiento.Size = new Size(66, 20);
            lblEliminarMovimiento.TabIndex = 39;
            lblEliminarMovimiento.Text = "Eliminar";
            // 
            // lblBuscarMovimiento
            // 
            lblBuscarMovimiento.AutoSize = true;
            lblBuscarMovimiento.BackColor = Color.Wheat;
            lblBuscarMovimiento.Location = new Point(2, 226);
            lblBuscarMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblBuscarMovimiento.Name = "lblBuscarMovimiento";
            lblBuscarMovimiento.Size = new Size(56, 20);
            lblBuscarMovimiento.TabIndex = 32;
            lblBuscarMovimiento.Text = "Buscar";
            lblBuscarMovimiento.Click += lblBuscarMovimiento_Click;
            // 
            // txtBuscarMovimiento
            // 
            txtBuscarMovimiento.Location = new Point(65, 222);
            txtBuscarMovimiento.Name = "txtBuscarMovimiento";
            txtBuscarMovimiento.Size = new Size(148, 27);
            txtBuscarMovimiento.TabIndex = 31;
            // 
            // btnEliminarMovimiento
            // 
            btnEliminarMovimiento.BackColor = Color.Gold;
            btnEliminarMovimiento.Location = new Point(502, 224);
            btnEliminarMovimiento.Name = "btnEliminarMovimiento";
            btnEliminarMovimiento.Size = new Size(84, 31);
            btnEliminarMovimiento.TabIndex = 30;
            btnEliminarMovimiento.Text = "Eliminar";
            btnEliminarMovimiento.UseVisualStyleBackColor = false;
            btnEliminarMovimiento.Click += btnEliminarMovimiento_Click;
            // 
            // btnBuscarMovimiento
            // 
            btnBuscarMovimiento.BackColor = Color.Gold;
            btnBuscarMovimiento.Location = new Point(219, 218);
            btnBuscarMovimiento.Name = "btnBuscarMovimiento";
            btnBuscarMovimiento.Size = new Size(84, 31);
            btnBuscarMovimiento.TabIndex = 29;
            btnBuscarMovimiento.Text = "Buscar";
            btnBuscarMovimiento.UseVisualStyleBackColor = false;
            btnBuscarMovimiento.Click += btnBuscarMovimiento_Click;
            // 
            // txtMedioPago
            // 
            txtMedioPago.Location = new Point(171, 149);
            txtMedioPago.Name = "txtMedioPago";
            txtMedioPago.Size = new Size(132, 27);
            txtMedioPago.TabIndex = 28;
            // 
            // txtApellidoCliente
            // 
            txtApellidoCliente.Location = new Point(171, 61);
            txtApellidoCliente.Name = "txtApellidoCliente";
            txtApellidoCliente.Size = new Size(132, 27);
            txtApellidoCliente.TabIndex = 27;
            txtApellidoCliente.TextChanged += txtApellidoCliente_TextChanged;
            // 
            // btnCancelarMovimiento
            // 
            btnCancelarMovimiento.BackColor = Color.Gold;
            btnCancelarMovimiento.Location = new Point(406, 95);
            btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            btnCancelarMovimiento.Size = new Size(84, 31);
            btnCancelarMovimiento.TabIndex = 26;
            btnCancelarMovimiento.Text = "Cancelar";
            btnCancelarMovimiento.UseVisualStyleBackColor = false;
            btnCancelarMovimiento.Click += btnCancelarMovimiento_Click;
            // 
            // btnModificarMovimiento
            // 
            btnModificarMovimiento.BackColor = Color.Gold;
            btnModificarMovimiento.Location = new Point(457, 35);
            btnModificarMovimiento.Name = "btnModificarMovimiento";
            btnModificarMovimiento.Size = new Size(84, 33);
            btnModificarMovimiento.TabIndex = 25;
            btnModificarMovimiento.Text = "Modificar";
            btnModificarMovimiento.UseVisualStyleBackColor = false;
            btnModificarMovimiento.Click += btnModificarMovimiento_Click;
            // 
            // lblMovimiento
            // 
            lblMovimiento.AutoSize = true;
            lblMovimiento.BackColor = Color.Wheat;
            lblMovimiento.Location = new Point(26, 152);
            lblMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblMovimiento.Name = "lblMovimiento";
            lblMovimiento.Size = new Size(113, 20);
            lblMovimiento.TabIndex = 22;
            lblMovimiento.Text = "Medio de Pago";
            // 
            // btnCargaMovimiento
            // 
            btnCargaMovimiento.BackColor = Color.Gold;
            btnCargaMovimiento.Location = new Point(353, 37);
            btnCargaMovimiento.Name = "btnCargaMovimiento";
            btnCargaMovimiento.Size = new Size(84, 31);
            btnCargaMovimiento.TabIndex = 17;
            btnCargaMovimiento.Text = "Cargar";
            btnCargaMovimiento.UseVisualStyleBackColor = false;
            btnCargaMovimiento.Click += btnCargaMovimiento_Click;
            // 
            // txtNombreMovimiento
            // 
            txtNombreMovimiento.Location = new Point(171, 23);
            txtNombreMovimiento.Margin = new Padding(4);
            txtNombreMovimiento.Name = "txtNombreMovimiento";
            txtNombreMovimiento.Size = new Size(132, 27);
            txtNombreMovimiento.TabIndex = 13;
            // 
            // lblTipoMovimiento
            // 
            lblTipoMovimiento.AutoSize = true;
            lblTipoMovimiento.BackColor = Color.Wheat;
            lblTipoMovimiento.Location = new Point(26, 63);
            lblTipoMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblTipoMovimiento.Name = "lblTipoMovimiento";
            lblTipoMovimiento.Size = new Size(119, 20);
            lblTipoMovimiento.TabIndex = 10;
            lblTipoMovimiento.Text = "Apellido Cliente";
            // 
            // lblNombreMovimiento
            // 
            lblNombreMovimiento.AutoSize = true;
            lblNombreMovimiento.BackColor = Color.Wheat;
            lblNombreMovimiento.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNombreMovimiento.Location = new Point(26, 26);
            lblNombreMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblNombreMovimiento.Name = "lblNombreMovimiento";
            lblNombreMovimiento.Size = new Size(119, 20);
            lblNombreMovimiento.TabIndex = 9;
            lblNombreMovimiento.Text = "Nombre Cliente";
            // 
            // tabCaja
            // 
            tabCaja.BackgroundImage = (Image)resources.GetObject("tabCaja.BackgroundImage");
            tabCaja.BackgroundImageLayout = ImageLayout.Stretch;
            tabCaja.BorderStyle = BorderStyle.Fixed3D;
            tabCaja.Controls.Add(lblFechaCaja);
            tabCaja.Controls.Add(dateTimeCaja);
            tabCaja.Controls.Add(txtEliminarCaja);
            tabCaja.Controls.Add(lblEliminarCaja);
            tabCaja.Controls.Add(txtBuscarCaja);
            tabCaja.Controls.Add(lblBuscarCaja);
            tabCaja.Controls.Add(btnBuscarCaja);
            tabCaja.Controls.Add(btnEliminarCaja);
            tabCaja.Controls.Add(cbCajaMovimiento);
            tabCaja.Controls.Add(cbCajaProducto);
            tabCaja.Controls.Add(btnModificarCaja);
            tabCaja.Controls.Add(txtTipoCaja);
            tabCaja.Controls.Add(lblMovimientoId);
            tabCaja.Controls.Add(lblProductoId);
            tabCaja.Controls.Add(lblTipoComprobante);
            tabCaja.Controls.Add(btnCargaCaja);
            tabCaja.Controls.Add(btnCancelarCaja);
            tabCaja.Cursor = Cursors.Hand;
            tabCaja.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabCaja.Location = new Point(4, 27);
            tabCaja.Name = "tabCaja";
            tabCaja.Padding = new Padding(3);
            tabCaja.Size = new Size(591, 267);
            tabCaja.TabIndex = 2;
            tabCaja.Text = "Caja";
            tabCaja.UseVisualStyleBackColor = true;
            // 
            // lblFechaCaja
            // 
            lblFechaCaja.AutoSize = true;
            lblFechaCaja.BackColor = Color.Wheat;
            lblFechaCaja.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaCaja.Location = new Point(41, 167);
            lblFechaCaja.Name = "lblFechaCaja";
            lblFechaCaja.Size = new Size(49, 20);
            lblFechaCaja.TabIndex = 44;
            lblFechaCaja.Text = "Fecha";
            // 
            // dateTimeCaja
            // 
            dateTimeCaja.Location = new Point(137, 167);
            dateTimeCaja.Name = "dateTimeCaja";
            dateTimeCaja.Size = new Size(300, 27);
            dateTimeCaja.TabIndex = 43;
            dateTimeCaja.ValueChanged += dateTimeCaja_ValueChanged;
            // 
            // txtEliminarCaja
            // 
            txtEliminarCaja.Location = new Point(380, 213);
            txtEliminarCaja.Name = "txtEliminarCaja";
            txtEliminarCaja.Size = new Size(115, 27);
            txtEliminarCaja.TabIndex = 42;
            // 
            // lblEliminarCaja
            // 
            lblEliminarCaja.AutoSize = true;
            lblEliminarCaja.BackColor = Color.Wheat;
            lblEliminarCaja.Location = new Point(309, 216);
            lblEliminarCaja.Margin = new Padding(4, 0, 4, 0);
            lblEliminarCaja.Name = "lblEliminarCaja";
            lblEliminarCaja.Size = new Size(66, 20);
            lblEliminarCaja.TabIndex = 41;
            lblEliminarCaja.Text = "Eliminar";
            // 
            // txtBuscarCaja
            // 
            txtBuscarCaja.Location = new Point(69, 212);
            txtBuscarCaja.Name = "txtBuscarCaja";
            txtBuscarCaja.Size = new Size(135, 27);
            txtBuscarCaja.TabIndex = 33;
            // 
            // lblBuscarCaja
            // 
            lblBuscarCaja.AutoSize = true;
            lblBuscarCaja.BackColor = Color.Wheat;
            lblBuscarCaja.ForeColor = SystemColors.ActiveCaptionText;
            lblBuscarCaja.Location = new Point(7, 215);
            lblBuscarCaja.Name = "lblBuscarCaja";
            lblBuscarCaja.Size = new Size(56, 20);
            lblBuscarCaja.TabIndex = 32;
            lblBuscarCaja.Text = "Buscar";
            // 
            // btnBuscarCaja
            // 
            btnBuscarCaja.BackColor = Color.Gold;
            btnBuscarCaja.Location = new Point(210, 208);
            btnBuscarCaja.Name = "btnBuscarCaja";
            btnBuscarCaja.Size = new Size(84, 36);
            btnBuscarCaja.TabIndex = 31;
            btnBuscarCaja.Text = "Buscar";
            btnBuscarCaja.UseVisualStyleBackColor = false;
            btnBuscarCaja.Click += btnBuscarCaja_Click;
            // 
            // btnEliminarCaja
            // 
            btnEliminarCaja.BackColor = Color.Gold;
            btnEliminarCaja.Location = new Point(501, 209);
            btnEliminarCaja.Name = "btnEliminarCaja";
            btnEliminarCaja.Size = new Size(84, 36);
            btnEliminarCaja.TabIndex = 30;
            btnEliminarCaja.Text = "Eliminar";
            btnEliminarCaja.UseVisualStyleBackColor = false;
            btnEliminarCaja.Click += btnEliminarCaja_Click;
            // 
            // cbCajaMovimiento
            // 
            cbCajaMovimiento.FormattingEnabled = true;
            cbCajaMovimiento.Location = new Point(137, 115);
            cbCajaMovimiento.Name = "cbCajaMovimiento";
            cbCajaMovimiento.Size = new Size(250, 28);
            cbCajaMovimiento.TabIndex = 12;
            // 
            // cbCajaProducto
            // 
            cbCajaProducto.FormattingEnabled = true;
            cbCajaProducto.Location = new Point(137, 74);
            cbCajaProducto.Name = "cbCajaProducto";
            cbCajaProducto.Size = new Size(250, 28);
            cbCajaProducto.TabIndex = 11;
            // 
            // btnModificarCaja
            // 
            btnModificarCaja.BackColor = Color.Gold;
            btnModificarCaja.Location = new Point(488, 32);
            btnModificarCaja.Name = "btnModificarCaja";
            btnModificarCaja.Size = new Size(91, 32);
            btnModificarCaja.TabIndex = 20;
            btnModificarCaja.Text = "Modificar";
            btnModificarCaja.UseVisualStyleBackColor = false;
            btnModificarCaja.Click += btnModificarCaja_Click;
            // 
            // txtTipoCaja
            // 
            txtTipoCaja.Location = new Point(190, 26);
            txtTipoCaja.Name = "txtTipoCaja";
            txtTipoCaja.Size = new Size(147, 27);
            txtTipoCaja.TabIndex = 6;
            txtTipoCaja.TextChanged += txtTipoCaja_TextChanged;
            // 
            // lblMovimientoId
            // 
            lblMovimientoId.AutoSize = true;
            lblMovimientoId.BackColor = Color.Wheat;
            lblMovimientoId.ForeColor = SystemColors.ActiveCaptionText;
            lblMovimientoId.Location = new Point(27, 118);
            lblMovimientoId.Name = "lblMovimientoId";
            lblMovimientoId.Size = new Size(94, 20);
            lblMovimientoId.TabIndex = 4;
            lblMovimientoId.Text = "Movimiento";
            // 
            // lblProductoId
            // 
            lblProductoId.AutoSize = true;
            lblProductoId.BackColor = Color.Wheat;
            lblProductoId.ForeColor = SystemColors.ActiveCaptionText;
            lblProductoId.Location = new Point(31, 77);
            lblProductoId.Name = "lblProductoId";
            lblProductoId.Size = new Size(73, 20);
            lblProductoId.TabIndex = 3;
            lblProductoId.Text = "Producto";
            // 
            // lblTipoComprobante
            // 
            lblTipoComprobante.AutoSize = true;
            lblTipoComprobante.BackColor = Color.Wheat;
            lblTipoComprobante.ForeColor = SystemColors.ActiveCaptionText;
            lblTipoComprobante.Location = new Point(6, 29);
            lblTipoComprobante.Name = "lblTipoComprobante";
            lblTipoComprobante.Size = new Size(140, 20);
            lblTipoComprobante.TabIndex = 2;
            lblTipoComprobante.Text = "Tipo Comprobante";
            // 
            // btnCargaCaja
            // 
            btnCargaCaja.BackColor = Color.Gold;
            btnCargaCaja.Location = new Point(394, 32);
            btnCargaCaja.Name = "btnCargaCaja";
            btnCargaCaja.Size = new Size(75, 31);
            btnCargaCaja.TabIndex = 1;
            btnCargaCaja.Text = "Cargar";
            btnCargaCaja.UseVisualStyleBackColor = false;
            btnCargaCaja.Click += btnCargaCaja_Click;
            // 
            // btnCancelarCaja
            // 
            btnCancelarCaja.AccessibleRole = AccessibleRole.Sound;
            btnCancelarCaja.BackColor = Color.Gold;
            btnCancelarCaja.Location = new Point(443, 81);
            btnCancelarCaja.Name = "btnCancelarCaja";
            btnCancelarCaja.Size = new Size(84, 31);
            btnCancelarCaja.TabIndex = 0;
            btnCancelarCaja.Text = "Cancelar";
            btnCancelarCaja.UseVisualStyleBackColor = false;
            btnCancelarCaja.Click += btnCancelarCaja_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvProducto.BorderStyle = BorderStyle.Fixed3D;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Cursor = Cursors.Hand;
            dgvProducto.Location = new Point(12, 44);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Size = new Size(503, 271);
            dgvProducto.TabIndex = 2;
            dgvProducto.CellClick += dgvProducto_CellClick_1;
            // 
            // dgvMovimiento
            // 
            dgvMovimiento.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvMovimiento.BorderStyle = BorderStyle.Fixed3D;
            dgvMovimiento.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvMovimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMovimiento.Cursor = Cursors.Hand;
            dgvMovimiento.Location = new Point(12, 350);
            dgvMovimiento.Name = "dgvMovimiento";
            dgvMovimiento.Size = new Size(533, 271);
            dgvMovimiento.TabIndex = 3;
            dgvMovimiento.CellClick += dgvMovimiento_CellClick;
            // 
            // dgvCaja
            // 
            dgvCaja.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvCaja.BorderStyle = BorderStyle.Fixed3D;
            dgvCaja.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvCaja.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCaja.Cursor = Cursors.Hand;
            dgvCaja.Location = new Point(580, 350);
            dgvCaja.Name = "dgvCaja";
            dgvCaja.RowTemplate.Height = 25;
            dgvCaja.Size = new Size(687, 271);
            dgvCaja.TabIndex = 4;
            dgvCaja.CellClick += dgvCaja_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(211, 17);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 5;
            label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(211, 318);
            label2.Name = "label2";
            label2.Size = new Size(139, 20);
            label2.TabIndex = 6;
            label2.Text = "MOVIMIENTOS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(820, 318);
            label3.Name = "label3";
            label3.Size = new Size(58, 20);
            label3.TabIndex = 7;
            label3.Text = "CAJA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1303, 675);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCaja);
            Controls.Add(dgvMovimiento);
            Controls.Add(dgvProducto);
            Controls.Add(tabControl1);
            Font = new Font("Corbel", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabProducto.ResumeLayout(false);
            tabProducto.PerformLayout();
            tabMovimiento.ResumeLayout(false);
            tabMovimiento.PerformLayout();
            tabCaja.ResumeLayout(false);
            tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMovimiento).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCaja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtNombreProducto;
        private Label lblCategoria;
        private Label lblPrecioProducto;
        private Label lblNombreProducto;
        private TabPage tabMovimiento;
        private TextBox txtNombreMovimiento;
        private Label lblTipoMovimiento;
        private Label lblNombreMovimiento;
        private Label lblMovimiento;
        private DataGridView dgvProducto;
        private DataGridView dgvMovimiento;
        private Button btnCargaMovimiento;
        private Button btnModificarMovimiento;
        private Button btnCancelarProducto;
        private TabPage tabCaja;
        private TextBox txtTipoCaja;
        private Button btnModificarProducto;
        private Label lblMovimientoId;
        private Label lblProductoId;
        private Label lblTipoComprobante;
        private Button btnCargaCaja;
        private Button btnCancelarCaja;
        private DataGridView dgvCaja;
        private Button btnModificarCaja;
        private Button btnCargarProducto;
        private Button btnCancelarMovimiento;
        private TextBox txtMedioPago;
        private TextBox txtApellidoCliente;
        private ComboBox cbCajaMovimiento;
        private ComboBox cbCajaProducto;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnEliminarCaja;
        private Button btnBuscarCaja;
        private Button btnEliminarMovimiento;
        private Button btnBuscarMovimiento;
        private Label label4;
        private TextBox txtBuscarProducto;
        private Label lblBuscarMovimiento;
        private TextBox txtBuscarMovimiento;
        private TextBox txtBuscarCaja;
        private Label lblBuscarCaja;
        private Label lblEliminarProducto;
        private TextBox txtEliminarProducto;
        private TextBox txtEliminarMovimiento;
        private Label lblEliminarMovimiento;
        private TextBox txtEliminarCaja;
        private Label lblEliminarCaja;
        private Label lblFechaCaja;
        private DateTimePicker dateTimeCaja;
        private TextBox txtDniCliente;
        private Label lblDniCliente;
    }
}


namespace Quiosco
{
    partial class FormInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            tabControl1 = new TabControl();
            tabInicio = new TabPage();
            pictureBox1 = new PictureBox();
            btRegistrarVenta = new Button();
            btRegistrarProducto = new Button();
            label2 = new Label();
            tabMisProductos = new TabPage();
            tabMisVentas = new TabPage();
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
            tabDeudores = new TabPage();
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
            tabProveedor = new TabPage();
            tabControl1.SuspendLayout();
            tabInicio.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabMisVentas.SuspendLayout();
            tabDeudores.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabInicio);
            tabControl1.Controls.Add(tabMisProductos);
            tabControl1.Controls.Add(tabMisVentas);
            tabControl1.Controls.Add(tabDeudores);
            tabControl1.Controls.Add(tabProveedor);
            tabControl1.Location = new Point(22, 8);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1371, 650);
            tabControl1.TabIndex = 1;
            // 
            // tabInicio
            // 
            tabInicio.BackgroundImage = (Image)resources.GetObject("tabInicio.BackgroundImage");
            tabInicio.BackgroundImageLayout = ImageLayout.Stretch;
            tabInicio.Controls.Add(pictureBox1);
            tabInicio.Controls.Add(btRegistrarVenta);
            tabInicio.Controls.Add(btRegistrarProducto);
            tabInicio.Controls.Add(label2);
            tabInicio.Location = new Point(4, 24);
            tabInicio.Name = "tabInicio";
            tabInicio.Padding = new Padding(3);
            tabInicio.Size = new Size(1363, 622);
            tabInicio.TabIndex = 3;
            tabInicio.Text = "Inicio";
            tabInicio.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.AccessibleRole = AccessibleRole.Chart;
            pictureBox1.BackColor = Color.DodgerBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(203, 175);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // btRegistrarVenta
            // 
            btRegistrarVenta.BackColor = Color.Red;
            btRegistrarVenta.BackgroundImageLayout = ImageLayout.Center;
            btRegistrarVenta.Cursor = Cursors.Hand;
            btRegistrarVenta.FlatStyle = FlatStyle.Popup;
            btRegistrarVenta.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btRegistrarVenta.ForeColor = SystemColors.ActiveCaptionText;
            btRegistrarVenta.Location = new Point(981, 336);
            btRegistrarVenta.Name = "btRegistrarVenta";
            btRegistrarVenta.Size = new Size(220, 42);
            btRegistrarVenta.TabIndex = 12;
            btRegistrarVenta.Text = "REGISTRAR VENTA";
            btRegistrarVenta.UseVisualStyleBackColor = false;
            btRegistrarVenta.Click += btRegistrarVenta_Click;
            // 
            // btRegistrarProducto
            // 
            btRegistrarProducto.BackColor = Color.Red;
            btRegistrarProducto.BackgroundImageLayout = ImageLayout.Center;
            btRegistrarProducto.Cursor = Cursors.Hand;
            btRegistrarProducto.FlatStyle = FlatStyle.Popup;
            btRegistrarProducto.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btRegistrarProducto.ForeColor = SystemColors.ActiveCaptionText;
            btRegistrarProducto.Location = new Point(981, 204);
            btRegistrarProducto.Name = "btRegistrarProducto";
            btRegistrarProducto.Size = new Size(220, 42);
            btRegistrarProducto.TabIndex = 11;
            btRegistrarProducto.Text = "REGISTRAR PRODUCTO";
            btRegistrarProducto.UseVisualStyleBackColor = false;
            btRegistrarProducto.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.MintCream;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("High Tower Text", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(520, 25);
            label2.Name = "label2";
            label2.Size = new Size(218, 34);
            label2.TabIndex = 10;
            label2.Text = "BIENVENIDO!";
            // 
            // tabMisProductos
            // 
            tabMisProductos.BackgroundImage = (Image)resources.GetObject("tabMisProductos.BackgroundImage");
            tabMisProductos.BackgroundImageLayout = ImageLayout.Stretch;
            tabMisProductos.BorderStyle = BorderStyle.Fixed3D;
            tabMisProductos.Cursor = Cursors.Hand;
            tabMisProductos.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabMisProductos.ForeColor = SystemColors.ActiveCaptionText;
            tabMisProductos.Location = new Point(4, 24);
            tabMisProductos.Margin = new Padding(4);
            tabMisProductos.Name = "tabMisProductos";
            tabMisProductos.Padding = new Padding(4);
            tabMisProductos.Size = new Size(1363, 622);
            tabMisProductos.TabIndex = 0;
            tabMisProductos.Text = "Mis Productos";
            tabMisProductos.UseVisualStyleBackColor = true;
            // 
            // tabMisVentas
            // 
            tabMisVentas.BackgroundImage = (Image)resources.GetObject("tabMisVentas.BackgroundImage");
            tabMisVentas.BackgroundImageLayout = ImageLayout.Stretch;
            tabMisVentas.BorderStyle = BorderStyle.Fixed3D;
            tabMisVentas.Controls.Add(txtDniCliente);
            tabMisVentas.Controls.Add(lblDniCliente);
            tabMisVentas.Controls.Add(txtEliminarMovimiento);
            tabMisVentas.Controls.Add(lblEliminarMovimiento);
            tabMisVentas.Controls.Add(lblBuscarMovimiento);
            tabMisVentas.Controls.Add(txtBuscarMovimiento);
            tabMisVentas.Controls.Add(btnEliminarMovimiento);
            tabMisVentas.Controls.Add(btnBuscarMovimiento);
            tabMisVentas.Controls.Add(txtMedioPago);
            tabMisVentas.Controls.Add(txtApellidoCliente);
            tabMisVentas.Controls.Add(btnCancelarMovimiento);
            tabMisVentas.Controls.Add(btnModificarMovimiento);
            tabMisVentas.Controls.Add(lblMovimiento);
            tabMisVentas.Controls.Add(btnCargaMovimiento);
            tabMisVentas.Controls.Add(txtNombreMovimiento);
            tabMisVentas.Controls.Add(lblTipoMovimiento);
            tabMisVentas.Controls.Add(lblNombreMovimiento);
            tabMisVentas.Cursor = Cursors.Hand;
            tabMisVentas.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabMisVentas.Location = new Point(4, 24);
            tabMisVentas.Margin = new Padding(4);
            tabMisVentas.Name = "tabMisVentas";
            tabMisVentas.Padding = new Padding(4);
            tabMisVentas.Size = new Size(1363, 622);
            tabMisVentas.TabIndex = 1;
            tabMisVentas.Text = "Mis Ventas";
            tabMisVentas.UseVisualStyleBackColor = true;
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
            lblDniCliente.Location = new Point(29, 109);
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
            lblEliminarMovimiento.Location = new Point(323, 233);
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
            lblBuscarMovimiento.Location = new Point(6, 230);
            lblBuscarMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblBuscarMovimiento.Name = "lblBuscarMovimiento";
            lblBuscarMovimiento.Size = new Size(56, 20);
            lblBuscarMovimiento.TabIndex = 32;
            lblBuscarMovimiento.Text = "Buscar";
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
            // 
            // lblMovimiento
            // 
            lblMovimiento.AutoSize = true;
            lblMovimiento.BackColor = Color.Wheat;
            lblMovimiento.Location = new Point(30, 156);
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
            lblTipoMovimiento.Location = new Point(30, 67);
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
            lblNombreMovimiento.Location = new Point(30, 30);
            lblNombreMovimiento.Margin = new Padding(4, 0, 4, 0);
            lblNombreMovimiento.Name = "lblNombreMovimiento";
            lblNombreMovimiento.Size = new Size(119, 20);
            lblNombreMovimiento.TabIndex = 9;
            lblNombreMovimiento.Text = "Nombre Cliente";
            // 
            // tabDeudores
            // 
            tabDeudores.BackgroundImage = (Image)resources.GetObject("tabDeudores.BackgroundImage");
            tabDeudores.BackgroundImageLayout = ImageLayout.Stretch;
            tabDeudores.BorderStyle = BorderStyle.Fixed3D;
            tabDeudores.Controls.Add(lblFechaCaja);
            tabDeudores.Controls.Add(dateTimeCaja);
            tabDeudores.Controls.Add(txtEliminarCaja);
            tabDeudores.Controls.Add(lblEliminarCaja);
            tabDeudores.Controls.Add(txtBuscarCaja);
            tabDeudores.Controls.Add(lblBuscarCaja);
            tabDeudores.Controls.Add(btnBuscarCaja);
            tabDeudores.Controls.Add(btnEliminarCaja);
            tabDeudores.Controls.Add(cbCajaMovimiento);
            tabDeudores.Controls.Add(cbCajaProducto);
            tabDeudores.Controls.Add(btnModificarCaja);
            tabDeudores.Controls.Add(txtTipoCaja);
            tabDeudores.Controls.Add(lblMovimientoId);
            tabDeudores.Controls.Add(lblProductoId);
            tabDeudores.Controls.Add(lblTipoComprobante);
            tabDeudores.Controls.Add(btnCargaCaja);
            tabDeudores.Controls.Add(btnCancelarCaja);
            tabDeudores.Cursor = Cursors.Hand;
            tabDeudores.Font = new Font("Ebrima", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            tabDeudores.Location = new Point(4, 24);
            tabDeudores.Name = "tabDeudores";
            tabDeudores.Padding = new Padding(3);
            tabDeudores.Size = new Size(1363, 622);
            tabDeudores.TabIndex = 2;
            tabDeudores.Text = "Deudores";
            tabDeudores.UseVisualStyleBackColor = true;
            // 
            // lblFechaCaja
            // 
            lblFechaCaja.AutoSize = true;
            lblFechaCaja.BackColor = Color.Wheat;
            lblFechaCaja.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaCaja.Location = new Point(44, 170);
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
            lblEliminarCaja.Location = new Point(312, 219);
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
            lblBuscarCaja.Location = new Point(10, 218);
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
            // 
            // txtTipoCaja
            // 
            txtTipoCaja.Location = new Point(190, 26);
            txtTipoCaja.Name = "txtTipoCaja";
            txtTipoCaja.Size = new Size(147, 27);
            txtTipoCaja.TabIndex = 6;
            // 
            // lblMovimientoId
            // 
            lblMovimientoId.AutoSize = true;
            lblMovimientoId.BackColor = Color.Wheat;
            lblMovimientoId.ForeColor = SystemColors.ActiveCaptionText;
            lblMovimientoId.Location = new Point(30, 121);
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
            lblProductoId.Location = new Point(34, 80);
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
            lblTipoComprobante.Location = new Point(9, 32);
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
            // 
            // tabProveedor
            // 
            tabProveedor.BackgroundImage = (Image)resources.GetObject("tabProveedor.BackgroundImage");
            tabProveedor.BackgroundImageLayout = ImageLayout.Stretch;
            tabProveedor.Location = new Point(4, 24);
            tabProveedor.Name = "tabProveedor";
            tabProveedor.Padding = new Padding(3);
            tabProveedor.Size = new Size(1363, 622);
            tabProveedor.TabIndex = 4;
            tabProveedor.Text = "Proveedores";
            tabProveedor.UseVisualStyleBackColor = true;
            tabProveedor.Click += tabProveedor_Click;
            // 
            // FormInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1463, 671);
            Controls.Add(tabControl1);
            Name = "FormInicio";
            Text = "Form3";
            tabControl1.ResumeLayout(false);
            tabInicio.ResumeLayout(false);
            tabInicio.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabMisVentas.ResumeLayout(false);
            tabMisVentas.PerformLayout();
            tabDeudores.ResumeLayout(false);
            tabDeudores.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabMisProductos;
        private TabPage tabMisVentas;
        private TextBox txtDniCliente;
        private Label lblDniCliente;
        private TextBox txtEliminarMovimiento;
        private Label lblEliminarMovimiento;
        private Label lblBuscarMovimiento;
        private TextBox txtBuscarMovimiento;
        private Button btnEliminarMovimiento;
        private Button btnBuscarMovimiento;
        private TextBox txtMedioPago;
        private TextBox txtApellidoCliente;
        private Button btnCancelarMovimiento;
        private Button btnModificarMovimiento;
        private Label lblMovimiento;
        private Button btnCargaMovimiento;
        private TextBox txtNombreMovimiento;
        private Label lblTipoMovimiento;
        private Label lblNombreMovimiento;
        private TabPage tabDeudores;
        private Label lblFechaCaja;
        private DateTimePicker dateTimeCaja;
        private TextBox txtEliminarCaja;
        private Label lblEliminarCaja;
        private TextBox txtBuscarCaja;
        private Label lblBuscarCaja;
        private Button btnBuscarCaja;
        private Button btnEliminarCaja;
        private ComboBox cbCajaMovimiento;
        private ComboBox cbCajaProducto;
        private Button btnModificarCaja;
        private TextBox txtTipoCaja;
        private Label lblMovimientoId;
        private Label lblProductoId;
        private Label lblTipoComprobante;
        private Button btnCargaCaja;
        private Button btnCancelarCaja;
        private TabPage tabInicio;
        private TabPage tabProveedor;
        private Button button2;
        private Button btRegistrarProducto;
        private Label label2;
        private Button btRegistrarVenta;
        private PictureBox pictureBox1;
    }
}
namespace Ferreteria
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProducto = new System.Windows.Forms.TabPage();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.btnCargarProducto = new System.Windows.Forms.Button();
            this.txtCategoriaProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPrecioProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.tabMovimiento = new System.Windows.Forms.TabPage();
            this.btnEliminarMovimiento = new System.Windows.Forms.Button();
            this.btnBuscarMovimiento = new System.Windows.Forms.Button();
            this.txtMedioPago = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnCancelarMovimiento = new System.Windows.Forms.Button();
            this.btnModificarMovimiento = new System.Windows.Forms.Button();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.btnCargaMovimiento = new System.Windows.Forms.Button();
            this.txtNombreMovimiento = new System.Windows.Forms.TextBox();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblNombreMovimiento = new System.Windows.Forms.Label();
            this.tabCaja = new System.Windows.Forms.TabPage();
            this.btnBuscarCaja = new System.Windows.Forms.Button();
            this.btnEliminarCaja = new System.Windows.Forms.Button();
            this.cbCajaMovimiento = new System.Windows.Forms.ComboBox();
            this.cbCajaProducto = new System.Windows.Forms.ComboBox();
            this.btnModificarCaja = new System.Windows.Forms.Button();
            this.txtTipoCaja = new System.Windows.Forms.TextBox();
            this.lblMovimientoId = new System.Windows.Forms.Label();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.btnCargaCaja = new System.Windows.Forms.Button();
            this.btnCancelarCaja = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tabMovimiento.SuspendLayout();
            this.tabCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducto);
            this.tabControl1.Controls.Add(this.tabMovimiento);
            this.tabControl1.Controls.Add(this.tabCaja);
            this.tabControl1.Location = new System.Drawing.Point(537, 17);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(594, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducto
            // 
            this.tabProducto.BackgroundImage = global::Ferreteria.Properties.Resources.ferret;
            this.tabProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabProducto.Controls.Add(this.btnBuscarProducto);
            this.tabProducto.Controls.Add(this.btnEliminarProducto);
            this.tabProducto.Controls.Add(this.btnCancelarProducto);
            this.tabProducto.Controls.Add(this.btnModificarProducto);
            this.tabProducto.Controls.Add(this.btnCargarProducto);
            this.tabProducto.Controls.Add(this.txtCategoriaProducto);
            this.tabProducto.Controls.Add(this.txtPrecioProducto);
            this.tabProducto.Controls.Add(this.txtNombreProducto);
            this.tabProducto.Controls.Add(this.lblCategoria);
            this.tabProducto.Controls.Add(this.lblPrecioProducto);
            this.tabProducto.Controls.Add(this.lblNombreProducto);
            this.tabProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabProducto.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabProducto.Location = new System.Drawing.Point(4, 27);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(4);
            this.tabProducto.Size = new System.Drawing.Size(586, 254);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Producto";
            this.tabProducto.UseVisualStyleBackColor = true;
            this.tabProducto.Click += new System.EventHandler(this.tabProducto_Click);
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarProducto.Location = new System.Drawing.Point(404, 152);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(84, 36);
            this.btnBuscarProducto.TabIndex = 30;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = false;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnEliminarProducto.Location = new System.Drawing.Point(458, 94);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(84, 36);
            this.btnEliminarProducto.TabIndex = 29;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnCancelarProducto.Location = new System.Drawing.Point(348, 94);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(84, 36);
            this.btnCancelarProducto.TabIndex = 27;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnModificarProducto.Location = new System.Drawing.Point(458, 34);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(84, 39);
            this.btnModificarProducto.TabIndex = 24;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.BackColor = System.Drawing.Color.Gold;
            this.btnCargarProducto.Location = new System.Drawing.Point(348, 35);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(84, 36);
            this.btnCargarProducto.TabIndex = 28;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = false;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargaProducto_Click);
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Location = new System.Drawing.Point(147, 43);
            this.txtCategoriaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(176, 27);
            this.txtCategoriaProducto.TabIndex = 6;
            this.txtCategoriaProducto.TextChanged += new System.EventHandler(this.txtCategoriaProducto_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(146, 157);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(176, 27);
            this.txtPrecioProducto.TabIndex = 5;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(147, 99);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(176, 27);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.BackColor = System.Drawing.Color.Wheat;
            this.lblCategoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCategoria.Location = new System.Drawing.Point(39, 46);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(76, 20);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.BackColor = System.Drawing.Color.Wheat;
            this.lblPrecioProducto.Location = new System.Drawing.Point(49, 160);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(52, 20);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "Precio";
            this.lblPrecioProducto.Click += new System.EventHandler(this.lblPrecioProducto_Click);
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.BackColor = System.Drawing.Color.Wheat;
            this.lblNombreProducto.Location = new System.Drawing.Point(8, 102);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(135, 20);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // tabMovimiento
            // 
            this.tabMovimiento.BackgroundImage = global::Ferreteria.Properties.Resources.ferret;
            this.tabMovimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMovimiento.Controls.Add(this.btnEliminarMovimiento);
            this.tabMovimiento.Controls.Add(this.btnBuscarMovimiento);
            this.tabMovimiento.Controls.Add(this.txtMedioPago);
            this.tabMovimiento.Controls.Add(this.txtApellidoCliente);
            this.tabMovimiento.Controls.Add(this.btnCancelarMovimiento);
            this.tabMovimiento.Controls.Add(this.btnModificarMovimiento);
            this.tabMovimiento.Controls.Add(this.lblMovimiento);
            this.tabMovimiento.Controls.Add(this.btnCargaMovimiento);
            this.tabMovimiento.Controls.Add(this.txtNombreMovimiento);
            this.tabMovimiento.Controls.Add(this.lblTipoMovimiento);
            this.tabMovimiento.Controls.Add(this.lblNombreMovimiento);
            this.tabMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabMovimiento.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabMovimiento.Location = new System.Drawing.Point(4, 24);
            this.tabMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Size = new System.Drawing.Size(586, 257);
            this.tabMovimiento.TabIndex = 1;
            this.tabMovimiento.Text = "Movimiento";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            this.tabMovimiento.Click += new System.EventHandler(this.tabMovimiento_Click_1);
            // 
            // btnEliminarMovimiento
            // 
            this.btnEliminarMovimiento.BackColor = System.Drawing.Color.Gold;
            this.btnEliminarMovimiento.Location = new System.Drawing.Point(408, 152);
            this.btnEliminarMovimiento.Name = "btnEliminarMovimiento";
            this.btnEliminarMovimiento.Size = new System.Drawing.Size(84, 31);
            this.btnEliminarMovimiento.TabIndex = 30;
            this.btnEliminarMovimiento.Text = "Eliminar";
            this.btnEliminarMovimiento.UseVisualStyleBackColor = false;
            this.btnEliminarMovimiento.Click += new System.EventHandler(this.btnEliminarMovimiento_Click);
            // 
            // btnBuscarMovimiento
            // 
            this.btnBuscarMovimiento.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarMovimiento.Location = new System.Drawing.Point(471, 37);
            this.btnBuscarMovimiento.Name = "btnBuscarMovimiento";
            this.btnBuscarMovimiento.Size = new System.Drawing.Size(84, 31);
            this.btnBuscarMovimiento.TabIndex = 29;
            this.btnBuscarMovimiento.Text = "Buscar";
            this.btnBuscarMovimiento.UseVisualStyleBackColor = false;
            this.btnBuscarMovimiento.Click += new System.EventHandler(this.btnBuscarMovimiento_Click);
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Location = new System.Drawing.Point(171, 149);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(132, 27);
            this.txtMedioPago.TabIndex = 28;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(171, 106);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(132, 27);
            this.txtApellidoCliente.TabIndex = 27;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            // 
            // btnCancelarMovimiento
            // 
            this.btnCancelarMovimiento.BackColor = System.Drawing.Color.Gold;
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(353, 101);
            this.btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(84, 31);
            this.btnCancelarMovimiento.TabIndex = 26;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = false;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.btnCancelarMovimiento_Click);
            // 
            // btnModificarMovimiento
            // 
            this.btnModificarMovimiento.BackColor = System.Drawing.Color.Gold;
            this.btnModificarMovimiento.Location = new System.Drawing.Point(471, 99);
            this.btnModificarMovimiento.Name = "btnModificarMovimiento";
            this.btnModificarMovimiento.Size = new System.Drawing.Size(84, 33);
            this.btnModificarMovimiento.TabIndex = 25;
            this.btnModificarMovimiento.Text = "Modificar";
            this.btnModificarMovimiento.UseVisualStyleBackColor = false;
            this.btnModificarMovimiento.Click += new System.EventHandler(this.btnModificarMovimiento_Click);
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.BackColor = System.Drawing.Color.Wheat;
            this.lblMovimiento.Location = new System.Drawing.Point(26, 152);
            this.lblMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(113, 20);
            this.lblMovimiento.TabIndex = 22;
            this.lblMovimiento.Text = "Medio de Pago";
            // 
            // btnCargaMovimiento
            // 
            this.btnCargaMovimiento.BackColor = System.Drawing.Color.Gold;
            this.btnCargaMovimiento.Location = new System.Drawing.Point(353, 37);
            this.btnCargaMovimiento.Name = "btnCargaMovimiento";
            this.btnCargaMovimiento.Size = new System.Drawing.Size(84, 31);
            this.btnCargaMovimiento.TabIndex = 17;
            this.btnCargaMovimiento.Text = "Cargar";
            this.btnCargaMovimiento.UseVisualStyleBackColor = false;
            this.btnCargaMovimiento.Click += new System.EventHandler(this.btnCargaMovimiento_Click);
            // 
            // txtNombreMovimiento
            // 
            this.txtNombreMovimiento.Location = new System.Drawing.Point(171, 60);
            this.txtNombreMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMovimiento.Name = "txtNombreMovimiento";
            this.txtNombreMovimiento.Size = new System.Drawing.Size(132, 27);
            this.txtNombreMovimiento.TabIndex = 13;
            this.txtNombreMovimiento.TextChanged += new System.EventHandler(this.txtNombreMovimiento_TextChanged);
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.BackColor = System.Drawing.Color.Wheat;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(26, 106);
            this.lblTipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(119, 20);
            this.lblTipoMovimiento.TabIndex = 10;
            this.lblTipoMovimiento.Text = "Apellido Cliente";
            // 
            // lblNombreMovimiento
            // 
            this.lblNombreMovimiento.AutoSize = true;
            this.lblNombreMovimiento.BackColor = System.Drawing.Color.Wheat;
            this.lblNombreMovimiento.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreMovimiento.Location = new System.Drawing.Point(26, 60);
            this.lblNombreMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMovimiento.Name = "lblNombreMovimiento";
            this.lblNombreMovimiento.Size = new System.Drawing.Size(119, 20);
            this.lblNombreMovimiento.TabIndex = 9;
            this.lblNombreMovimiento.Text = "Nombre Cliente";
            // 
            // tabCaja
            // 
            this.tabCaja.BackgroundImage = global::Ferreteria.Properties.Resources.ferret;
            this.tabCaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabCaja.Controls.Add(this.btnBuscarCaja);
            this.tabCaja.Controls.Add(this.btnEliminarCaja);
            this.tabCaja.Controls.Add(this.cbCajaMovimiento);
            this.tabCaja.Controls.Add(this.cbCajaProducto);
            this.tabCaja.Controls.Add(this.btnModificarCaja);
            this.tabCaja.Controls.Add(this.txtTipoCaja);
            this.tabCaja.Controls.Add(this.lblMovimientoId);
            this.tabCaja.Controls.Add(this.lblProductoId);
            this.tabCaja.Controls.Add(this.lblTipoComprobante);
            this.tabCaja.Controls.Add(this.btnCargaCaja);
            this.tabCaja.Controls.Add(this.btnCancelarCaja);
            this.tabCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabCaja.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabCaja.Location = new System.Drawing.Point(4, 27);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(586, 254);
            this.tabCaja.TabIndex = 2;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            this.tabCaja.Click += new System.EventHandler(this.tabCaja_Click);
            // 
            // btnBuscarCaja
            // 
            this.btnBuscarCaja.BackColor = System.Drawing.Color.Gold;
            this.btnBuscarCaja.Location = new System.Drawing.Point(444, 153);
            this.btnBuscarCaja.Name = "btnBuscarCaja";
            this.btnBuscarCaja.Size = new System.Drawing.Size(84, 36);
            this.btnBuscarCaja.TabIndex = 31;
            this.btnBuscarCaja.Text = "Buscar";
            this.btnBuscarCaja.UseVisualStyleBackColor = false;
            this.btnBuscarCaja.Click += new System.EventHandler(this.btnBuscarCaja_Click);
            // 
            // btnEliminarCaja
            // 
            this.btnEliminarCaja.BackColor = System.Drawing.Color.Gold;
            this.btnEliminarCaja.Location = new System.Drawing.Point(398, 42);
            this.btnEliminarCaja.Name = "btnEliminarCaja";
            this.btnEliminarCaja.Size = new System.Drawing.Size(84, 36);
            this.btnEliminarCaja.TabIndex = 30;
            this.btnEliminarCaja.Text = "Eliminar";
            this.btnEliminarCaja.UseVisualStyleBackColor = false;
            this.btnEliminarCaja.Click += new System.EventHandler(this.btnEliminarCaja_Click);
            // 
            // cbCajaMovimiento
            // 
            this.cbCajaMovimiento.FormattingEnabled = true;
            this.cbCajaMovimiento.Location = new System.Drawing.Point(137, 115);
            this.cbCajaMovimiento.Name = "cbCajaMovimiento";
            this.cbCajaMovimiento.Size = new System.Drawing.Size(231, 28);
            this.cbCajaMovimiento.TabIndex = 12;
            this.cbCajaMovimiento.SelectedIndexChanged += new System.EventHandler(this.cbCajaMovimiento_SelectedIndexChanged);
            // 
            // cbCajaProducto
            // 
            this.cbCajaProducto.FormattingEnabled = true;
            this.cbCajaProducto.Location = new System.Drawing.Point(137, 74);
            this.cbCajaProducto.Name = "cbCajaProducto";
            this.cbCajaProducto.Size = new System.Drawing.Size(231, 28);
            this.cbCajaProducto.TabIndex = 11;
            this.cbCajaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCajaProducto_SelectedIndexChanged);
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.BackColor = System.Drawing.Color.Gold;
            this.btnModificarCaja.Location = new System.Drawing.Point(488, 45);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(88, 31);
            this.btnModificarCaja.TabIndex = 20;
            this.btnModificarCaja.Text = "Modificar";
            this.btnModificarCaja.UseVisualStyleBackColor = false;
            this.btnModificarCaja.Click += new System.EventHandler(this.btnModificarCaja_Click);
            // 
            // txtTipoCaja
            // 
            this.txtTipoCaja.Location = new System.Drawing.Point(190, 26);
            this.txtTipoCaja.Name = "txtTipoCaja";
            this.txtTipoCaja.Size = new System.Drawing.Size(147, 27);
            this.txtTipoCaja.TabIndex = 6;
            // 
            // lblMovimientoId
            // 
            this.lblMovimientoId.AutoSize = true;
            this.lblMovimientoId.BackColor = System.Drawing.Color.Wheat;
            this.lblMovimientoId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMovimientoId.Location = new System.Drawing.Point(27, 118);
            this.lblMovimientoId.Name = "lblMovimientoId";
            this.lblMovimientoId.Size = new System.Drawing.Size(94, 20);
            this.lblMovimientoId.TabIndex = 4;
            this.lblMovimientoId.Text = "Movimiento";
            this.lblMovimientoId.Click += new System.EventHandler(this.lblMovimientoId_Click);
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.BackColor = System.Drawing.Color.Wheat;
            this.lblProductoId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProductoId.Location = new System.Drawing.Point(27, 77);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(73, 20);
            this.lblProductoId.TabIndex = 3;
            this.lblProductoId.Text = "Producto";
            this.lblProductoId.Click += new System.EventHandler(this.lblProductoId_Click);
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.BackColor = System.Drawing.Color.Wheat;
            this.lblTipoComprobante.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTipoComprobante.Location = new System.Drawing.Point(6, 29);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(140, 20);
            this.lblTipoComprobante.TabIndex = 2;
            this.lblTipoComprobante.Text = "Tipo Comprobante";
            // 
            // btnCargaCaja
            // 
            this.btnCargaCaja.BackColor = System.Drawing.Color.Gold;
            this.btnCargaCaja.Location = new System.Drawing.Point(398, 96);
            this.btnCargaCaja.Name = "btnCargaCaja";
            this.btnCargaCaja.Size = new System.Drawing.Size(75, 31);
            this.btnCargaCaja.TabIndex = 1;
            this.btnCargaCaja.Text = "Cargar";
            this.btnCargaCaja.UseVisualStyleBackColor = false;
            this.btnCargaCaja.Click += new System.EventHandler(this.btnCargaCaja_Click);
            // 
            // btnCancelarCaja
            // 
            this.btnCancelarCaja.AccessibleRole = System.Windows.Forms.AccessibleRole.Sound;
            this.btnCancelarCaja.BackColor = System.Drawing.Color.Gold;
            this.btnCancelarCaja.Location = new System.Drawing.Point(488, 96);
            this.btnCancelarCaja.Name = "btnCancelarCaja";
            this.btnCancelarCaja.Size = new System.Drawing.Size(84, 31);
            this.btnCancelarCaja.TabIndex = 0;
            this.btnCancelarCaja.Text = "Cancelar";
            this.btnCancelarCaja.UseVisualStyleBackColor = false;
            this.btnCancelarCaja.Click += new System.EventHandler(this.btnCancelarCaja_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvProducto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProducto.Location = new System.Drawing.Point(12, 44);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(490, 251);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick_1);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMovimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMovimiento.Location = new System.Drawing.Point(12, 350);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.Size = new System.Drawing.Size(517, 251);
            this.dgvMovimiento.TabIndex = 3;
            this.dgvMovimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellClick);
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellContentClick);
            // 
            // dgvCaja
            // 
            this.dgvCaja.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvCaja.Location = new System.Drawing.Point(580, 350);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowTemplate.Height = 25;
            this.dgvCaja.Size = new System.Drawing.Size(527, 251);
            this.dgvCaja.TabIndex = 4;
            this.dgvCaja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_CellClick);
            this.dgvCaja.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCaja_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(211, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "MOVIMIENTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(820, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "CAJA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCaja);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.tabControl1.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            this.tabMovimiento.ResumeLayout(false);
            this.tabMovimiento.PerformLayout();
            this.tabCaja.ResumeLayout(false);
            this.tabCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}


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
            this.tabControl1.Size = new System.Drawing.Size(561, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProducto
            // 
            this.tabProducto.Controls.Add(this.btnCancelarProducto);
            this.tabProducto.Controls.Add(this.btnModificarProducto);
            this.tabProducto.Controls.Add(this.btnCargarProducto);
            this.tabProducto.Controls.Add(this.txtCategoriaProducto);
            this.tabProducto.Controls.Add(this.txtPrecioProducto);
            this.tabProducto.Controls.Add(this.txtNombreProducto);
            this.tabProducto.Controls.Add(this.lblCategoria);
            this.tabProducto.Controls.Add(this.lblPrecioProducto);
            this.tabProducto.Controls.Add(this.lblNombreProducto);
            this.tabProducto.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabProducto.Location = new System.Drawing.Point(4, 27);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProducto.Name = "tabProducto";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(4);
            this.tabProducto.Size = new System.Drawing.Size(553, 238);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Producto";
            this.tabProducto.UseVisualStyleBackColor = true;
            this.tabProducto.Click += new System.EventHandler(this.tabProducto_Click);
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(387, 77);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(79, 33);
            this.btnCancelarProducto.TabIndex = 27;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(387, 122);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(84, 30);
            this.btnModificarProducto.TabIndex = 24;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(387, 21);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(75, 36);
            this.btnCargarProducto.TabIndex = 28;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargaProducto_Click);
            // 
            // txtCategoriaProducto
            // 
            this.txtCategoriaProducto.Location = new System.Drawing.Point(146, 36);
            this.txtCategoriaProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategoriaProducto.Name = "txtCategoriaProducto";
            this.txtCategoriaProducto.Size = new System.Drawing.Size(176, 26);
            this.txtCategoriaProducto.TabIndex = 6;
            this.txtCategoriaProducto.TextChanged += new System.EventHandler(this.txtCategoriaProducto_TextChanged);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(146, 119);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(176, 26);
            this.txtPrecioProducto.TabIndex = 5;
            this.txtPrecioProducto.TextChanged += new System.EventHandler(this.txtPrecioProducto_TextChanged);
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(146, 74);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(176, 26);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.TextChanged += new System.EventHandler(this.txtNombreProducto_TextChanged);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(26, 39);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(67, 18);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            this.lblCategoria.Click += new System.EventHandler(this.lblCategoria_Click);
            // 
            // lblPrecioProducto
            // 
            this.lblPrecioProducto.AutoSize = true;
            this.lblPrecioProducto.Location = new System.Drawing.Point(26, 122);
            this.lblPrecioProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecioProducto.Name = "lblPrecioProducto";
            this.lblPrecioProducto.Size = new System.Drawing.Size(47, 18);
            this.lblPrecioProducto.TabIndex = 1;
            this.lblPrecioProducto.Text = "Precio";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(24, 77);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(119, 18);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre Producto";
            // 
            // tabMovimiento
            // 
            this.tabMovimiento.Controls.Add(this.txtMedioPago);
            this.tabMovimiento.Controls.Add(this.txtApellidoCliente);
            this.tabMovimiento.Controls.Add(this.btnCancelarMovimiento);
            this.tabMovimiento.Controls.Add(this.btnModificarMovimiento);
            this.tabMovimiento.Controls.Add(this.lblMovimiento);
            this.tabMovimiento.Controls.Add(this.btnCargaMovimiento);
            this.tabMovimiento.Controls.Add(this.txtNombreMovimiento);
            this.tabMovimiento.Controls.Add(this.lblTipoMovimiento);
            this.tabMovimiento.Controls.Add(this.lblNombreMovimiento);
            this.tabMovimiento.Location = new System.Drawing.Point(4, 24);
            this.tabMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Size = new System.Drawing.Size(553, 241);
            this.tabMovimiento.TabIndex = 1;
            this.tabMovimiento.Text = "Movimiento";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            this.tabMovimiento.Click += new System.EventHandler(this.tabMovimiento_Click_1);
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Location = new System.Drawing.Point(171, 149);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(132, 26);
            this.txtMedioPago.TabIndex = 28;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(171, 106);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(132, 26);
            this.txtApellidoCliente.TabIndex = 27;
            this.txtApellidoCliente.TextChanged += new System.EventHandler(this.txtApellidoCliente_TextChanged);
            // 
            // btnCancelarMovimiento
            // 
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(398, 101);
            this.btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(75, 31);
            this.btnCancelarMovimiento.TabIndex = 26;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = true;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.btnCancelarMovimiento_Click);
            // 
            // btnModificarMovimiento
            // 
            this.btnModificarMovimiento.Location = new System.Drawing.Point(398, 152);
            this.btnModificarMovimiento.Name = "btnModificarMovimiento";
            this.btnModificarMovimiento.Size = new System.Drawing.Size(84, 33);
            this.btnModificarMovimiento.TabIndex = 25;
            this.btnModificarMovimiento.Text = "Modificar";
            this.btnModificarMovimiento.UseVisualStyleBackColor = true;
            this.btnModificarMovimiento.Click += new System.EventHandler(this.btnModificarMovimiento_Click);
            // 
            // lblMovimiento
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(26, 152);
            this.lblMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovimiento.Name = "lblMovimiento";
            this.lblMovimiento.Size = new System.Drawing.Size(99, 18);
            this.lblMovimiento.TabIndex = 22;
            this.lblMovimiento.Text = "Medio de Pago";
            // 
            // btnCargaMovimiento
            // 
            this.btnCargaMovimiento.Location = new System.Drawing.Point(398, 37);
            this.btnCargaMovimiento.Name = "btnCargaMovimiento";
            this.btnCargaMovimiento.Size = new System.Drawing.Size(84, 31);
            this.btnCargaMovimiento.TabIndex = 17;
            this.btnCargaMovimiento.Text = "Cargar";
            this.btnCargaMovimiento.UseVisualStyleBackColor = true;
            this.btnCargaMovimiento.Click += new System.EventHandler(this.btnCargaMovimiento_Click);
            // 
            // txtNombreMovimiento
            // 
            this.txtNombreMovimiento.Location = new System.Drawing.Point(171, 60);
            this.txtNombreMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMovimiento.Name = "txtNombreMovimiento";
            this.txtNombreMovimiento.Size = new System.Drawing.Size(132, 26);
            this.txtNombreMovimiento.TabIndex = 13;
            this.txtNombreMovimiento.TextChanged += new System.EventHandler(this.txtNombreMovimiento_TextChanged);
            // 
            // lblTipoMovimiento
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(26, 106);
            this.lblTipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMovimiento.Name = "lblTipoMovimiento";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(102, 18);
            this.lblTipoMovimiento.TabIndex = 10;
            this.lblTipoMovimiento.Text = "Apellido Cliente";
            // 
            // lblNombreMovimiento
            // 
            this.lblNombreMovimiento.AutoSize = true;
            this.lblNombreMovimiento.Location = new System.Drawing.Point(26, 60);
            this.lblNombreMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMovimiento.Name = "lblNombreMovimiento";
            this.lblNombreMovimiento.Size = new System.Drawing.Size(102, 18);
            this.lblNombreMovimiento.TabIndex = 9;
            this.lblNombreMovimiento.Text = "Nombre Cliente";
            // 
            // tabCaja
            // 
            this.tabCaja.Controls.Add(this.cbCajaMovimiento);
            this.tabCaja.Controls.Add(this.cbCajaProducto);
            this.tabCaja.Controls.Add(this.btnModificarCaja);
            this.tabCaja.Controls.Add(this.txtTipoCaja);
            this.tabCaja.Controls.Add(this.lblMovimientoId);
            this.tabCaja.Controls.Add(this.lblProductoId);
            this.tabCaja.Controls.Add(this.lblTipoComprobante);
            this.tabCaja.Controls.Add(this.btnCargaCaja);
            this.tabCaja.Controls.Add(this.btnCancelarCaja);
            this.tabCaja.Location = new System.Drawing.Point(4, 24);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(553, 241);
            this.tabCaja.TabIndex = 2;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            this.tabCaja.Click += new System.EventHandler(this.tabCaja_Click);
            // 
            // cbCajaMovimiento
            // 
            this.cbCajaMovimiento.FormattingEnabled = true;
            this.cbCajaMovimiento.Location = new System.Drawing.Point(137, 115);
            this.cbCajaMovimiento.Name = "cbCajaMovimiento";
            this.cbCajaMovimiento.Size = new System.Drawing.Size(231, 26);
            this.cbCajaMovimiento.TabIndex = 12;
            this.cbCajaMovimiento.SelectedIndexChanged += new System.EventHandler(this.cbCajaMovimiento_SelectedIndexChanged);
            // 
            // cbCajaProducto
            // 
            this.cbCajaProducto.FormattingEnabled = true;
            this.cbCajaProducto.Location = new System.Drawing.Point(137, 74);
            this.cbCajaProducto.Name = "cbCajaProducto";
            this.cbCajaProducto.Size = new System.Drawing.Size(231, 26);
            this.cbCajaProducto.TabIndex = 11;
            this.cbCajaProducto.SelectedIndexChanged += new System.EventHandler(this.cbCajaProducto_SelectedIndexChanged);
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.Location = new System.Drawing.Point(407, 29);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(75, 31);
            this.btnModificarCaja.TabIndex = 20;
            this.btnModificarCaja.Text = "Modificar";
            this.btnModificarCaja.UseVisualStyleBackColor = true;
            this.btnModificarCaja.Click += new System.EventHandler(this.btnModificarCaja_Click);
            // 
            // txtTipoCaja
            // 
            this.txtTipoCaja.Location = new System.Drawing.Point(148, 26);
            this.txtTipoCaja.Name = "txtTipoCaja";
            this.txtTipoCaja.Size = new System.Drawing.Size(106, 26);
            this.txtTipoCaja.TabIndex = 6;
            // 
            // lblMovimientoId
            // 
            this.lblMovimientoId.AutoSize = true;
            this.lblMovimientoId.Location = new System.Drawing.Point(27, 118);
            this.lblMovimientoId.Name = "lblMovimientoId";
            this.lblMovimientoId.Size = new System.Drawing.Size(81, 18);
            this.lblMovimientoId.TabIndex = 4;
            this.lblMovimientoId.Text = "Movimiento";
            this.lblMovimientoId.Click += new System.EventHandler(this.lblMovimientoId_Click);
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Location = new System.Drawing.Point(27, 77);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(66, 18);
            this.lblProductoId.TabIndex = 3;
            this.lblProductoId.Text = "Producto";
            this.lblProductoId.Click += new System.EventHandler(this.lblProductoId_Click);
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(6, 29);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(122, 18);
            this.lblTipoComprobante.TabIndex = 2;
            this.lblTipoComprobante.Text = "Tipo Comprobante";
            // 
            // btnCargaCaja
            // 
            this.btnCargaCaja.Location = new System.Drawing.Point(359, 172);
            this.btnCargaCaja.Name = "btnCargaCaja";
            this.btnCargaCaja.Size = new System.Drawing.Size(75, 31);
            this.btnCargaCaja.TabIndex = 1;
            this.btnCargaCaja.Text = "Cargar";
            this.btnCargaCaja.UseVisualStyleBackColor = true;
            this.btnCargaCaja.Click += new System.EventHandler(this.btnCargaCaja_Click);
            // 
            // btnCancelarCaja
            // 
            this.btnCancelarCaja.Location = new System.Drawing.Point(456, 172);
            this.btnCancelarCaja.Name = "btnCancelarCaja";
            this.btnCancelarCaja.Size = new System.Drawing.Size(75, 31);
            this.btnCancelarCaja.TabIndex = 0;
            this.btnCancelarCaja.Text = "Cancelar";
            this.btnCancelarCaja.UseVisualStyleBackColor = true;
            this.btnCancelarCaja.Click += new System.EventHandler(this.btnCancelarCaja_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 44);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(490, 251);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick_1);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(12, 350);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.Size = new System.Drawing.Size(517, 251);
            this.dgvMovimiento.TabIndex = 3;
            this.dgvMovimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellClick);
            this.dgvMovimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellContentClick);
            // 
            // dgvCaja
            // 
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
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
            this.label1.Location = new System.Drawing.Point(211, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(211, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "MOVIMIENTOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(820, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "CAJA";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 832);
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
    }
}


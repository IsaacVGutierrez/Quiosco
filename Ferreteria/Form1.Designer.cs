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
            this.btnModificarCaja = new System.Windows.Forms.Button();
            this.txtMovimientoId = new System.Windows.Forms.TextBox();
            this.txtProductoId = new System.Windows.Forms.TextBox();
            this.txtTipoCaja = new System.Windows.Forms.TextBox();
            this.lblMovimientoId = new System.Windows.Forms.Label();
            this.lblProductoId = new System.Windows.Forms.Label();
            this.lblTipoComprobante = new System.Windows.Forms.Label();
            this.btnCargaCaja = new System.Windows.Forms.Button();
            this.btnCancelarCaja = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.dgvCaja = new System.Windows.Forms.DataGridView();
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
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(329, 77);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(79, 26);
            this.btnCancelarProducto.TabIndex = 27;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Visible = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(324, 141);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(84, 26);
            this.btnModificarProducto.TabIndex = 24;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Visible = true;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
            // 
            // btnCargarProducto
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(329, 16);
            this.btnCargarProducto.Name = "btnCargarProducto";
            this.btnCargarProducto.Size = new System.Drawing.Size(75, 32);
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
            this.txtCategoriaProducto.Size = new System.Drawing.Size(132, 26);
            this.txtCategoriaProducto.TabIndex = 6;
            this.txtCategoriaProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCategoriaProducto_KeyPress);
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(146, 119);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(132, 26);
            this.txtPrecioProducto.TabIndex = 5;
            this.txtPrecioProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioProducto_KeyPress);
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(146, 74);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 26);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreProducto_KeyPress);
            // 
            // lblCategoriaProducto
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
            this.tabMovimiento.Location = new System.Drawing.Point(4, 27);
            this.tabMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Name = "tabMovimiento";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Size = new System.Drawing.Size(553, 238);
            this.tabMovimiento.TabIndex = 1;
            this.tabMovimiento.Text = "Movimiento";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Location = new System.Drawing.Point(171, 149);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(100, 26);
            this.txtMedioPago.TabIndex = 28;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(171, 106);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(100, 26);
            this.txtApellidoCliente.TabIndex = 27;
            // 
            // btnCancelarMovimiento
            // 
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(341, 36);
            this.btnCancelarMovimiento.Name = "btnCancelarMovimiento";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarMovimiento.TabIndex = 26;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = true;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnModificarMovimiento
            // 
            this.btnModificarMovimiento.Location = new System.Drawing.Point(341, 98);
            this.btnModificarMovimiento.Name = "btnModificarMovimiento";
            this.btnModificarMovimiento.Size = new System.Drawing.Size(84, 26);
            this.btnModificarMovimiento.TabIndex = 25;
            this.btnModificarMovimiento.Text = "Modificar";
            this.btnModificarMovimiento.UseVisualStyleBackColor = true;
            this.btnModificarMovimiento.Visible = true;
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
            this.btnCargaMovimiento.Location = new System.Drawing.Point(341, 152);
            this.btnCargaMovimiento.Name = "btnCargaMovimiento";
            this.btnCargaMovimiento.Size = new System.Drawing.Size(84, 26);
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
            this.txtNombreMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMovimiento_KeyPress);
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
            this.tabCaja.Controls.Add(this.btnModificarCaja);
            this.tabCaja.Controls.Add(this.txtMovimientoId);
            this.tabCaja.Controls.Add(this.txtProductoId);
            this.tabCaja.Controls.Add(this.txtTipoCaja);
            this.tabCaja.Controls.Add(this.lblMovimientoId);
            this.tabCaja.Controls.Add(this.lblProductoId);
            this.tabCaja.Controls.Add(this.lblTipoComprobante);
            this.tabCaja.Controls.Add(this.btnCargaCaja);
            this.tabCaja.Controls.Add(this.btnCancelarCaja);
            this.tabCaja.Location = new System.Drawing.Point(4, 27);
            this.tabCaja.Name = "tabCaja";
            this.tabCaja.Padding = new System.Windows.Forms.Padding(3);
            this.tabCaja.Size = new System.Drawing.Size(553, 238);
            this.tabCaja.TabIndex = 2;
            this.tabCaja.Text = "Caja";
            this.tabCaja.UseVisualStyleBackColor = true;
            // 
            // btnModificarCaja
            // 
            this.btnModificarCaja.Location = new System.Drawing.Point(313, 27);
            this.btnModificarCaja.Name = "btnModificarCaja";
            this.btnModificarCaja.Size = new System.Drawing.Size(75, 23);
            this.btnModificarCaja.TabIndex = 10;
            this.btnModificarCaja.Text = "Modificar";
            this.btnModificarCaja.UseVisualStyleBackColor = true;
            // 
            // txtMovimientoId
            // 
            this.txtMovimientoId.Location = new System.Drawing.Point(184, 110);
            this.txtMovimientoId.Name = "txtMovimientoId";
            this.txtMovimientoId.Size = new System.Drawing.Size(100, 26);
            this.txtMovimientoId.TabIndex = 8;
            // 
            // txtProductoId
            // 
            this.txtProductoId.Location = new System.Drawing.Point(184, 74);
            this.txtProductoId.Name = "txtProductoId";
            this.txtProductoId.Size = new System.Drawing.Size(100, 26);
            this.txtProductoId.TabIndex = 7;
            this.txtProductoId.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTipoCaja
            // 
            this.txtTipoCaja.Location = new System.Drawing.Point(196, 32);
            this.txtTipoCaja.Name = "txtTipoCaja";
            this.txtTipoCaja.Size = new System.Drawing.Size(100, 26);
            this.txtTipoCaja.TabIndex = 6;
            // 
            // lblMovimientoId
            // 
            this.lblMovimientoId.AutoSize = true;
            this.lblMovimientoId.Location = new System.Drawing.Point(39, 113);
            this.lblMovimientoId.Name = "lblMovimientoId";
            this.lblMovimientoId.Size = new System.Drawing.Size(81, 18);
            this.lblMovimientoId.TabIndex = 4;
            this.lblMovimientoId.Text = "Movimiento";
            // 
            // lblProductoId
            // 
            this.lblProductoId.AutoSize = true;
            this.lblProductoId.Location = new System.Drawing.Point(44, 77);
            this.lblProductoId.Name = "lblProductoId";
            this.lblProductoId.Size = new System.Drawing.Size(66, 18);
            this.lblProductoId.TabIndex = 3;
            this.lblProductoId.Text = "Producto";
            // 
            // lblTipoComprobante
            // 
            this.lblTipoComprobante.AutoSize = true;
            this.lblTipoComprobante.Location = new System.Drawing.Point(27, 32);
            this.lblTipoComprobante.Name = "lblTipoComprobante";
            this.lblTipoComprobante.Size = new System.Drawing.Size(122, 18);
            this.lblTipoComprobante.TabIndex = 2;
            this.lblTipoComprobante.Text = "Tipo Comprobante";
            // 
            // btnCargaCaja
            // 
            this.btnCargaCaja.Location = new System.Drawing.Point(313, 113);
            this.btnCargaCaja.Name = "btnCargaCaja";
            this.btnCargaCaja.Size = new System.Drawing.Size(75, 31);
            this.btnCargaCaja.TabIndex = 1;
            this.btnCargaCaja.Text = "Cargar";
            this.btnCargaCaja.UseVisualStyleBackColor = true;
            // 
            // btnCancelarCaja
            // 
            this.btnCancelarCaja.Location = new System.Drawing.Point(313, 74);
            this.btnCancelarCaja.Name = "btnCancelarCaja";
            this.btnCancelarCaja.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarCaja.TabIndex = 0;
            this.btnCancelarCaja.Text = "Cancelar";
            this.btnCancelarCaja.UseVisualStyleBackColor = true;
            this.btnCancelarCaja.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(12, 17);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(475, 251);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellClick_1);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducto_CellContentClick);
            // 
            // dgvMovimiento
            // 
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(21, 317);
            this.dgvMovimiento.Name = "dgvMovimiento";
            this.dgvMovimiento.Size = new System.Drawing.Size(483, 251);
            this.dgvMovimiento.TabIndex = 3;
            this.dgvMovimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMovimiento_CellClick);
            // 
            // dgvCaja
            // 
            this.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCaja.Location = new System.Drawing.Point(537, 317);
            this.dgvCaja.Name = "dgvCaja";
            this.dgvCaja.RowTemplate.Height = 25;
            this.dgvCaja.Size = new System.Drawing.Size(372, 251);
            this.dgvCaja.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 832);
            this.Controls.Add(this.dgvCaja);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
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

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.TextBox txtCategoriaProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPrecioProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TabPage tabMovimiento;
        private Button btnCargaMovimiento;
        private System.Windows.Forms.TextBox txtNombreMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblNombreMovimiento;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private Button btnModificarMovimiento;
        private Button btnCancelarProducto;
        private TabPage tabCaja;
        private TextBox txtMovimientoId;
        private TextBox txtProductoId;
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
    }
}


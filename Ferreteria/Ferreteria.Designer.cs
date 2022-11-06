namespace Ferreteria
{
    partial class Ferreteria
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
            this.dgCajaValoresRelacionados = new System.Windows.Forms.DataGridView();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMediospago = new System.Windows.Forms.Label();
            this.cmbProductoCategoria = new System.Windows.Forms.ComboBox();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.txtNombProd = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgCajaValoresRelacionados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCajaValoresRelacionados
            // 
            this.dgCajaValoresRelacionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCajaValoresRelacionados.Location = new System.Drawing.Point(22, 285);
            this.dgCajaValoresRelacionados.Name = "dgCajaValoresRelacionados";
            this.dgCajaValoresRelacionados.RowTemplate.Height = 25;
            this.dgCajaValoresRelacionados.Size = new System.Drawing.Size(826, 225);
            this.dgCajaValoresRelacionados.TabIndex = 0;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(212, 74);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 23);
            this.txtprecio.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(212, 105);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 5;
            // 
            // btAgregar
            // 
            this.btAgregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btAgregar.ForeColor = System.Drawing.Color.Blue;
            this.btAgregar.Location = new System.Drawing.Point(355, 238);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(101, 41);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Precio";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(38, 113);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(108, 15);
            this.lblNombreCliente.TabIndex = 9;
            this.lblNombreCliente.Text = "Nombre del cliente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(337, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 32);
            this.label4.TabIndex = 11;
            this.label4.Text = "Productos";
            // 
            // lblcategoria
            // 
            this.lblcategoria.AutoSize = true;
            this.lblcategoria.Location = new System.Drawing.Point(494, 113);
            this.lblcategoria.Name = "lblcategoria";
            this.lblcategoria.Size = new System.Drawing.Size(58, 15);
            this.lblcategoria.TabIndex = 14;
            this.lblcategoria.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(494, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comprobante";
            // 
            // lblMediospago
            // 
            this.lblMediospago.AutoSize = true;
            this.lblMediospago.Location = new System.Drawing.Point(268, 192);
            this.lblMediospago.Name = "lblMediospago";
            this.lblMediospago.Size = new System.Drawing.Size(92, 15);
            this.lblMediospago.TabIndex = 16;
            this.lblMediospago.Text = "Medios de pago";
            // 
            // cmbProductoCategoria
            // 
            this.cmbProductoCategoria.FormattingEnabled = true;
            this.cmbProductoCategoria.Location = new System.Drawing.Point(668, 105);
            this.cmbProductoCategoria.Name = "cmbProductoCategoria";
            this.cmbProductoCategoria.Size = new System.Drawing.Size(100, 23);
            this.cmbProductoCategoria.TabIndex = 17;
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Location = new System.Drawing.Point(668, 140);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(100, 23);
            this.cmbComprobante.TabIndex = 18;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(442, 184);
            this.cmbMedioPago.Name = "cmbMedioPago";
            this.cmbMedioPago.Size = new System.Drawing.Size(100, 23);
            this.cmbMedioPago.TabIndex = 19;
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(494, 82);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(103, 15);
            this.lblNombreProd.TabIndex = 21;
            this.lblNombreProd.Text = "Nombre producto";
            // 
            // txtNombProd
            // 
            this.txtNombProd.Location = new System.Drawing.Point(668, 74);
            this.txtNombProd.Name = "txtNombProd";
            this.txtNombProd.Size = new System.Drawing.Size(100, 23);
            this.txtNombProd.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(208, 145);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 23;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Location = new System.Drawing.Point(34, 153);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(108, 15);
            this.lblApellidoCliente.TabIndex = 22;
            this.lblApellidoCliente.Text = "Apellido del cliente";
            // 
            // Ferreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 537);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.txtNombProd);
            this.Controls.Add(this.cmbMedioPago);
            this.Controls.Add(this.cmbComprobante);
            this.Controls.Add(this.cmbProductoCategoria);
            this.Controls.Add(this.lblMediospago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.dgCajaValoresRelacionados);
            this.Name = "Ferreteria";
            this.Text = "Ferreteria";
            this.Load += new System.EventHandler(this.Ferreteria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCajaValoresRelacionados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgCajaValoresRelacionados;
        private TextBox txtprecio;
        private TextBox txtNombre;
        private Button btAgregar;
        private Label label1;
        private Label lblNombreCliente;
        private Label label4;
        private Label lblcategoria;
        private Label label5;
        private Label lblMediospago;
        private ComboBox cmbProductoCategoria;
        private ComboBox cmbComprobante;
        private ComboBox cmbMedioPago;
        private Label lblNombreProd;
        private TextBox txtNombProd;
        private TextBox txtApellido;
        private Label lblApellidoCliente;
    }
}
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCantProductos = new System.Windows.Forms.Label();
            this.txtCantprod = new System.Windows.Forms.TextBox();
            this.lblcategoria = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMediospago = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.cmbMedioPago = new System.Windows.Forms.ComboBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 285);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(802, 225);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(212, 74);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(100, 23);
            this.txtprecio.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(212, 168);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 23);
            this.txtTotal.TabIndex = 4;
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
            this.btAgregar.Location = new System.Drawing.Point(357, 223);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(101, 41);
            this.btAgregar.TabIndex = 6;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Total";
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
            // lblCantProductos
            // 
            this.lblCantProductos.AutoSize = true;
            this.lblCantProductos.Location = new System.Drawing.Point(38, 146);
            this.lblCantProductos.Name = "lblCantProductos";
            this.lblCantProductos.Size = new System.Drawing.Size(112, 15);
            this.lblCantProductos.TabIndex = 12;
            this.lblCantProductos.Text = "Cantidad productos";
            // 
            // txtCantprod
            // 
            this.txtCantprod.Location = new System.Drawing.Point(212, 138);
            this.txtCantprod.Name = "txtCantprod";
            this.txtCantprod.Size = new System.Drawing.Size(100, 23);
            this.txtCantprod.TabIndex = 13;
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
            this.label5.Location = new System.Drawing.Point(494, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Comprobante";
            // 
            // lblMediospago
            // 
            this.lblMediospago.AutoSize = true;
            this.lblMediospago.Location = new System.Drawing.Point(494, 171);
            this.lblMediospago.Name = "lblMediospago";
            this.lblMediospago.Size = new System.Drawing.Size(92, 15);
            this.lblMediospago.TabIndex = 16;
            this.lblMediospago.Text = "Medios de pago";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(668, 105);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(100, 23);
            this.cmbCategoria.TabIndex = 17;
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Location = new System.Drawing.Point(668, 134);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(100, 23);
            this.cmbComprobante.TabIndex = 18;
            // 
            // cmbMedioPago
            // 
            this.cmbMedioPago.FormattingEnabled = true;
            this.cmbMedioPago.Location = new System.Drawing.Point(668, 163);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(668, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 20;
            // 
            // Ferreteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 537);
            this.Controls.Add(this.lblNombreProd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmbMedioPago);
            this.Controls.Add(this.cmbComprobante);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.lblMediospago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblcategoria);
            this.Controls.Add(this.txtCantprod);
            this.Controls.Add(this.lblCantProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ferreteria";
            this.Text = "Ferreteria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox txtprecio;
        private TextBox txtTotal;
        private TextBox txtNombre;
        private Button btAgregar;
        private Label label1;
        private Label lblNombreCliente;
        private Label label3;
        private Label label4;
        private Label lblCantProductos;
        private TextBox txtCantprod;
        private Label lblcategoria;
        private Label label5;
        private Label lblMediospago;
        private ComboBox cmbCategoria;
        private ComboBox cmbComprobante;
        private ComboBox cmbMedioPago;
        private Label lblNombreProd;
        private TextBox textBox1;
    }
}
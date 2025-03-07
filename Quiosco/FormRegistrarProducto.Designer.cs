namespace Quiosco
{
    partial class FormRegistrarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarProducto));
            label1 = new Label();
            dgvProducto = new DataGridView();
            label2 = new Label();
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
            lblCantidadProducto = new Label();
            lblPrecioVentaProducto = new Label();
            lblDistribuidorProducto = new Label();
            textBox2 = new TextBox();
            lblNombreProducto = new Label();
            lblMarcaProducto = new Label();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            lblPrecioCompraProducto = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            button1 = new Button();
            comboBox3 = new ComboBox();
            button2 = new Button();
            lblFechaCaja = new Label();
            dateTimeCaja = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvProducto).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1057, 67);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 8;
            label1.Text = "PRODUCTOS";
            label1.Click += label1_Click;
            // 
            // dgvProducto
            // 
            dgvProducto.BackgroundColor = SystemColors.GradientActiveCaption;
            dgvProducto.BorderStyle = BorderStyle.Fixed3D;
            dgvProducto.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            dgvProducto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducto.Cursor = Cursors.Hand;
            dgvProducto.Location = new Point(782, 106);
            dgvProducto.Name = "dgvProducto";
            dgvProducto.Size = new Size(674, 408);
            dgvProducto.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.LightSeaGreen;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Gill Sans Ultra Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(586, 28);
            label2.Name = "label2";
            label2.Size = new Size(231, 22);
            label2.TabIndex = 9;
            label2.Text = "REGISTRAR PRODUCTOS";
            label2.Click += label2_Click;
            // 
            // txtEliminarProducto
            // 
            txtEliminarProducto.Location = new Point(1199, 551);
            txtEliminarProducto.Name = "txtEliminarProducto";
            txtEliminarProducto.Size = new Size(134, 23);
            txtEliminarProducto.TabIndex = 53;
            // 
            // lblEliminarProducto
            // 
            lblEliminarProducto.AutoSize = true;
            lblEliminarProducto.BackColor = Color.Wheat;
            lblEliminarProducto.Location = new Point(1137, 554);
            lblEliminarProducto.Margin = new Padding(4, 0, 4, 0);
            lblEliminarProducto.Name = "lblEliminarProducto";
            lblEliminarProducto.Size = new Size(50, 15);
            lblEliminarProducto.TabIndex = 52;
            lblEliminarProducto.Text = "Eliminar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Wheat;
            label4.Location = new Point(807, 556);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 51;
            label4.Text = "Buscar";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.Location = new Point(871, 552);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(155, 23);
            txtBuscarProducto.TabIndex = 50;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackColor = Color.Gold;
            btnBuscarProducto.Location = new Point(1032, 543);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(84, 36);
            btnBuscarProducto.TabIndex = 49;
            btnBuscarProducto.Text = "Buscar";
            btnBuscarProducto.UseVisualStyleBackColor = false;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.Gold;
            btnEliminarProducto.Location = new Point(1346, 545);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(84, 36);
            btnEliminarProducto.TabIndex = 48;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            // 
            // btnCancelarProducto
            // 
            btnCancelarProducto.BackColor = Color.Gold;
            btnCancelarProducto.Location = new Point(255, 555);
            btnCancelarProducto.Name = "btnCancelarProducto";
            btnCancelarProducto.Size = new Size(84, 36);
            btnCancelarProducto.TabIndex = 46;
            btnCancelarProducto.Text = "Cancelar";
            btnCancelarProducto.UseVisualStyleBackColor = false;
            // 
            // btnModificarProducto
            // 
            btnModificarProducto.BackColor = Color.Gold;
            btnModificarProducto.Location = new Point(314, 495);
            btnModificarProducto.Name = "btnModificarProducto";
            btnModificarProducto.Size = new Size(84, 39);
            btnModificarProducto.TabIndex = 45;
            btnModificarProducto.Text = "Modificar";
            btnModificarProducto.UseVisualStyleBackColor = false;
            // 
            // btnCargarProducto
            // 
            btnCargarProducto.BackColor = Color.Gold;
            btnCargarProducto.Location = new Point(204, 496);
            btnCargarProducto.Name = "btnCargarProducto";
            btnCargarProducto.Size = new Size(84, 36);
            btnCargarProducto.TabIndex = 47;
            btnCargarProducto.Text = "Cargar";
            btnCargarProducto.UseVisualStyleBackColor = false;
            btnCargarProducto.Click += btnCargarProducto_Click;
            // 
            // txtCategoriaProducto
            // 
            txtCategoriaProducto.Location = new Point(250, 276);
            txtCategoriaProducto.Margin = new Padding(4);
            txtCategoriaProducto.Name = "txtCategoriaProducto";
            txtCategoriaProducto.Size = new Size(173, 23);
            txtCategoriaProducto.TabIndex = 44;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(252, 375);
            txtPrecioProducto.Margin = new Padding(4);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(176, 23);
            txtPrecioProducto.TabIndex = 43;
            // 
            // lblCantidadProducto
            // 
            lblCantidadProducto.AutoSize = true;
            lblCantidadProducto.BackColor = Color.Wheat;
            lblCantidadProducto.ForeColor = SystemColors.ActiveCaptionText;
            lblCantidadProducto.Location = new Point(135, 282);
            lblCantidadProducto.Margin = new Padding(4, 0, 4, 0);
            lblCantidadProducto.Name = "lblCantidadProducto";
            lblCantidadProducto.Size = new Size(55, 15);
            lblCantidadProducto.TabIndex = 41;
            lblCantidadProducto.Text = "Cantidad";
            // 
            // lblPrecioVentaProducto
            // 
            lblPrecioVentaProducto.AutoSize = true;
            lblPrecioVentaProducto.BackColor = Color.Wheat;
            lblPrecioVentaProducto.Location = new Point(129, 378);
            lblPrecioVentaProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioVentaProducto.Name = "lblPrecioVentaProducto";
            lblPrecioVentaProducto.Size = new Size(88, 15);
            lblPrecioVentaProducto.TabIndex = 40;
            lblPrecioVentaProducto.Text = "Precio de Venta";
            // 
            // lblDistribuidorProducto
            // 
            lblDistribuidorProducto.AutoSize = true;
            lblDistribuidorProducto.BackColor = Color.Wheat;
            lblDistribuidorProducto.Location = new Point(131, 335);
            lblDistribuidorProducto.Margin = new Padding(4, 0, 4, 0);
            lblDistribuidorProducto.Name = "lblDistribuidorProducto";
            lblDistribuidorProducto.Size = new Size(69, 15);
            lblDistribuidorProducto.TabIndex = 39;
            lblDistribuidorProducto.Text = "Distribuidor";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 97);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(173, 23);
            textBox2.TabIndex = 57;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.BackColor = Color.Wheat;
            lblNombreProducto.ForeColor = SystemColors.ActiveCaptionText;
            lblNombreProducto.Location = new Point(107, 100);
            lblNombreProducto.Margin = new Padding(4, 0, 4, 0);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(122, 15);
            lblNombreProducto.TabIndex = 56;
            lblNombreProducto.Text = "Nombre del Producto";
            // 
            // lblMarcaProducto
            // 
            lblMarcaProducto.AutoSize = true;
            lblMarcaProducto.BackColor = Color.Wheat;
            lblMarcaProducto.ForeColor = SystemColors.ActiveCaptionText;
            lblMarcaProducto.Location = new Point(142, 146);
            lblMarcaProducto.Margin = new Padding(4, 0, 4, 0);
            lblMarcaProducto.Name = "lblMarcaProducto";
            lblMarcaProducto.Size = new Size(40, 15);
            lblMarcaProducto.TabIndex = 56;
            lblMarcaProducto.Text = "Marca";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 143);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 57;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(249, 185);
            textBox4.Margin = new Padding(4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(173, 23);
            textBox4.TabIndex = 59;
            // 
            // lblPrecioCompraProducto
            // 
            lblPrecioCompraProducto.AutoSize = true;
            lblPrecioCompraProducto.BackColor = Color.Wheat;
            lblPrecioCompraProducto.ForeColor = SystemColors.ActiveCaptionText;
            lblPrecioCompraProducto.Location = new Point(113, 189);
            lblPrecioCompraProducto.Margin = new Padding(4, 0, 4, 0);
            lblPrecioCompraProducto.Name = "lblPrecioCompraProducto";
            lblPrecioCompraProducto.Size = new Size(68, 15);
            lblPrecioCompraProducto.TabIndex = 58;
            lblPrecioCompraProducto.Text = "Precio Total";
            lblPrecioCompraProducto.Click += label7_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(249, 327);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(176, 23);
            comboBox2.TabIndex = 97;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Wheat;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(134, 238);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 98;
            label3.Text = "Categoria";
            // 
            // button1
            // 
            button1.BackColor = Color.Gold;
            button1.Location = new Point(444, 230);
            button1.Name = "button1";
            button1.Size = new Size(149, 28);
            button1.TabIndex = 100;
            button1.Text = "Agregar Nueva Categoria";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(249, 234);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(176, 23);
            comboBox3.TabIndex = 102;
            // 
            // button2
            // 
            button2.BackColor = Color.Gold;
            button2.Location = new Point(444, 325);
            button2.Name = "button2";
            button2.Size = new Size(161, 28);
            button2.TabIndex = 103;
            button2.Text = "Agregar Nuevo Distribuidor";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblFechaCaja
            // 
            lblFechaCaja.AutoSize = true;
            lblFechaCaja.BackColor = Color.Wheat;
            lblFechaCaja.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaCaja.Location = new Point(77, 431);
            lblFechaCaja.Name = "lblFechaCaja";
            lblFechaCaja.Size = new Size(152, 15);
            lblFechaCaja.TabIndex = 105;
            lblFechaCaja.Text = "Fecha Compra de Producto";
            // 
            // dateTimeCaja
            // 
            dateTimeCaja.Location = new Point(252, 425);
            dateTimeCaja.Name = "dateTimeCaja";
            dateTimeCaja.Size = new Size(300, 23);
            dateTimeCaja.TabIndex = 104;
            // 
            // FormRegistrarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1484, 643);
            Controls.Add(lblFechaCaja);
            Controls.Add(dateTimeCaja);
            Controls.Add(button2);
            Controls.Add(comboBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox4);
            Controls.Add(lblPrecioCompraProducto);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblMarcaProducto);
            Controls.Add(lblNombreProducto);
            Controls.Add(txtEliminarProducto);
            Controls.Add(lblEliminarProducto);
            Controls.Add(label4);
            Controls.Add(txtBuscarProducto);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnEliminarProducto);
            Controls.Add(btnCancelarProducto);
            Controls.Add(btnModificarProducto);
            Controls.Add(btnCargarProducto);
            Controls.Add(txtCategoriaProducto);
            Controls.Add(txtPrecioProducto);
            Controls.Add(lblCantidadProducto);
            Controls.Add(lblPrecioVentaProducto);
            Controls.Add(lblDistribuidorProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvProducto);
            Name = "FormRegistrarProducto";
            Text = "Registro de Productos";
            ((System.ComponentModel.ISupportInitialize)dgvProducto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvProducto;
        private Label label2;
        private TextBox txtEliminarProducto;
        private Label lblEliminarProducto;
        private Label label4;
        private TextBox txtBuscarProducto;
        private Button btnBuscarProducto;
        private Button btnEliminarProducto;
        private Button btnCancelarProducto;
        private Button btnModificarProducto;
        private Button btnCargarProducto;
        private TextBox txtCategoriaProducto;
        private TextBox txtPrecioProducto;
        private Label lblCantidadProducto;
        private Label lblPrecioVentaProducto;
        private Label lblDistribuidorProducto;
        private TextBox textBox2;
        private Label lblNombreProducto;
        private Label lblMarcaProducto;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label lblPrecioCompraProducto;
        private ComboBox comboBox2;
        private Label label3;
        private Button button1;
        private ComboBox comboBox3;
        private Button button2;
        private Label lblFechaCaja;
        private DateTimePicker dateTimeCaja;
    }
}
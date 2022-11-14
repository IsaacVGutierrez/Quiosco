namespace GuarderiaMascotas
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
            this.txtDniProducto = new System.Windows.Forms.TextBox();
            this.txtTelProducto = new System.Windows.Forms.TextBox();
            this.txtApellidoProducto = new System.Windows.Forms.TextBox();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDniProducto = new System.Windows.Forms.Label();
            this.lblTelProducto = new System.Windows.Forms.Label();
            this.lblApellidoProducto = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.tabMovimiento = new System.Windows.Forms.TabPage();
            this.btnCancelarMovimiento = new System.Windows.Forms.Button();
            this.btnModificarMovimiento = new System.Windows.Forms.Button();
            this.cbMovimiento = new System.Windows.Forms.ComboBox();
            this.lblMovimiento = new System.Windows.Forms.Label();
            this.cbRetirado = new System.Windows.Forms.CheckBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnCargaMovimiento = new System.Windows.Forms.Button();
            this.txtObsMovimiento = new System.Windows.Forms.TextBox();
            this.txtNombreMovimiento = new System.Windows.Forms.TextBox();
            this.lblFechaNacMovimiento = new System.Windows.Forms.Label();
            this.lblObsMovimiento = new System.Windows.Forms.Label();
            this.lblTipoMovimiento = new System.Windows.Forms.Label();
            this.lblNombreMovimiento = new System.Windows.Forms.Label();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.dgvMovimiento = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabProducto.SuspendLayout();
            this.tabMovimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProducto);
            this.tabControl1.Controls.Add(this.tabMovimiento);
            this.tabControl1.Location = new System.Drawing.Point(281, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(539, 264);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDuenio
            // 
            this.tabProducto.Controls.Add(this.btnCancelarProducto);
            this.tabProducto.Controls.Add(this.btnModificarProducto);
            this.tabProducto.Controls.Add(this.btnCargarProducto);
            this.tabProducto.Controls.Add(this.txtDniProducto);
            this.tabProducto.Controls.Add(this.txtTelProducto);
            this.tabProducto.Controls.Add(this.txtApellidoProducto);
            this.tabProducto.Controls.Add(this.txtNombreProducto);
            this.tabProducto.Controls.Add(this.lblDniProducto);
            this.tabProducto.Controls.Add(this.lblTelProducto);
            this.tabProducto.Controls.Add(this.lblApellidoProducto);
            this.tabProducto.Controls.Add(this.lblNombreProducto);
            this.tabProducto.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducto.Location = new System.Drawing.Point(4, 27);
            this.tabProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tabProducto.Name = "tabDuenio";
            this.tabProducto.Padding = new System.Windows.Forms.Padding(4);
            this.tabProducto.Size = new System.Drawing.Size(531, 233);
            this.tabProducto.TabIndex = 0;
            this.tabProducto.Text = "Dueño";
            this.tabProducto.UseVisualStyleBackColor = true;
            // 
            // btnCancelarDuenio
            // 
            this.btnCancelarProducto.Location = new System.Drawing.Point(334, 200);
            this.btnCancelarProducto.Name = "btnCancelarDuenio";
            this.btnCancelarProducto.Size = new System.Drawing.Size(79, 26);
            this.btnCancelarProducto.TabIndex = 27;
            this.btnCancelarProducto.Text = "Cancelar";
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Visible = false;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarDuenio_Click);
            // 
            // btnModificarDuenio
            // 
            this.btnModificarProducto.Location = new System.Drawing.Point(419, 200);
            this.btnModificarProducto.Name = "btnModificarDuenio";
            this.btnModificarProducto.Size = new System.Drawing.Size(84, 26);
            this.btnModificarProducto.TabIndex = 24;
            this.btnModificarProducto.Text = "Modificar";
            this.btnModificarProducto.UseVisualStyleBackColor = true;
            this.btnModificarProducto.Visible = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarDuenio_Click);
            // 
            // btnCargarDuenio
            // 
            this.btnCargarProducto.Location = new System.Drawing.Point(419, 200);
            this.btnCargarProducto.Name = "btnCargarDuenio";
            this.btnCargarProducto.Size = new System.Drawing.Size(84, 26);
            this.btnCargarProducto.TabIndex = 8;
            this.btnCargarProducto.Text = "Cargar";
            this.btnCargarProducto.UseVisualStyleBackColor = true;
            this.btnCargarProducto.Click += new System.EventHandler(this.btnCargarDuenio_Click);
            // 
            // txtDniDuenio
            // 
            this.txtDniProducto.Location = new System.Drawing.Point(144, 158);
            this.txtDniProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDniProducto.Name = "txtDniDuenio";
            this.txtDniProducto.Size = new System.Drawing.Size(132, 26);
            this.txtDniProducto.TabIndex = 7;
            this.txtDniProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDniDuenio_KeyPress);
            // 
            // txtTelDuenio
            // 
            this.txtTelProducto.Location = new System.Drawing.Point(144, 110);
            this.txtTelProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelProducto.Name = "txtTelDuenio";
            this.txtTelProducto.Size = new System.Drawing.Size(132, 26);
            this.txtTelProducto.TabIndex = 6;
            this.txtTelProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelDuenio_KeyPress);
            // 
            // txtApellidoDuenio
            // 
            this.txtApellidoProducto.Location = new System.Drawing.Point(144, 63);
            this.txtApellidoProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellidoProducto.Name = "txtApellidoDuenio";
            this.txtApellidoProducto.Size = new System.Drawing.Size(132, 26);
            this.txtApellidoProducto.TabIndex = 5;
            this.txtApellidoProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoDuenio_KeyPress);
            // 
            // txtNombreDuenio
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(144, 18);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreProducto.Size = new System.Drawing.Size(132, 26);
            this.txtNombreProducto.TabIndex = 4;
            this.txtNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreDuenio_KeyPress);
            // 
            // lblDniDuenio
            // 
            this.lblDniProducto.AutoSize = true;
            this.lblDniProducto.Location = new System.Drawing.Point(24, 161);
            this.lblDniProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDniProducto.Name = "lblDniDuenio";
            this.lblDniProducto.Size = new System.Drawing.Size(32, 18);
            this.lblDniProducto.TabIndex = 3;
            this.lblDniProducto.Text = "DNI";
            // 
            // lblTelDuenio
            // 
            this.lblTelProducto.AutoSize = true;
            this.lblTelProducto.Location = new System.Drawing.Point(24, 113);
            this.lblTelProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelProducto.Name = "lblTelDuenio";
            this.lblTelProducto.Size = new System.Drawing.Size(61, 18);
            this.lblTelProducto.TabIndex = 2;
            this.lblTelProducto.Text = "Teléfono";
            // 
            // lblApellidoDuenio
            // 
            this.lblApellidoProducto.AutoSize = true;
            this.lblApellidoProducto.Location = new System.Drawing.Point(24, 66);
            this.lblApellidoProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoProducto.Name = "lblApellidoDuenio";
            this.lblApellidoProducto.Size = new System.Drawing.Size(58, 18);
            this.lblApellidoProducto.TabIndex = 1;
            this.lblApellidoProducto.Text = "Apellido";
            // 
            // lblNombreDuenio
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(22, 21);
            this.lblNombreProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreProducto.Name = "lblNombreDuenio";
            this.lblNombreProducto.Size = new System.Drawing.Size(58, 18);
            this.lblNombreProducto.TabIndex = 0;
            this.lblNombreProducto.Text = "Nombre";
            // 
            // tabMascota
            // 
            this.tabMovimiento.Controls.Add(this.btnCancelarMovimiento);
            this.tabMovimiento.Controls.Add(this.btnModificarMovimiento);
            this.tabMovimiento.Controls.Add(this.cbMovimiento);
            this.tabMovimiento.Controls.Add(this.lblMovimiento);
            this.tabMovimiento.Controls.Add(this.cbRetirado);
            this.tabMovimiento.Controls.Add(this.dtpFechaNac);
            this.tabMovimiento.Controls.Add(this.cmbTipo);
            this.tabMovimiento.Controls.Add(this.btnCargaMovimiento);
            this.tabMovimiento.Controls.Add(this.txtObsMovimiento);
            this.tabMovimiento.Controls.Add(this.txtNombreMovimiento);
            this.tabMovimiento.Controls.Add(this.lblFechaNacMovimiento);
            this.tabMovimiento.Controls.Add(this.lblObsMovimiento);
            this.tabMovimiento.Controls.Add(this.lblTipoMovimiento);
            this.tabMovimiento.Controls.Add(this.lblNombreMovimiento);
            this.tabMovimiento.Location = new System.Drawing.Point(4, 27);
            this.tabMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Name = "tabMascota";
            this.tabMovimiento.Padding = new System.Windows.Forms.Padding(4);
            this.tabMovimiento.Size = new System.Drawing.Size(531, 233);
            this.tabMovimiento.TabIndex = 1;
            this.tabMovimiento.Text = "Mascota";
            this.tabMovimiento.UseVisualStyleBackColor = true;
            // 
            // btnCancelarMascota
            // 
            this.btnCancelarMovimiento.Location = new System.Drawing.Point(334, 200);
            this.btnCancelarMovimiento.Name = "btnCancelarMascota";
            this.btnCancelarMovimiento.Size = new System.Drawing.Size(79, 26);
            this.btnCancelarMovimiento.TabIndex = 26;
            this.btnCancelarMovimiento.Text = "Cancelar";
            this.btnCancelarMovimiento.UseVisualStyleBackColor = true;
            this.btnCancelarMovimiento.Visible = false;
            this.btnCancelarMovimiento.Click += new System.EventHandler(this.btnCancelarMascota_Click);
            // 
            // btnModificarMascota
            // 
            this.btnModificarMovimiento.Location = new System.Drawing.Point(419, 200);
            this.btnModificarMovimiento.Name = "btnModificarMascota";
            this.btnModificarMovimiento.Size = new System.Drawing.Size(84, 26);
            this.btnModificarMovimiento.TabIndex = 25;
            this.btnModificarMovimiento.Text = "Modificar";
            this.btnModificarMovimiento.UseVisualStyleBackColor = true;
            this.btnModificarMovimiento.Visible = false;
            this.btnModificarMovimiento.Click += new System.EventHandler(this.btnModificarMascota_Click);
            // 
            // cbDueniosMascota
            // 
            this.cbMovimiento.FormattingEnabled = true;
            this.cbMovimiento.Location = new System.Drawing.Point(107, 113);
            this.cbMovimiento.Name = "cbDueniosMascota";
            this.cbMovimiento.Size = new System.Drawing.Size(132, 26);
            this.cbMovimiento.TabIndex = 23;
            this.cbMovimiento.Text = "Dueños";
            // 
            // lblDuenioMascota
            // 
            this.lblMovimiento.AutoSize = true;
            this.lblMovimiento.Location = new System.Drawing.Point(8, 116);
            this.lblMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMovimiento.Name = "lblDuenioMascota";
            this.lblMovimiento.Size = new System.Drawing.Size(49, 18);
            this.lblMovimiento.TabIndex = 22;
            this.lblMovimiento.Text = "Dueño";
            // 
            // cbRetirado
            // 
            this.cbRetirado.AutoSize = true;
            this.cbRetirado.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRetirado.Location = new System.Drawing.Point(301, 115);
            this.cbRetirado.Name = "cbRetirado";
            this.cbRetirado.Size = new System.Drawing.Size(79, 22);
            this.cbRetirado.TabIndex = 21;
            this.cbRetirado.Text = "Retirado";
            this.cbRetirado.UseVisualStyleBackColor = true;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaNac.Location = new System.Drawing.Point(287, 70);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(237, 23);
            this.dtpFechaNac.TabIndex = 20;
            this.dtpFechaNac.Value = new System.DateTime(2022, 10, 30, 0, 0, 0, 0);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Perro",
            "Gato",
            "Roedor",
            "Ave",
            "Reptil",
            "Insecto"});
            this.cmbTipo.Location = new System.Drawing.Point(107, 67);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(132, 26);
            this.cmbTipo.TabIndex = 19;
            this.cmbTipo.Text = "Tipo";
            // 
            // btnCargaMascota
            // 
            this.btnCargaMovimiento.Location = new System.Drawing.Point(419, 200);
            this.btnCargaMovimiento.Name = "btnCargaMascota";
            this.btnCargaMovimiento.Size = new System.Drawing.Size(84, 26);
            this.btnCargaMovimiento.TabIndex = 17;
            this.btnCargaMovimiento.Text = "Cargar";
            this.btnCargaMovimiento.UseVisualStyleBackColor = true;
            this.btnCargaMovimiento.Click += new System.EventHandler(this.btnCargaMascota_Click);
            // 
            // txtObsMascota
            // 
            this.txtObsMovimiento.Location = new System.Drawing.Point(107, 161);
            this.txtObsMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtObsMovimiento.Name = "txtObsMascota";
            this.txtObsMovimiento.Size = new System.Drawing.Size(284, 26);
            this.txtObsMovimiento.TabIndex = 14;
            this.txtObsMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObsMascota_KeyPress);
            // 
            // txtNombreMascota
            // 
            this.txtNombreMovimiento.Location = new System.Drawing.Point(107, 21);
            this.txtNombreMovimiento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreMovimiento.Name = "txtNombreMascota";
            this.txtNombreMovimiento.Size = new System.Drawing.Size(132, 26);
            this.txtNombreMovimiento.TabIndex = 13;
            this.txtNombreMovimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreMascota_KeyPress);
            // 
            // lblFechaNacMascota
            // 
            this.lblFechaNacMovimiento.AutoSize = true;
            this.lblFechaNacMovimiento.Location = new System.Drawing.Point(284, 29);
            this.lblFechaNacMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaNacMovimiento.Name = "lblFechaNacMascota";
            this.lblFechaNacMovimiento.Size = new System.Drawing.Size(134, 18);
            this.lblFechaNacMovimiento.TabIndex = 12;
            this.lblFechaNacMovimiento.Text = "Fecha de nacimiento";
            // 
            // lblObsMascota
            // 
            this.lblObsMovimiento.AutoSize = true;
            this.lblObsMovimiento.Location = new System.Drawing.Point(8, 161);
            this.lblObsMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObsMovimiento.Name = "lblObsMascota";
            this.lblObsMovimiento.Size = new System.Drawing.Size(85, 18);
            this.lblObsMovimiento.TabIndex = 11;
            this.lblObsMovimiento.Text = "Observación";
            // 
            // lblTipoMascota
            // 
            this.lblTipoMovimiento.AutoSize = true;
            this.lblTipoMovimiento.Location = new System.Drawing.Point(8, 70);
            this.lblTipoMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoMovimiento.Name = "lblTipoMascota";
            this.lblTipoMovimiento.Size = new System.Drawing.Size(35, 18);
            this.lblTipoMovimiento.TabIndex = 10;
            this.lblTipoMovimiento.Text = "Tipo";
            // 
            // lblNombreMascota
            // 
            this.lblNombreMovimiento.AutoSize = true;
            this.lblNombreMovimiento.Location = new System.Drawing.Point(8, 24);
            this.lblNombreMovimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreMovimiento.Name = "lblNombreMascota";
            this.lblNombreMovimiento.Size = new System.Drawing.Size(58, 18);
            this.lblNombreMovimiento.TabIndex = 9;
            this.lblNombreMovimiento.Text = "Nombre";
            // 
            // dgvDuenios
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(281, 300);
            this.dgvProducto.Name = "dgvDuenios";
            this.dgvProducto.Size = new System.Drawing.Size(539, 251);
            this.dgvProducto.TabIndex = 2;
            this.dgvProducto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuenios_CellClick_1);
            this.dgvProducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDuenios_CellContentClick);
            // 
            // dgvMascotas
            // 
            this.dgvMovimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMovimiento.Location = new System.Drawing.Point(186, 569);
            this.dgvMovimiento.Name = "dgvMascotas";
            this.dgvMovimiento.Size = new System.Drawing.Size(744, 251);
            this.dgvMovimiento.TabIndex = 3;
            this.dgvMovimiento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMascotas_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 832);
            this.Controls.Add(this.dgvMovimiento);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabProducto.ResumeLayout(false);
            this.tabProducto.PerformLayout();
            this.tabMovimiento.ResumeLayout(false);
            this.tabMovimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMovimiento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProducto;
        private System.Windows.Forms.Button btnCargarProducto;
        private System.Windows.Forms.TextBox txtDniProducto;
        private System.Windows.Forms.TextBox txtTelProducto;
        private System.Windows.Forms.TextBox txtApellidoProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblDniProducto;
        private System.Windows.Forms.Label lblTelProducto;
        private System.Windows.Forms.Label lblApellidoProducto;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.TabPage tabMovimiento;
        private System.Windows.Forms.CheckBox cbRetirado;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnCargaMovimiento;
        private System.Windows.Forms.TextBox txtObsMovimiento;
        private System.Windows.Forms.TextBox txtNombreMovimiento;
        private System.Windows.Forms.Label lblFechaNacMovimiento;
        private System.Windows.Forms.Label lblObsMovimiento;
        private System.Windows.Forms.Label lblTipoMovimiento;
        private System.Windows.Forms.Label lblNombreMovimiento;
        private System.Windows.Forms.ComboBox cbMovimiento;
        private System.Windows.Forms.Label lblMovimiento;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridView dgvMovimiento;
        private System.Windows.Forms.Button btnModificarProducto;
        private System.Windows.Forms.Button btnModificarMovimiento;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.Button btnCancelarMovimiento;
    }
}


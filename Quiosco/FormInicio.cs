﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiosco
{
    public partial class FormInicio : Form
    {
        public FormInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form2 = new FormRegistroProveedores();
            form2.Show();
        }

        private void tabProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCaja_Click(object sender, EventArgs e)
        {

        }

        private void btRegistrarVenta_Click(object sender, EventArgs e)
        {

        }
    }
}

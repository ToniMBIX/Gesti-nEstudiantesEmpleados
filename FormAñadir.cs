﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestiónEstudiantesEmpleados
{
    public partial class FormAñadir : Form
    {
        public FormAñadir()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonObrero_Click(object sender, EventArgs e)
        {
            FormEmpleadoObrero formEmpleadoObrero = new FormEmpleadoObrero();

            formEmpleadoObrero.Show();

        }
    }
}

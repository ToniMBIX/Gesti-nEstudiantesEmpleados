using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestiónEstudiantesEmpleados.models;

namespace GestiónEstudiantesEmpleados
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            FormAñadir formAñadir = new FormAñadir();

            formAñadir.Show();
        }
    }
}

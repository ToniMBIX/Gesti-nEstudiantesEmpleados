using GestiónEstudiantesEmpleados.models;
using System;
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
    public partial class FormEmpleadoObrero : Form
    {
        public FormEmpleadoObrero()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAñadir_Click(object sender, EventArgs e)
        {
            Obrero obrero = new Obrero(textBoxNombre.Text, textBoxApellidos.Text, double.Parse(textBoxSueldoBase.Text), textBoxDNI.Text, textBoxDestinoTrabajo.Text, int.Parse(textBoxHorasExtra.Text), double.Parse(textBoxPrecioHE.Text));
        }

    }
}

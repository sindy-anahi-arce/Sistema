using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Froles x = new formularios.Froles();
            x.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.usuarios x = new formularios.usuarios();
            x.Show();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void datosGeneralesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.DatosGenerales x = new formularios.DatosGenerales();
            x.Show();
        }

        private void modulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Modulos x = new formularios.Modulos();
            x.Show();
        }

        private void permisosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formularios.Permisos x = new formularios.Permisos();
            x.Show();
        }
    }
}

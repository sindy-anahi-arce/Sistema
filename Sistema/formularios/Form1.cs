using Sistema.formularios;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        clases.conexion c;
        //clases.usuario cu;
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            ingresar();
        }
        private void ingresar()
        {
            clases.usuario u = new clases.usuario(textBox1.Text, textBox2.Text);
            DataSet ds = new DataSet();
            c = new clases.conexion(u.CONSULTARI());
            ds = c.consultar();

            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                menu x = new menu();
                x.Show(); 
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Verifique", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

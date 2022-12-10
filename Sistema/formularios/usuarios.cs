using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema.formularios
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void catalogoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //Metodo
        private void cargarRol()
        {
            DataSet ds = new DataSet();
            clases.roles r = new clases.roles();
            clases.conexion c = new clases.conexion(r.consultageneral());
            ds = c.consultar();
            cmbRoles.DataSource = ds.Tables[0];
            //cmbRoles.DisplayMember = ds.Tables[0].Columns[]
        }
        private void usuarios_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bDABARROTERol.ROL' Puede moverla o quitarla según sea necesario.
            this.rOLTableAdapter.Fill(this.bDABARROTERol.ROL, txtNom.Text);
            cargarRol();
            cargarfolio();
        }

        clases.conexion c;
        clases.usuario B;

        void cargarfolio()
        {
            B = new clases.usuario();
            DataSet ds = new DataSet();
            c = new clases.conexion(B.CONSULTARI());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtUsuario.Text = ds.Tables["Tabla"].Rows[0]["IDUSUARIO"].ToString();
                txtNom.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                txtContra.Text = ds.Tables["Tabla"].Rows[0]["CONTRA"].ToString();
                cmbRoles.SelectedValue = ds.Tables["Tabla"].Rows[0]["IDCLAVE"].ToString();
            }
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            busca();
        }
        clases.usuario g;

        private void busca()
        {
            try
            {
                g = new clases.usuario();
                clases.conexion con = new clases.conexion();
                if (con.Execute(g.consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtNom.Text = con.FieldValue;
                        consultar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }
        private void consultar()
        {
            if (!(txtNom.Text == ""))
            {
                try
                {
                    B = new clases.usuario(txtNom.Text);
                    DataSet ds = new DataSet();
                    c = new clases.conexion(B.CONSULTARI());
                    ds = c.consultar();
                    if (ds.Tables["Tabla"].Rows.Count > 0)
                    {
                        txtUsuario.Text = ds.Tables["Tabla"].Rows[0]["IDUSUARIO"].ToString();
                        txtNom.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
                        txtContra.Text = ds.Tables["Tabla"].Rows[0]["CONTRA"].ToString();
                        cmbRoles.SelectedValue = ds.Tables["Tabla"].Rows[0]["IDCLAVE"].ToString();

                        /* TXTCHO_MODELO.Text = ds.Tables["Tabla"].Rows[0]["CHO_MODELO"].ToString();
                         TXTCHO_TELEFONO.Text = ds.Tables["Tabla"].Rows[0]["CHO_TELEFONO"].ToString();
                         TXTCHO_COLOR.Text = ds.Tables["Tabla"].Rows[0]["CHO_COLOR"].ToString();*/
                        // TXTLOT_LOTE.Select(TXTLOT_LOTE.Text.Length, 0);

                    }
                    else

                        MessageBox.Show("No Existe este dato");
                        txtNom.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }

            }
        }

        private void tsBtnGuardar_Click(object sender, EventArgs e)
        {
            graba();
        }
        private void graba()
        {
            //Valida que no este vacía ninguna caja de texto
            if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtContra.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            clases.usuario B = new clases.usuario(txtNom.Text);
            DataSet ds = new DataSet();
            c = new clases.conexion(B.CONSULTARI());
            ds = c.consultar();
            g = new clases.usuario(txtContra.Text, txtNom.Text);

            if (ds.Tables["Tabla"].Rows.Count > 0)
                c = new clases.conexion(g.modificar());
            else
                c = new clases.conexion(g.GRABAR());
            MessageBox.Show(c.ejecutar());
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnEliminar_Click(object sender, EventArgs e)
        {
            txtUsuario.Clear();
            txtNom.Clear();
            txtContra.Clear();
        }

        //Evento para que solo acepte letras la caja de texto
        private void txtNom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

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
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            cargarfolio();
        }
        
        clases.conexion c;
        clases.Cpermisos B;
        void cargarfolio()
        {
            B = new clases.Cpermisos();
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtIdPer.Text = ds.Tables["Tabla"].Rows[0]["id"].ToString();
                txtId_rol.Text = ds.Tables["Tabla"].Rows[0]["id_rol"].ToString();
                txtId_modu.Text = ds.Tables["Tabla"].Rows[0]["id_modulo"].ToString();
                rbConsultar.Text = ds.Tables["Tabla"].Rows[0]["consultar"].ToString();
                rbGrabar.Text = ds.Tables["Tabla"].Rows[0]["grabar"].ToString();
                rbActualizar.Text = ds.Tables["Tabla"].Rows[0]["actualizar"].ToString();
                rbBorrar.Text = ds.Tables["Tabla"].Rows[0]["borrar"].ToString();
            }
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            busca();
        }
        clases.Cpermisos g;

        private void busca()
        {
            try
            {
                g = new clases.Cpermisos();
                clases.conexion con = new clases.conexion();
                if (con.Execute(g.Consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtIdPer.Text = con.FieldValue;
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
            if (!(txtIdPer.Text == ""))
            {
                try
                {
                    B = new clases.Cpermisos(Convert.ToInt32(txtIdPer.Text));
                    DataSet ds = new DataSet();
                    c = new clases.conexion(B.Consultari());
                    ds = c.consultar();
                    if (ds.Tables["Tabla"].Rows.Count > 0)
                    {
                        txtIdPer.Text = ds.Tables["Tabla"].Rows[0]["id"].ToString();
                        txtId_rol.Text = ds.Tables["Tabla"].Rows[0]["id_rol"].ToString();
                        txtId_modu.Text = ds.Tables["Tabla"].Rows[0]["id_modulo"].ToString();
                        rbConsultar.Text = ds.Tables["Tabla"].Rows[0]["consultar"].ToString();
                        rbGrabar.Text = ds.Tables["Tabla"].Rows[0]["grabar"].ToString();
                        rbActualizar.Text = ds.Tables["Tabla"].Rows[0]["actualizar"].ToString();
                        rbBorrar.Text = ds.Tables["Tabla"].Rows[0]["borrar"].ToString();

                        /* TXTCHO_MODELO.Text = ds.Tables["Tabla"].Rows[0]["CHO_MODELO"].ToString();
                         TXTCHO_TELEFONO.Text = ds.Tables["Tabla"].Rows[0]["CHO_TELEFONO"].ToString();
                         TXTCHO_COLOR.Text = ds.Tables["Tabla"].Rows[0]["CHO_COLOR"].ToString();*/
                        // TXTLOT_LOTE.Select(TXTLOT_LOTE.Text.Length, 0);

                    }
                    else

                        MessageBox.Show("No Existe este dato");
                        txtIdPer.Focus();
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
            if (string.IsNullOrEmpty(txtIdPer.Text) || string.IsNullOrEmpty(txtId_rol.Text) || string.IsNullOrEmpty(txtId_modu.Text) || string.IsNullOrEmpty(txtNomModu.Text) || string.IsNullOrEmpty(txtNomRol.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            clases.Cpermisos B = new clases.Cpermisos(Convert.ToInt32(txtIdPer.Text));
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            g = new clases.Cpermisos();

            if (ds.Tables["Tabla"].Rows.Count > 0)
                c = new clases.conexion(g.Modificar());
            else
                c = new clases.conexion(g.Grabar());
            MessageBox.Show(c.ejecutar());
        }

        private void tsBtnEliminar_Click(object sender, EventArgs e)
        {
            txtIdPer.Clear();
            txtId_modu.Clear();
            txtId_rol.Clear();
            txtNomModu.Clear();
            txtNomRol.Clear();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Evento para que solo acepte letras la caja de texto
        private void txtNomRol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNomModu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Evento para que solo acepte números la caja de texto
        private void txtIdPer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtId_rol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}

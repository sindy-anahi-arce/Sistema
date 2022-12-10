using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistema.formularios
{
    public partial class DatosGenerales : Form
    {
        public DatosGenerales()
        {
            InitializeComponent();
        }

        private void DatosGenerales_Load(object sender, EventArgs e)
        {
            cargarfolio();
        }
        clases.conexion c;
        clases.CdatGenerales B;
        void cargarfolio()
        {
            B = new clases.CdatGenerales();
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtNomEmpre.Text = ds.Tables["Tabla"].Rows[0]["NOMEMPRESA"].ToString();
                txtDirecc.Text = ds.Tables["Tabla"].Rows[0]["DIRECCION"].ToString();
                txtTelefono.Text = ds.Tables["Tabla"].Rows[0]["TELEFONO"].ToString();
                txtGerente.Text = ds.Tables["Tabla"].Rows[0]["GERENTE"].ToString();
            }
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            busca();
        }
        clases.CdatGenerales g;

        private void busca()
        {
            try
            {
                g = new clases.CdatGenerales();
                clases.conexion con = new clases.conexion();
                if (con.Execute(g.Consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtNomEmpre.Text = con.FieldValue;
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
            if (!(txtNomEmpre.Text == ""))
            {
                try
                {
                    B = new clases.CdatGenerales(txtNomEmpre.Text);
                    DataSet ds = new DataSet();
                    c = new clases.conexion(B.Consultari());
                    ds = c.consultar();
                    if (ds.Tables["Tabla"].Rows.Count > 0)
                    {
                        txtNomEmpre.Text = ds.Tables["Tabla"].Rows[0]["NOMEMPRESA"].ToString();
                        txtDirecc.Text = ds.Tables["Tabla"].Rows[0]["DIRECCION"].ToString();
                        txtTelefono.Text = ds.Tables["Tabla"].Rows[0]["TELEFONO"].ToString();
                        txtGerente.Text = ds.Tables["Tabla"].Rows[0]["GERENTE"].ToString();

                        /* TXTCHO_MODELO.Text = ds.Tables["Tabla"].Rows[0]["CHO_MODELO"].ToString();
                         TXTCHO_TELEFONO.Text = ds.Tables["Tabla"].Rows[0]["CHO_TELEFONO"].ToString();
                         TXTCHO_COLOR.Text = ds.Tables["Tabla"].Rows[0]["CHO_COLOR"].ToString();*/
                        // TXTLOT_LOTE.Select(TXTLOT_LOTE.Text.Length, 0);

                    }
                    else

                        MessageBox.Show("No Existe este dato");
                    txtNomEmpre.Focus();
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
            if (string.IsNullOrEmpty(txtNomEmpre.Text) || string.IsNullOrEmpty(txtDirecc.Text) || string.IsNullOrEmpty(txtTelefono.Text) || string.IsNullOrEmpty(txtDirecc.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            clases.CdatGenerales B = new clases.CdatGenerales(txtNomEmpre.Text);
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            g = new clases.CdatGenerales(txtNomEmpre.Text, txtDirecc.Text, txtTelefono.Text, txtGerente.Text);

            if (ds.Tables["Tabla"].Rows.Count > 0)
                c = new clases.conexion(g.Modificar());
            else
                c = new clases.conexion(g.Grabar());
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
            txtNomEmpre.Clear();
            txtDirecc.Clear();
            txtTelefono.Clear();
            txtGerente.Clear();
        }

        //Evento para que solo acepte letras la caja de texto
        private void txtNomEmpre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Evento para que solo acepte números la caja de texto
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //Evento para que solo acepte letras la caja de texto
        private void txtGerente_KeyPress(object sender, KeyPressEventArgs e)
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

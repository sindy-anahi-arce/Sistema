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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
        }

        private void Modulos_Load(object sender, EventArgs e)
        {
            cargarfolio();
        }
        void cargarfolio()
        {
            B = new clases.Cmodulos();
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtIdModulo.Text = ds.Tables["Tabla"].Rows[0]["id_nombre"].ToString();
                txtNomModu.Text = ds.Tables["Tabla"].Rows[0]["nombre_modulo"].ToString();
            }
        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            busca();
        }
        clases.Cmodulos g;

        private void busca()
        {
            try
            {
                g = new clases.Cmodulos();
                clases.conexion con = new clases.conexion();
                if (con.Execute(g.Consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtIdModulo.Text = con.FieldValue;
                        consultar();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        clases.conexion c;
        clases.Cmodulos B;

        private void consultar()
        {
            if (!(txtIdModulo.Text == ""))
            {
                try
                {
                    B = new clases.Cmodulos(byte.Parse(txtIdModulo.Text));
                    DataSet ds = new DataSet();
                    c = new clases.conexion(B.Consultari());
                    ds = c.consultar();
                    if (ds.Tables["Tabla"].Rows.Count > 0)
                    {
                        txtIdModulo.Text = ds.Tables["Tabla"].Rows[0]["id_nombre"].ToString();
                        txtNomModu.Text = ds.Tables["Tabla"].Rows[0]["nombre_modulo"].ToString();
                        /* TXTCHO_MODELO.Text = ds.Tables["Tabla"].Rows[0]["CHO_MODELO"].ToString();
                         TXTCHO_TELEFONO.Text = ds.Tables["Tabla"].Rows[0]["CHO_TELEFONO"].ToString();
                         TXTCHO_COLOR.Text = ds.Tables["Tabla"].Rows[0]["CHO_COLOR"].ToString();*/
                        // TXTLOT_LOTE.Select(TXTLOT_LOTE.Text.Length, 0);


                    }
                    else

                        MessageBox.Show("No Existe este dato");
                    txtNomModu.Focus();
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
            if (string.IsNullOrEmpty(txtIdModulo.Text) || string.IsNullOrEmpty(txtNomModu.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            clases.Cmodulos B = new clases.Cmodulos(byte.Parse(txtIdModulo.Text));
            DataSet ds = new DataSet();
            c = new clases.conexion(B.Consultari());
            ds = c.consultar();
            g = new clases.Cmodulos(byte.Parse(txtIdModulo.Text), txtNomModu.Text);

            if (ds.Tables["Tabla"].Rows.Count > 0)
                c = new clases.conexion(g.Modificar());
            else
                c = new clases.conexion(g.Grabar());
            MessageBox.Show(c.ejecutar());
        }

        private void tsBtnImprimir_Click(object sender, EventArgs e)
        {

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
            txtIdModulo.Clear();
            txtNomModu.Clear();
        }

        //Evento para que solo acepte letras la caja de texto
        private void txtNomModu_KeyPress(object sender, KeyPressEventArgs e)
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

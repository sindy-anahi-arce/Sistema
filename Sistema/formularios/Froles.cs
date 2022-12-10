using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportAppServer;
using CrystalDecisions.Shared;
using Sistema.Catalagos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistema.formularios
{
    public partial class Froles : Form
    {
        public Froles()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnBuscar_Click(object sender, EventArgs e)
        {
            busca();
        }

        clases.roles g;

        private void busca()
        {
            try
            {
                g = new clases.roles();
                clases.conexion con = new clases.conexion();
                if (con.Execute(g.consultageneral(), 0) == true)
                {
                    if (con.FieldValue != "")
                    {
                        txtClave.Text = con.FieldValue;
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
        clases.roles B;

        private void consultar()
        {
            if (!(txtClave.Text == ""))
            {
                try
                {
                    B = new clases.roles(byte.Parse(txtClave.Text));
                    DataSet ds = new DataSet();
                    c = new clases.conexion(B.CONSULTARI());
                    ds = c.consultar();
                    if (ds.Tables["Tabla"].Rows.Count > 0)
                    {
                        txtClave.Text = ds.Tables["Tabla"].Rows[0]["IDCLAVE"].ToString();
                        txtNom.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
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
            if (string.IsNullOrEmpty(txtClave.Text) || string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Debe completar la información");
                return;
            }

            clases.roles B = new clases.roles(byte.Parse(txtClave.Text));
            DataSet ds = new DataSet();
            c = new clases.conexion(B.CONSULTARI());
            ds = c.consultar();
            g = new clases.roles(byte.Parse(txtClave.Text), txtNom.Text);

            if (ds.Tables["Tabla"].Rows.Count > 0)
                c = new clases.conexion(g.modificar());
            else
                c = new clases.conexion(g.GRABAR());
            MessageBox.Show(c.ejecutar());
        }

        private void Froles_Load(object sender, EventArgs e)
        {
            cargarfolio();
        }
        void cargarfolio()
        {
            B = new clases.roles();
            DataSet ds = new DataSet();
            c = new clases.conexion(B.CONSULTARI());
            ds = c.consultar();
            if (ds.Tables["Tabla"].Rows.Count > 0)
            {
                txtClave.Text = ds.Tables["Tabla"].Rows[0]["IDCLAVE"].ToString();
                txtNom.Text = ds.Tables["Tabla"].Rows[0]["NOMBRE"].ToString();
            }
        }

        private void tsBtnImprimir_Click(object sender, EventArgs e)
        {
            Catalagos.Plantillas P = new Catalagos.Plantillas();
            Cursor.Current = Cursors.WaitCursor;

            Catalagos.CrystalReport2 orptPrueba;
            ConnectionInfo oConexInfo;
            Tables oListaTablas;
            TableLogOnInfo oTablaConexInfo;
            oConexInfo = new ConnectionInfo();
            oConexInfo.ServerName = clases.global.server;
            oConexInfo.DatabaseName = clases.global.db;

            Boolean IntegratedSecurity = false;
            oConexInfo.IntegratedSecurity = IntegratedSecurity;
            oConexInfo.UserID = clases.global.usuario;
            oConexInfo.Password = clases.global.password;
            oConexInfo.DatabaseName = clases.global.db;
            oConexInfo.Type = ConnectionInfoType.Query;

            //orptPrueba = new rptventasperiodo();
            orptPrueba = new CrystalReport2();
            oListaTablas = orptPrueba.Database.Tables;
            foreach (Table roTabla in oListaTablas)
            {
                oTablaConexInfo = roTabla.LogOnInfo;
                oTablaConexInfo.ConnectionInfo = oConexInfo;
                roTabla.ApplyLogOnInfo(oTablaConexInfo);
            }

            DateTimeFormatInfo dtinfo = new CultureInfo("es-ES", false).DateTimeFormat;

            /*if (!(string.IsNullOrEmpty(txtboletai.Text)))
                    orptPrueba.SetParameterValue("@FOLIOBOLETA", int.Parse(txtboletai.Text));
                else

                MessageBox.Show("Por favor introduzca el Número de Boleta",     "Advertencia",
            MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
            */

            P.crystalReportViewer1.ReportSource = orptPrueba;
            P.ShowDialog();
            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void tsBtnEliminar_Click(object sender, EventArgs e)
        {
            txtClave.Clear();
            txtNom.Clear();
        }

        private void tsBtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

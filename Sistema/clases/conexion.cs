using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Clase que sirve para conectarnos al sql
using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Sistema.clases
{
    class conexion
    {
        //Variable
        private string sentencia1;

        //Crear los objetos
        private SqlConnection conn = new SqlConnection();
        private SqlCommand cmd;

        public conexion()
        {

        }
        //Constructor
        public conexion(string sentencia1)
        {
            this.sentencia1 = sentencia1;
        }

        //Metodo para crear la conexion a la base de datos
        public string ejecutar()
        {
            conn.ConnectionString = clases.global.miconexion;
            if (conn.State != ConnectionState.Open)
            {
                conn.Close();
                conn.Open();
            }
            cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sentencia1;
            cmd.ExecuteNonQuery();
            conn.Close();
            return "Operación exitosa";
        }
        //Metodo
        public DataSet consultar()
        {
            DataSet datos = new DataSet();
            conn = new SqlConnection(clases.global.miconexion);
            if (conn.State != ConnectionState.Open)
            {
                conn.Close(); conn.Open();
            }
            SqlDataAdapter resp = new SqlDataAdapter(sentencia1, conn);
            resp.Fill(datos, "Tabla");
            conn.Close();
            return datos;
        }
        private string mFieldValue;
        internal string FieldValue
        {
            get { return mFieldValue; }
        }
        internal bool Execute(string SQL, int ColumnNumberToRetrive)
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(SQL,clases.global.miconexion);
            da.Fill(ds, "Table");

            formularios.SearchForm frmSearchForm = new formularios.SearchForm();
            frmSearchForm.mColNumber = ColumnNumberToRetrive;
            frmSearchForm.mDS = ds;
            ds = null;
            frmSearchForm.ShowDialog();
            if (frmSearchForm.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                mFieldValue = frmSearchForm.ReturnValue;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class usuario
    {
        private string usu_login;
        private string usu_pass;
        //private string usu_nom;


        //Constructor
        public usuario(string usu_login, string usu_pass)
        {
            this.usu_login = usu_login;
            this.usu_pass = usu_pass;
            //this.usu_nom = usu_nom;
        }
        //Metodo constructor consultar
        public usuario(string usu_login)
        {
            this.usu_login = usu_login;
        }

        public usuario()
        {

        }

        //metodos
        public string GRABAR()
        {
            return ("insert into USUARIO values ('" + this.usu_login + "','" + this.usu_pass + "')");
        }
        public string CONSULTARI()
        {
            return ("SELECT * FROM USUARIO WHERE NOMBRE =  '" + this.usu_login + "' AND CONTRA = dbo.MD5('" + this.usu_pass + "')");
        }
        public string modificar()
        {
            return ("update USUARIO set USUARIO ='" + this.usu_login + "' WHERE CONTRA = '" + this.usu_pass + "'");
        }
        public string consultageneral()
        {
            return (" SELECT IDUSUARIO as IDUSUARIO, NOMBRE as NOMBRE, CONTRA as CONTRA, IDCLAVE as IDCLAVE FROM  USUARIO");
        }
        public string consecutivo()
        {
            return ("select MAX(IDUSUARIO) + 1 as folio from USUARIO ");
        }
        
    }

}

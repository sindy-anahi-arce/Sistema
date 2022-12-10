using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class CdatGenerales
    {
        private string nomempresa;
        private string direccion;
        private string telefono;
        private string gerente;

        //Metodo constructor para grabar y editar
        public CdatGenerales(string nomempresa, string direccion, string telefono, string gerente)
        {
            this.nomempresa = nomempresa;
            this.direccion = direccion;
            this.telefono = telefono;
            this.gerente = gerente;
        }

        public CdatGenerales()
        {

        }
        //Metodo constructor consultar
        public CdatGenerales(string nomempresa)
        {
            this.nomempresa = nomempresa;
        }

        public string Grabar()
        {
            return ("insert into DATOS_GENERALES values ('" + this.nomempresa + "', '" + this.direccion + "', '" + this.telefono +"', '" + this.gerente +"')");
        }

        public string Consultari()
        {
            return ("SELECT * FROM DATOS_GENERALES WHERE NOMEMPRESA = '" + this.nomempresa + "'");
        }

        public string Modificar()
        {
            return ("update DATOS_GENERALES set DATOS_GENERALES = '" +this.direccion+"', '"+this.telefono+"', '"+this.gerente+"' WHERE NOMEMPRESA ='" + this.nomempresa + "'");
        }

        public string Consultageneral()
        {
            return ("SELECT NOMEMPRESA as NOMEMPRESA, DIRECCION as DIRECCION, TELEFONO AS TELEFONO, GERENTE AS GERENTE FROM DATOS_GENERALES");
        }

        public string Consecutivo()
        {
            return ("select MAX(id_nombre) + 1 as folio from DATOS_GENERALES");
        }
    }
}

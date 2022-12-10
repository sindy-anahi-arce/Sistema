using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class roles
    {
        private byte id;
        private string nombre;

        //metodo constructor para grabar y editar
        public roles(byte id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        //Metodo constructor consultar
        public roles(byte id)
        {
            this.id = id;
        }

        public roles()
        {

        }

        public string GRABAR()
        {
            return (" insert into ROL values ('" + this.id + "','" + this.nombre + "')");
        }
        public string CONSULTARI()
        {
            return (" SELECT * FROM  ROL WHERE IDCLAVE = '" + this.id + "'");
        }
        public string modificar()
        {
            return (" update ROL set NOMBRE ='" + this.nombre + "' WHERE IDCLAVE = '" + this.id + "'");
        }
        public string consultageneral()
        {
            return (" SELECT IDCLAVE as IDCLAVE, NOMBRE as NOMBRE FROM  ROL");
        }
        public string consecutivo()
        {
            return ("select MAX(IDCLAVE) + 1 as folio from ROL ");
        }
    }

    }

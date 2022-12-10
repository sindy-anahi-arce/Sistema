using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class Cmodulos
    {
        private byte id_nombre;
        private string nombre_modulo;

        //metodo constructor para grabar y editar
        public Cmodulos(byte id_nombre, string nombre_modulo)
        {
            this.id_nombre = id_nombre;
            this.nombre_modulo = nombre_modulo;
        }

        //metodo constructor consultar
        public Cmodulos(byte id_nombre)
        {
            this.id_nombre = id_nombre;
        }

        public Cmodulos()
        {

        }
        public string Grabar()
        {
            return ("insert into MODULOS values ('" + this.id_nombre+"', '" + this.nombre_modulo + "')");
        }

        public string Consultari()
        {
            return ("SELECT * FROM MODULOS WHERE id_nombre = '" + this.id_nombre + "'");
        }

        public string Modificar()
        {
            return ("update MODULOS set nombre_modulo = '" + this.nombre_modulo + "' WHERE id_nombre ='" + this.id_nombre + "'");
        }

        public string Consultageneral()
        {
            return ("SELECT id_nombre as id_nombre, nombre_modulo as nombre_modulo FROM MODULOS");
        }

        public string Consecutivo()
        {
            return ("select MAX(id_nombre) + 1 as folio from MODULOS");
        }
    }
}

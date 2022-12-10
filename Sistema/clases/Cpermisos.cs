using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    class Cpermisos
    {
        private int id;
        private int id_rol;
        private byte id_modulo;
        private bool consultar;
        private bool grabar;
        private bool actualizar;
        private bool borrar;

        //metodo constructor para grabar y editar
        public Cpermisos(int id, int id_rol, byte id_modulo, bool consultar, bool grabar, bool actualizar, bool borrar)
        {
            this.id = id;
            this.id_rol = id_rol;
            this.id_modulo = id_modulo;
            this.consultar = consultar;
            this.grabar = grabar;
            this.actualizar = actualizar;
            this.borrar = borrar;
        }

        //metodo constructor consultar
        public Cpermisos(int id)
        {
            this.id = id;
        }

        public Cpermisos()
        {

        }
        public string Grabar()
        {
            return ("insert into PERMISOS values ('"  + this.id_rol + "', '" + this.id_modulo + "', '" + this.consultar + "', '" + this.grabar + "', '" + this.actualizar + "', '" + this.borrar + "')");
        }

        public string Consultari()
        {
            return ("SELECT * FROM PERMISOS WHERE id_rol = '" + this.id_rol + "'");
        }

        public string Modificar()
        {
            return ("update PERMISOS set PERMISOS = '" + this.id_rol + "', '"+this.id_modulo+"', '"+this.consultar+"','"+this.grabar+"', '"+this.actualizar+"','"+this.borrar+"' WHERE id = '" + this.id + "'");
        }

        public string Consultageneral()
        {
            return (" SELECT id_rol as id_rol, id_modulo as id_modulo, consultar as consultar, grabar as grabar, actualizar as actualizar, borrar as borrar FROM PERMISOS");
        }

        public string Consecutivo()
        {
            return ("select MAX(id) + 1 as folio from PERMISOS");
        }
    }
}

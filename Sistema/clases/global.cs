using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema.clases
{
    public static class global
    {
        static public string server = "SINDY_ARCE";
        static public string db = "BDABARROTE ";
        static public string usuario = "sa";
        static public string password = "ecra2529";

        static public string miconexion = @"Data source = " + server + ";Initial Catalog = " + db + "; Persist Security Info = True; User ID = sa; Password = " + password;
    }
}

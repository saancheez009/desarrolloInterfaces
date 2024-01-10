using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class clsConnection
    {    
        public static string connection()
        {

            return "server=britanydb.database.windows.net;database=britanydb;uid=prueba;pwd=fernandoG321;trustServerCertificate=true";
        }
    }
}

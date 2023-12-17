using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryDAL
{
    public class DBHelper
    {
        public static SqlConnection GetConnection()
        {

            SqlConnection con = new SqlConnection(@"Server=tcp:eu-az-sql-serv1.database.windows.net,1433;Initial Catalog=d3sxd3x0ems31qt;Persist Security Info=False;User ID=uv76v2xmjupncgz;Password=48UFIUPwu&2x9qz#c$8qnH#y3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return con;
        }
    }
}

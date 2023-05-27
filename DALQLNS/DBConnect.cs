using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALQLNS
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=MSI\MS_SQLSERVER;Initial Catalog=KTHP;Integrated Security=True");
    }
}

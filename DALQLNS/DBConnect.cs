using System.Data.SqlClient;

namespace DALQLNS
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection(@"Data Source=MSI\MS_SQLSERVER;Initial Catalog=KTHP;Integrated Security=True");
    }
}

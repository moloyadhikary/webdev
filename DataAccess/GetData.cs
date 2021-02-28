using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class GetData
    {
        public static string conString = "data source=103.231.162.5;initial catalog=EmployeeManagementDb;persist security info=True;user id=sa;password=(0nekJh@melA);";


        public DataTable GetAllEmployee()
        {
            DataTable dt = new DataTable();

            using(SqlConnection openCon=new SqlConnection(conString))
            {
              string sql = "SELECT * FROM EmployeeInformation";

              using(SqlCommand cmd = new SqlCommand(sql))
              {
                  cmd.Connection=openCon;
                  openCon.Open();
                  SqlDataAdapter da = new SqlDataAdapter(cmd);
                  da.Fill(dt);
              }
            }

            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DeleteData
    {
        public static string conString = "data source=103.231.162.5;initial catalog=EmployeeManagementDb;persist security info=True;user id=sa;password=(0nekJh@melA);";

        public void DeleteEmployee(int id)
        {
            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = $@"delete from EmployeeInformation where Id = {id}";

                using(SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection=openCon;
                    openCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

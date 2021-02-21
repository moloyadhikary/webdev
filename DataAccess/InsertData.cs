using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class InsertData
    {
        public static string conString = "data source=103.231.162.5;initial catalog=EmployeeManagementDb;persist security info=True;user id=sa;password=(0nekJh@melA);";

        public void InsertEmployee(string firstName, string lastName, string employeeId, int department, decimal basicSalary )
        {
            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = $@"INSERT INTO [dbo].[EmployeeInformation]
                                    ([FirstName]
                                ,[LastName]
                            ,[EmployeeId]
                            ,[DepartmentId]                            
                            ,[BasicSalary])
                            VALUES
                                ('{firstName}', '{lastName}', '{employeeId}', {department}, {basicSalary})";

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

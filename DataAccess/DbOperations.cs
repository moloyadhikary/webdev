using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DbOperations
    {
        public static string conString = "data source=103.231.162.5;initial catalog=EmployeeManagementDb;persist security info=True;user id=sa;password=(0nekJh@melA);";


        public DataTable GetAllEmployee()
        {
            DataTable dt = new DataTable();

            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = @"SELECT 
                                e.*
                                    ,d.Name DepartmentName
                                FROM EmployeeInformation e
                                    LEFT JOIN Departments d ON e.DepartmentId = d.Id";

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
        
        public DataTable GetEmployeeDetailsById(int id)
        {
            DataTable dt = new DataTable();

            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = $@"select 
	                            e.*
	                            ,d.Name DepartmentName
                            from
	                            EmployeeInformation e
	                            left join Departments d on e.DepartmentId = d.Id
                            where e.id = {id}";

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

        public DataTable GetAllDepartments()
        {
            DataTable dt = new DataTable();

            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = "select * from Departments";

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
        
        public void DeleteEmployee(int id)
        {
            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = $"delete from EmployeeInformation where Id = {id}";

                using(SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection=openCon;
                    openCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployee(int id, string firstName, string lastName, decimal salary, int departmentId, string employeeId)
        {
            using(SqlConnection openCon=new SqlConnection(conString))
            {
                string sql = $@"update EmployeeInformation set 
	                                FirstName = '{firstName}',
	                                LastName = '{lastName}',
	                                EmployeeId = '{employeeId}',
	                                DepartmentId={departmentId},
	                                BasicSalary = '{salary}'
                                where Id = {id}";

                using(SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection=openCon;
                    openCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateEmployeeStatus(int id, int status)
        {
            using (SqlConnection openCon = new SqlConnection(conString))
            {
                string sql = $@"update EmployeeInformation set 
	                                IsCurrent = {status}
                                where Id = {id}";

                using (SqlCommand cmd = new SqlCommand(sql))
                {
                    cmd.Connection = openCon;
                    openCon.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

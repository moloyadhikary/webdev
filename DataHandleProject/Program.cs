using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataHandleProject
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //InsertData insertData = new InsertData();
            DbOperations dbOperations = new DbOperations();
            //insertData.InsertEmployee("Tahsan", "Khan", "E112", 1, 20000);
            
            //dbOperations.UpdateEmployee(1, "ABCD");
            
            ReadData:
            //GetData getData = new GetData();
            Console.WriteLine("Reading data");
            
            DataTable departments = dbOperations.GetAllDepartments();
            Console.WriteLine(departments.Rows.Count + " departments found");

            for (int i = 0; i < departments.Rows.Count; i++)
            {
                Console.WriteLine();
                Console.Write(departments.Rows[i]["Id"]);
                Console.Write(". ");
                Console.Write(departments.Rows[i]["Name"]);
            }
            
            Console.WriteLine(" ");
            
            DataTable dt = dbOperations.GetAllEmployee();
            Console.WriteLine(dt.Rows.Count + " Data found");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine();
                Console.Write(dt.Rows[i]["Id"]);
                Console.Write(". ");
                Console.Write(dt.Rows[i]["FirstName"]);
                Console.Write(" ");
                Console.Write(dt.Rows[i]["LastName"]);
            }
            Console.WriteLine(" ");
            
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine();
            //    Console.Write(dr["FirstName"]);
            //    Console.Write(" ");
            //    Console.Write(dr["LastName"]);
            //}
            Console.WriteLine("Insert the Id you want to delete: ");
            var idToDelete = Convert.ToInt32(Console.ReadLine());
            dbOperations.DeleteEmployee(idToDelete);

            goto ReadData;
            //Console.ReadLine();

        }
    }
}

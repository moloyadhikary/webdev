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
            InsertData insertData = new InsertData();
            insertData.InsertEmployee("Tahsan", "Khan", "E112", 1, 20000);
            
            
            GetData getData = new GetData();
            Console.WriteLine("Reading data");
            DataTable dt = getData.GetAllEmployee();
            Console.WriteLine(dt.Rows.Count + " Data found");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine();
                Console.Write(dt.Rows[i]["FirstName"]);
                Console.Write(" ");
                Console.Write(dt.Rows[i]["LastName"]);
            }

            
            //foreach (DataRow dr in dt.Rows)
            //{
            //    Console.WriteLine();
            //    Console.Write(dr["FirstName"]);
            //    Console.Write(" ");
            //    Console.Write(dr["LastName"]);
            //}

            Console.ReadLine();
        }
    }
}

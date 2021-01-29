using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Program
    {
        static void MainOld(string[] args)
        {
            int age = 10;
            //Console.WriteLine(age);

            age = 20;
            //Console.WriteLine(age);

            Student obj = new Student();
            int c = obj.Add(10, 20);
            //Console.Write(c);

            int d = obj.CalculateYear(1976);
            //Console.WriteLine(d);
                
            //Console.WriteLine("Enter your name: ");
            //string abc = Console.ReadLine();
            Console.WriteLine("Enter your birth year: ");
            string userAge = Console.ReadLine();
            var userAgeC = obj.CalculateYear(Convert.ToInt32(userAge));
            Console.WriteLine("Year age is: " + userAgeC.ToString() + " years");
            
            var abc = Console.ReadLine();
        }
    }

    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }


        public int Add(int a, int b)
        {
            int addedValue = a + b;
            int dev = addedValue / 2;
            return dev;
        }

        public int CalculateYear(int year)
        {
            int current = DateTime.Now.Year;
            int result = current - year;
            return result;
        }
    }
}

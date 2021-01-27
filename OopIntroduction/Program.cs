using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 10;
            Console.WriteLine(age);

            age = 20;
            Console.WriteLine(age);
            

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
            return a + b;
        }
    }
}

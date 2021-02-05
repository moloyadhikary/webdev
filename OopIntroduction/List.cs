using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class List
    {
        public static void Main(string[] args)
        {
            List<string> abc = new List<string>();
            abc.Add("Moloy");
            abc.Add("Shabab");


            Console.WriteLine(abc[1]);
            Console.ReadLine();
        }
    }
}

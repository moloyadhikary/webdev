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
            abc.Add("Name");

            foreach (var name in abc)
            {
                Console.WriteLine(name);
            }




            Calculator calc = new Calculator();
            var value = calc.multiply(3, 4);


            int a, b;

            if (value > 100)
            {
                a = 10;
            }
            else
            {
                a = 20;
            }
            

            Console.WriteLine(abc[1]);
            Console.ReadLine();
        }
    }
}

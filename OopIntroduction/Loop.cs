using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Loop
    {
        public static void MainLoop(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            for (int abc = 1; abc <= number; abc++)
            {
                Console.WriteLine(abc);
            }

            Console.ReadLine();
        }
    }
}

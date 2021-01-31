using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class TypeCast
    {
        public static void MainTypeCast(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var chocie = Console.ReadLine();
            int actualChoice = Convert.ToInt32(chocie); 

            Console.ReadLine();
        }
    }
}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class IfElse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You are above 18?");
            string userInput = Console.ReadLine();
             
            if (userInput == "Yes")
            {
                Console.WriteLine("You are an adult");
            }
            else if (userInput == "Y")
            {
                Console.WriteLine("You are an adult");
            }
            else if (userInput == "y")
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("Hello kid!");
            }





            string abc = Console.ReadLine();
        }
    }
}

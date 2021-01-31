using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Switch
    {
        static void MainSwitch(string[] args)
        {
            Looper:
            Console.WriteLine("1. Tea");
            Console.WriteLine("2. Coffee");
            Console.WriteLine("3. Milk");
            Console.WriteLine("4. Mango Juice");
            Console.WriteLine("5. Milk Shake");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("You chose to have tea");
                    break;
                case "2":
                    Console.WriteLine("You chose to have coffee");
                    break;
                case "3":
                    Console.WriteLine("You chose to have milk");
                    break;
                case "4":
                    Console.WriteLine("You chose to have mango juice");
                    break;
                case "5":
                    Console.WriteLine("You chose to have milk shake");
                    break;
                default:
                    Console.WriteLine("You made an invalid choice");
                    goto Looper;
                    break;
            }


            Console.ReadLine();
        }
    }
}

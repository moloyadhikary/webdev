using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class HwOop1
    {
        public static void MainHwOop1(string[] args)
        {
            TopLine:
            Console.WriteLine("1. Age calculator");
            Console.WriteLine("2. Number square");
            Console.Write("Please choose a task from above: ");
            var choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter your birth year: ");
                var birthYear =Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Your age is " + AgeCalculator(birthYear));
                goto TopLine;
            }
            else
            {
                Console.Write("Enter a number: ");
                var number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number; i++)
                {
                    for (int j = 1; j <= number; j++)
                    {
                        Console.Write(i.ToString());
                    }

                    Console.Write(Environment.NewLine);
                }
                goto TopLine;
            }
        }

        public static int AgeCalculator(int birthYear)
        {
            var age = DateTime.Now.Year - birthYear;
            return age;
        }
    }
}

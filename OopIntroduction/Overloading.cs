using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    public class Overloading
    {
        public static void MainOverloading(string[] args)
        {
            Console.Write("Your birth year: ");
            var birthYear = Console.ReadLine();
            var birthYearInt = Convert.ToInt32(birthYear);
            var age = AgeCalculator(birthYear);

        }

        public static int AgeCalculator(int birthYear)
        {
            var age = DateTime.Now.Year - birthYear;
            return age;
        }

        public static int AgeCalculator(string birthYear)
        {
            var age = DateTime.Now.Year - Convert.ToInt32(birthYear);
            return age;
        }
    }
}

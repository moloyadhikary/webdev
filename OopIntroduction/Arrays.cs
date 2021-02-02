using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Arrays
    {
        public static void MainArray(string[] args)
        {
            string[] userFav = new string[2];
            int[] intAr = new int[20];


            Console.WriteLine("Fav food: ");
            userFav[0] = Console.ReadLine();

            Console.WriteLine("Fav book: ");
            userFav[1] = Console.ReadLine();
            
            Console.WriteLine("================================");
            Console.WriteLine(userFav[0]);
            Console.WriteLine(userFav[1]);

            Console.Read();
        }
    }
}

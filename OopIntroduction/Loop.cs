using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OopIntroduction
{
    class Loop
    {
        public static void MainLoop(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number: ");
                int number = 2;
                number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number; i += 1)
                {
                    for (int j = 1; j <= i; j += 1)
                    {
                        Console.Write("*");
                    }

                    Console.Write(Environment.NewLine);
                }

                Console.ReadLine();
            }
            catch (Exception e)
            {
                Environment.Exit(0);
            }


        }
    }
}

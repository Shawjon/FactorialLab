using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialLab
{
    class Program
    {
        static void Main(string[] args)
        {
            bool yesNo = true;
            int x;
            long factorial;
            Console.WriteLine("Welcome to the Factorial Calculator!");
            Console.WriteLine("");
            while (yesNo == true)
            {
                try
                {
                    Console.Write("Enter an integer that's greater than 0 but less than 10: ");
                    x = Convert.ToInt32(Console.ReadLine());
                    if (x > 10)
                    {
                        Console.WriteLine("That is not an option to pick");
                        continue;
                    }
                    else if (x <1)
                    {
                        Console.WriteLine("That is not a valid option");
                        continue;
                    }


                    factorial = GetFactorial(x);
                    Console.WriteLine("The factorial of " + x + " is " + factorial + ".");
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid inut");
                }

                Console.Write("Continue? (y/n): ");
                string entry = Console.ReadLine();
                while (entry.ToLower() != "n" || entry.ToLower() != "y" || entry.ToLower() != "no" || entry.ToLower() != "yes")
                {
                    if (entry.ToLower() == "n" || entry.ToLower() == "no")
                    {
                        yesNo = false;
                        ///entry = "n";
                        break;
                    }
                    else if (entry.ToLower() == "y" || entry.ToLower() == "yes")
                    {
                        yesNo = true;
                        ///entry = "y";
                        break;
                    }
                    else
                    {
                        Console.Write("That is not a valid answer, Continue? (y/n): ");
                        entry = Console.ReadLine();
                    }
                }
            }

        }
        public static long GetFactorial (int x)
        {
            if (x == 0)
            {
                return 1;
            }
            return x * GetFactorial(x - 1);
        }
    }
}

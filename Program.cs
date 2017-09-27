using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run == true)
            {
                Console.WriteLine("Learn your squares and cubes!");
                Console.WriteLine("Enter a whole number between 0 and 10: ");
                string number = Console.ReadLine();
                int numVal = Int32.Parse(number);
                

                Console.WriteLine("Number..." + "Square Root" + "...Cube Root");

                for (int i = 0; i < numVal + 1; i++)
                {
                //    Console.WriteLine("i is " + i);
                //    Console.WriteLine(i + " " + run + " " + numVal);
                // Compute square roots by calling Math.Sqrt.
                    double squareRoot = Math.Sqrt(i);
                    squareRoot = Math.Round(squareRoot, 2);

                    double cubeRoot = Math.Pow(i, 1.0/3.0);
                    cubeRoot = Math.Round(cubeRoot, 2);
                    //Console.WriteLine("cube root is " + cubeRoot);

                    Console.WriteLine(i + "........" + squareRoot + "....." + cubeRoot);

                }
                run = Continue();
                
            }
        }

        public static bool Continue()
        {
            Console.WriteLine("Do you wish to Continue? y/n");
            string input = Console.ReadLine();
            input = input.ToLower();
            bool goOn;
            if (input == "y")
            {
                goOn = true;
                SquaresAndCubes();
            }
            else if (input == "n")
            {
                goOn = false;
            }
            else
            {
                //So this is a neat trick call recursion, it involves calling a method inside a method
                //In a sense it's another way of doing a loop, but using methods 
                //it works in much the same way, it's divided into two parts: 
                //a step and an end condition. 
                Console.WriteLine("I don't understand that, let's try again");
                goOn = Continue();
            }
            return goOn;
        }

        public static void SquaresAndCubes()
        {
            Console.WriteLine("We're gonna do squares and cubes now...");
            Console.WriteLine();
        }

    }
}

using System;

namespace Exercise15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 15");
            bool repeat = true;
            while (repeat)
            {
                //Prompt the user for input
                Console.WriteLine("Please enter a number greater than 0");
                string input = Console.ReadLine();
                int number = int.Parse(input);

                //The cube of i will be produced until i equals the number input by the user
                for (int i = 1; number >= i; i++)
                {
                    int cube = i * i * i;
                    Console.WriteLine(cube);
                }
                //prompt the user for additional input
                Console.WriteLine("Enter another number? y/n");
                string answer = Console.ReadLine();

                if (answer == "y")
                {
                    //An answer if "y" will repeat the program
                    repeat = true;
                }
                else
                {
                    //Any answer other than "y" will terminate the program
                    Console.WriteLine("Goodbye!");
                    repeat = false;
                }
            }
        }
    }
}

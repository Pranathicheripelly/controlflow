using System;

namespace controlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
            // Demonstrating control flow constructs

            // if-else statement
            int num = 10;
            if (num > 5)
            {
                Console.WriteLine("Number is greater than 5.");
            }
            else
            {
                Console.WriteLine("Number is not greater than 5.");
            }

            // switch statement
            int choice = 2;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You chose option 1");
                    break;
                case 2:
                    Console.WriteLine("You chose option 2");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            // while loop
            int count = 0;
            while (count < 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

            // foreach loop
            string[] colors = { "Red", "Green", "Blue" };
            foreach (string color in colors)
            {
                Console.WriteLine("Color: " + color);
                Console.ReadLine();
            }
        }
    }
}



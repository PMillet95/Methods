/*
  Author: Peter Millet
  Date: 01/26/2019
  Comment: A program that uses more than one method
*/


using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            Console.ReadKey(true);
            // This code asks the user to type their name

            try
            {
                string userinput = Console.ReadLine();

                USER_INPUT(userinput);

                // This code saves the user name as a string and USER_INPUT allows us to use it in another method
            }
            catch
            {
                Console.WriteLine("An error occured");
                Console.WriteLine("Press any key to close the program");
                Console.ReadKey(true);
                // If an error were to occur then this message would appear
            }
        }

        private static void USER_INPUT(string userinput)
        {
            Console.WriteLine("Hello " + userinput);
            Console.WriteLine("Press any key to close the program");
            Console.ReadKey(true);
            // The second method which takes what the user entered and displays it on the console
        }
    }
}

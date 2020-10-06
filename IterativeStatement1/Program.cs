//Author: Elliot Vasquez
//ISM 4300 - Tech Assignment #2
//Comment: This C# console will demonstrate the execution of an iterative statement using a while loop.



using System;

namespace IterativeStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            //This line will allow the user to input an integer.
            Console.WriteLine("Please enter an integer value between 1 and 20 to execute an iterative statement:");

            //Beginning of the try/catch command.
            try
            {
                // This command will receive data from the user's input.
                string input = Console.ReadLine();

                //This command will be used to perform the iterative statement and parses an integer.
                int value_of_input = int.Parse(input);

                //This IF/ELSE command is used to test the values of user input.

                //A while loop will execute if the user inputs a value between 1 and 30.
                if ((value_of_input > 0) && (value_of_input <= 30))
                {
                    Console.WriteLine("Executing a WHILE LOOP!!!");
                    Console.WriteLine("Your WHILE LOOP will iterate " + value_of_input.ToString() + " times");

                    //Alah, the while loop :-) .
                    while (value_of_input > 0)
                    {
                        Console.WriteLine("The value of the iterative variable is: " + value_of_input.ToString());
                        value_of_input--;
                    }
                    Console.WriteLine("Press any key to exit the program!");
                    Console.ReadKey(true);
                }
            }
            catch
            {
                //The end of the try/catch command.

                Console.WriteLine("Please enter an appropriate integer value and try again");
                Console.WriteLine("Press and key to exit the program");
                Console.ReadKey(true);
            }
        }
    }
}
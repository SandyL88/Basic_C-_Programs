using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace Exception_Handling_Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list of integers
            List<int> intList = new List<int>()
            {5, 99,16,18,63,7,94,61,63,22 };
            //Ask the user for input and loop through the list dividing each number by the input.
            bool numValid = false;
            while (!numValid)
            {
                //Using a try/catch block to give error message
                try
                {
                    Console.WriteLine("\nEnter a number to divided the above list by： ");
                    float numDivide = float.Parse(Console.ReadLine());
                    //if statement to check if the user entered 0
                    if (numDivide == 0)
                    {
                        Console.WriteLine("Please enter a number other than 0.");
                    }
                    //Dividing each number in the list by the input
                    else
                    {
                        foreach (int num in intList)
                        {
                            float Divide = num / numDivide;
                            Console.WriteLine(num + "/" + numDivide + " = " + Divide);
                        }
                        numValid = true;
                    }
                }
                //catch block th display error message for string input
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a number: ");
                }

            }
            
            //Message to let the user know the program has exited the try/catch blosk
            Console.WriteLine("The program has exited the try/catch block.");
            Console.ReadLine();
        }
    }
}

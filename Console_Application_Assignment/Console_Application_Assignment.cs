//1.	Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: make sure your code can take inputs larger than 10,000,000).
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            double userInput = Convert.ToDouble(Console.ReadLine());

            //1.1.	Takes an input from the user, multiplies it by 50, then prints the result to the console. (Note: 
            //make sure your code can take inputs larger than 10,000,000).
            double result = userInput * 50;
            Console.WriteLine("The result of multiplying your input by 50 is: " + result);

            // 2.Takes an input from the user, adds 25 to it, then prints the result to the console.
            double resultQ2 = userInput + 25;
            Console.WriteLine("The result of adding 25 to your input is: " + resultQ2);

            // 3.Takes an input from the user, divides it by 12.5, then prints the result to the console.
            double resultQ3 = userInput / 12.5;
            Console.WriteLine("The result of dividing your input by 12.5 is: " + resultQ3);

            // 4.Takes an input from the user, checks if it is greater than 50, then prints the true / false result to the console.
            bool isGreaterThanFifty = userInput > 50;
            Console.WriteLine("Is your input greater than 50? " + isGreaterThanFifty);

            // 5.Takes an input from the user, divides it by 7, then prints the remainder to the console(tip: think % operator).
            double remainder = userInput % 7;
            Console.WriteLine("The remainder when your input is divided by 7 is: " + remainder);
        }
    }
}

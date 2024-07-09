using System;
using System.Collections.Generic;
using System.Security.AccessControl;

/*Create a one-dimensional Array of strings.
 * Ask the user to select an index of the Array and then display the string at that index on the screen.

Create a one-dimensional Array of integers. 
Ask the user to select an index of the Array and then display the integer at that index on the screen.

Add in a message that displays when the user selects an index that doesn’t exist.

Create a list of strings. 
Ask the user to select an index of the list and then display the content at that index on the screen.

Add comments to each line or block of your code to explain what it does exactly, so that another developer could read and understand your code. */

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of strings
            string[] colorArray = { "Red", "Orange", "Yello", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            //ask the user for a number
            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());

            bool validString = false;

            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect] + ".");
                    validString = true;
                }
                //Add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selectionis invalid. Please select a number between0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //List of strings
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast Host",
                "Software Developer",
                "QA tester"
            };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;

            while (!validList) 
            {
                try 
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect] + ".");
                    validList = true;
                }
                //Add message to display if the user picks an index that doesn't exit
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 to 9:");
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Array of integers
            int[] intArray = { 17, 52, 15, 19, 44, 85, 2, 96, 77 };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect a third number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;

            while (!validInt) 
            {
                try 
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect] + ".");
                    validInt = true;
                }    
                catch
                {
                    Console.WriteLine("Sorry, that number select is invalid. Select a number between 0 ant 9:");
                    intSelect = Convert.ToInt32(Console.ReadLine());

                }
                
            }
            Console.ReadLine();
        }
    }
}

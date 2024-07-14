using System;

namespace Method_and_Objects_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inside of the Main method, instantiate and initialize on Employee object with
            //the first name "Sample" and the last name "Student"
            Employee sam = new Employee() { FirstName = "Sample", LastName = "Student" };
            //Call the superclass method SayName() on the Employee object
            sam.SayName();
            Console.ReadLine();
        }
    }
}

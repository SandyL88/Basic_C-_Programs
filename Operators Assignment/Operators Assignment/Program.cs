using System;


namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee { Id = 1, FirstName = "Jessie", LastName = "Dodge" };
            Employee emp2 = new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" };

            bool areEqual = emp1== emp2;
            Console.WriteLine($"Employee 1 and Employee 2 are equal: {areEqual}");
            
            bool areNotEqual = emp2 != emp1;
            Console.WriteLine($"Employee 1 and Employee 2 are not equal: {areNotEqual}");

            Console.ReadLine();
        }
    }
}

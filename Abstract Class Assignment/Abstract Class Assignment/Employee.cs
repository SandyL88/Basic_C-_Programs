//Employee.cs
using System;

namespace Abstract_Class_Assignment
{
    //Create another class, "Employee" and have it inherit from the Person class
    //Implemented the IQuittable interface.
    public class Employee: Person, IQuittable
    {
        public int Id { get; set; }
        //Implement the SayName() method inside of the Employee class
        
        public override void SayName()
        {
            Console.WriteLine("Name: "+ firstName + " " + lastName);
        }

        public void Quit()
        {
            Console.WriteLine($"{firstName} {lastName} has quit.");
        }
    }
}

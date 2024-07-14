//program.cs
using System;

namespace Abstract_Class_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, instantiate an Employee object
            Employee sam = new Employee() { firstName = "Didadi", lastName = "Student" };
            //Call the Sayname method on the object
            sam.SayName();
            //Used polymorphism to create an IQuittable object quittableSam by assigning the sam object to it.
            IQuittable quittableSam = sam;
            //Called the Quit() method on the quittableSam object.
            quittableSam.Quit();

            Console.ReadLine();
        }
    }
}

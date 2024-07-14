using System;

namespace Method_and_Objects_Assignment
{
    public class Person
    {
        //Create a class called Person and give it two properties, 
        //each of data type string, called FirstName and LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //Give the class a void method called SayName() that takes no
        //parameters and simply writes the person's full name to the 
        //console in the format of : "Name: [full name]"
        public void SayName()
        {
            Console.WriteLine("Name: " + this.FirstName + " " +  this.LastName);
        }
    }
}

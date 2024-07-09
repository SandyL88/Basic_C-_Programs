using System;

namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MainMethods2 class
            MathMethods2 math1 = new MathMethods2();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7));
            //Call the second method with an decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            //Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("8"));
            
            Console.ReadLine();
        }
       
    }
}

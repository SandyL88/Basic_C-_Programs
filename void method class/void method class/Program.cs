using System;

namespace void_method_class
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOps = new MathOperations();

            mathOps.PerformOperation(3, 9);

            mathOps.PerformOperation(num1:5, num2:10);

            Console.ReadLine();
        }
    }
}

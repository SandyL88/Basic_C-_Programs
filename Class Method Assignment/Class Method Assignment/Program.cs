using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main() method, instantiate the class
            VoidMethod math = new VoidMethod();
            
            //Call the void method
            Console.WriteLine("Input a number: ");
            int dividend = Convert.ToInt32(Console.ReadLine());
            math.MathOp(dividend);
            Console.WriteLine(math.Value);
            Console.ReadLine();

            //Call the method with output parameters
            Console.WriteLine("Input a phrase: ");
            string input = Console.ReadLine();
            //调用 StringCounter 方法，计算字符串的长度，并通过输出参数返回
            string phrase = math.StringCounter(input, out int count);
            //输出字符串的长度信息
            Console.WriteLine(phrase);
            Console.WriteLine("Doubled would be: " + (count * 2));
            //输出字符串长度的两倍值
            Console.ReadLine();

            //Call the overloaded method
            Console.WriteLine("Input another phrase: ");
            string input2 = Console.ReadLine();
            int phrase2_len = math.StringCounter(input2);
            //调用重载的 StringCounter 方法，返回字符串的长度
            Console.WriteLine("This phrase is " + phrase2_len + " characters long");
            //输出字符串的长度
            Console.ReadLine();

            //Call the method of the static class
            Console.WriteLine("Input another phrase: ");
            string input3 = Console.ReadLine();
            int i_count = VoidMethod.StaticVoidMethod.Ifinder(input3);
            //调用静态类 StaticVoidMethod 中的 Ifinder 方法，计算字符串中 i 字符的数量
            Console.WriteLine("This phrase has " + i_count + " i's in it.");
            //输出 i 字符的数量
            Console.ReadLine();

        }
    }
}

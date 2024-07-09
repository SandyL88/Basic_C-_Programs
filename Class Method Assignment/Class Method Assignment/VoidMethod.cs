using System;

namespace Class_Method_Assignment
{
    public class VoidMethod
    {
        public int Value { get; private set; }
        //定义一个公共属性 Value，类型为 int，只能在类内部设置其值，但可以在外部读取

        public void MathOp(int num)
        {
            Value = num / 2;
        }
        public string StringCounter(string input, out int count)
        //定义一个 StringCounter 方法，接受一个字符串参数 input，并通过 out 参数返回字符串的长度
        {
            count = input.Length;
            //计算输入字符串的长度，并通过 out 参数 count 返回
            return $"The phrase '{input}' is {count} characters long.";
            //返回一个包含字符串长度信息的消息
        }

        public int StringCounter(string input)
        //定义一个重载的 StringCounter 方法，接受一个字符串参数 input，返回字符串的长度
        {
            return input.Length;
        }

        public static class StaticVoidMethod
        //声明一个静态类 StaticVoidMethod
        {
            public static int Ifinder(string input)
            //定义一个静态方法 Ifinder，接受一个字符串参数 input，返回字符串中 i 字符的数量
            {
                int count = 0;
                foreach (char c in input)
                //遍历输入字符串中的每个字符
                {
                    if (c == 'i' || c == 'I')
                    //如果字符是 'i' 或 'I'，则增加计数器
                    {
                        count++;
                    }
                }
                return count;
            }
        }
    }
}

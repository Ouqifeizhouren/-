using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 第一题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请分两行输入两个数字");
            double a, b, res = 0; string c;
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("请输入一个运算(+-*/)");
            c = Console.ReadLine();
            switch (c)
            {
                case "+":
                    res = a + b;
                    break;
                case "-":
                    res = a - b;
                    break;
                case "*":
                    res = a * b;
                    break;
                case "/":
                    if (b != 0)
                        res = a / b;
                    else { Console.WriteLine("除数不能为0！"); Console.ReadLine(); return; }
                    break;
            }
            Console.WriteLine("运算结果为{0}", res);
            Console.ReadLine();
        }
    }
}

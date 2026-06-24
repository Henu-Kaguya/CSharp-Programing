using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_MethodExample
{
    class Program
    {
        //值参数
        public void outSum(int x, int y)
        {
            x = x + 1;
            y = y + 1;
            int sum = x + y;
            Console.WriteLine("Sum:" + sum);
        }
        public void Test1()
        {
            int a = 2;
            int b = 3;
            outSum(a, b);
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }
        //引用参数
        public void outSum(ref int x, ref int y)
        {
            x = x + 1;
            y = y + 1;
            int sum = x + y;
            Console.WriteLine("Sum:" + sum);
        }
        public void Test2()
        {
            int a = 2;
            int b = 3;
            outSum(ref a, ref b);
            Console.WriteLine("a:" + a);
            Console.WriteLine("b:" + b);
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1();
            p.Test2();

            Console.ReadKey();
        }
    }
}

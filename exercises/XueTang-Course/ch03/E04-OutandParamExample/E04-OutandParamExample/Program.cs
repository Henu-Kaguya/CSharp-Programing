using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E04_OutandParamExample
{
    class Program
    {
        public void outSum(out int x, int y)
        {
            x = 3;
            int sum = x + y;
            Console.WriteLine("sum:" + sum);
        }
        public void Test2()
        {
            int a;
            int b = 3;
            outSum(out a, b);
            Console.WriteLine("a:" + a);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test2();

            Console.ReadKey();
        }
    }
}

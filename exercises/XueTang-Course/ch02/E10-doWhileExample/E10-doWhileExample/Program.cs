using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E10_doWhileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 4;
            int x = n;
            double result = 1;
            do
            {
                result *= x--;  
            } while (x > 1);
            Console.WriteLine("{0}的阶乘为：{1}", n, result);
            Console.ReadKey();

        }
    }
}

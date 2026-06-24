using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08_forExample
{
    class Program
    {
        //用for语句编写程序，输出九九乘法表
        static void Main(string[] args)
        {
            string s = "";
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    s += string.Format("{0}×{1}={2,2}{3,3}", j, i, i * j, ' ');
                }
                s += "\n";
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数：");
            string str = Console.ReadLine();
            int num = int.Parse(str);
            int pnum = num * num;
            Console.WriteLine("该数的平方是{0}", pnum);
            Console.ReadLine();
        }
    }
}

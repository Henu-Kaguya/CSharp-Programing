using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_ifExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入x的值：");
            string s = Console.ReadLine();
            if (int.TryParse(s, out int x) == false)
            {
                Console.WriteLine("请确保输入的数据是整数！按任意键继续...");
                Console.ReadKey();
            }
            int num;
            if (x > 0) 
                num= 1;
            else if (x == 0) 
                num= 0;
            else 
                num= -1;
            Console.WriteLine("结果为{0}",num);
            Console.ReadLine();
        }
    }
}

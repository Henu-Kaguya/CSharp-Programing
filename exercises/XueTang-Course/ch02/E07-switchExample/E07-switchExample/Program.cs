using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_switchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入成绩：");
            int.TryParse(Console.ReadLine(), out int grade);
            var result = "";
            if (grade < 0 || grade > 100)
            {
                result = "成绩不在0-100范围内";
            }
            else
            {
                switch (grade / 10)
                {
                    case 10:
                    case 9: result = "优秀"; break;
                    case 8:
                    case 7: result = "良好"; break;
                    case 6: result = "及格"; break;
                    default: result = "不及格"; break;
                }
            }
            Console.WriteLine("结果为:{0}",result);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E11_trycatchExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入x和y的值(逗号分隔)：");
            try
            {
                var s = Console.ReadLine().Split(',', '，');
                try
                {
                    double x = double.Parse(s[0]);
                    double y = double.Parse(s[1]);
                    if (y == 0) throw new Exception("除数不能为零！");
                    var z = Math.Round(x / y, 2, MidpointRounding.AwayFromZero);
                    Console.WriteLine(z);
                }
                catch (Exception err)
                {
                    Console.WriteLine($"出错了：{err.Message}");
                }
                finally
                {
                    Console.WriteLine("再见");
                }
            }
            catch
            {
                Console.WriteLine("输入不符合要求。");
            }
            Console.ReadKey();
        }
    }
}

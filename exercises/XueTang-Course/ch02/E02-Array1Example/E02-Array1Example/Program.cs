using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_Array1Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10, 20, 4, 8 };
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("初始值：{0}", string.Join(",", a)));
            sb.AppendLine(string.Format("平均值：{0}", a.Average()));
            sb.AppendLine(string.Format("和：{0}", a.Sum()));
            sb.AppendLine(string.Format("最大值：{0}", a.Max()));
            sb.AppendLine(string.Format("最小值：{0}", a.Min()));
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}

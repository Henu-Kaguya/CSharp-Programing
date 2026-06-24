using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_Array2Example
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 23, 64, 15, 72, 36 };
            int[] b = new int[a.Length];
            Array.Copy(a, b, a.Length);
            var s = $"原始整数数组：{string.Join(",", a)}\n";
            Array.Reverse(a);
            s += $"反转后的值：{string.Join(",", a)}\n";
            Array.Sort(b);
            s += $"升序排序后的值：{string.Join(",", b)}\n";
            Array.Reverse(b);
            s += $"降序排序后的值：{string.Join(",", b)}\n";
            Console.WriteLine(s);
            Console.WriteLine();
            string[] str = { "Java", "C#", "C++", "VB.NET" };
            var ss = $"原始数组：{string.Join(",", str)}\n";
            Array.Sort(str);
            ss += $"升序排序后的值：{string.Join(",", str)}\n";
            Console.WriteLine(ss);
            Console.ReadKey();
        }
    }
}

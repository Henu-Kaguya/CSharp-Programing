using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E08_ListExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>();
            a.Add(2);
            a.Add(7);
            a.Add(5);
            a.Remove(2);
            Console.WriteLine(a[1]);

            SortedList<int, string> alist = new SortedList<int, string>();
            alist.Add(7,"张三");
            alist.Add(2, "李四");
            string result;
            Console.WriteLine(alist.TryGetValue(2, out result));
            Console.ReadKey();
        }
    }
}

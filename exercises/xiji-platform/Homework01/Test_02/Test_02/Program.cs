using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            string str = Console.ReadLine();
            string[] strArr = str.Split(' ');
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(strArr[i]);
            }
            Console.WriteLine(arr.Max() + " " + arr.Min());
            Console.ReadKey();
        }

        private static void NewMethod()
        {
            int len = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[len];
            string str = Console.ReadLine();
            for (int i = 0; i < len; i++)
            {
                arr[i] = int.Parse(str.Split(' ')[i]);
            }
            Console.WriteLine(arr.Max() + " " + arr.Min());
            Console.ReadKey();
        }
    }
}

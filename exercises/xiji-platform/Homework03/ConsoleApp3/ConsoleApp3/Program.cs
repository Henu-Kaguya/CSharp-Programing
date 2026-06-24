using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void isNarcissus(int num)
        {
            int x = num;
            int[] y = new int[3];
            for (int i = 0; i < 3; i++)
            {
                y[i] = x % 10;
                x = x / 10;
            }
            if (y[0] * y[0] * y[0] + y[1] * y[1] * y[1] + y[2] * y[2] * y[2] == num)
            {
                Console.WriteLine(num);
            }
            else
            {
            }
        }
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            for (int i = 100; i <= x; i++)
            {
                isNarcissus(i);
            }
            Console.ReadLine();
        }
    }
}

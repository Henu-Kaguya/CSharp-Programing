using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            if (loop(str) == 1)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            Console.ReadKey();
        }

        static int loop(string x)
        {
            bool isLoop = true;
            for (int i = 0; i < x.Length / 2; i++)
            {
                if (x[i] != x[x.Length - i - 1])
                {
                    isLoop = false;
                    break;
                }
            }
            return isLoop ? 1 : 0;
        }
    }
}

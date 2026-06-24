using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[2];
            x = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            for(int i = x[0]; i <= x[1]; i++)
            {
                if(loop(i) == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static int loop(int x)
        {
            string str = Convert.ToString(x);
            bool isLoop = true;
            for (int i = 0; i < str.Length / 2; i++)
            {
                if(str[i] != str[str.Length - i - 1])
                {
                    isLoop = false;
                    break;
                }
            }
            return isLoop ? 1 : 0;
        }
    }
}

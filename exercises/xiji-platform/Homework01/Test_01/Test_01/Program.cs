using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            Console.WriteLine(x.Length);
            Console.WriteLine(x);
            for (int i = x.Length - 1; i >= 0; i--)
            {
                Console.Write(x[i]);
            }
            Console.ReadLine();
        }
    }
}

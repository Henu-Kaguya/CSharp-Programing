using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_02
{
    internal class Program
    {
        static void strend(string s,string t)
        {
            if (s.EndsWith(t))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            strend(s, t);
            Console.ReadKey();
        }
    }
}

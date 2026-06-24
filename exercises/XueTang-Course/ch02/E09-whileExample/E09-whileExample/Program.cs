using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E09_whileExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            string s = "";
            while (x <= 20)
            {
                if (x % 3 == 0) s += x.ToString() + " ";
                x++;
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_Array4Example
{
    class Program
    {
        static void Main(string[] args)
        {
            string[][] a =
            {
                new string[] { "a11", "a12" },
                new string[] { "a21", "a22", "a23" },
                new string[] { "a", "e", "i", "o", "u" }
            };
            string s = "";
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    s += $"{a[i][j]}\t";
                }
                s += "\n";
            }
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

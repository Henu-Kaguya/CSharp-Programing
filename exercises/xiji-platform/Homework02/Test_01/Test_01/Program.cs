using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Program
    {
        static void str_bin(char[] str1, char [] str2)
        {
            string str = new string(str1) + new string(str2);
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            str = new string(chars);
            Console.WriteLine(str);
        }

        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            char [] str1_arr = str1.ToCharArray();
            char [] str2_arr = str2.ToCharArray();
            str_bin(str1_arr, str2_arr);
            Console.ReadKey();
        }
    }
}

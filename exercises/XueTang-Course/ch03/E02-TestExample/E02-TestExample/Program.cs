using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_TestExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.M1();
            Console.ReadKey();
        }
    }
    class Test
    {
        public void M1()
        {
            Class1.x = 5;
            Class1.Method1();
        }
    }
    class Class1
    {
        public static int x = 100;
        public static void Method1()
        {
            Console.WriteLine(x);
        }
    }
}

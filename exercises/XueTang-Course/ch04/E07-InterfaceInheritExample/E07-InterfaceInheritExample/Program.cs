using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_InterfaceInheritExample
{
    interface Ifunction1
    {
        string Add(int a, int b);
    }
    
    class Example1 : Ifunction1
    {
        public string Add(int a, int b)
        {
            int sum = a + b;
            return "Example1 sum:" + sum;
        }
    }
    class Example2 : Ifunction1
    {
        public string Add(int a, int b)
        {
            int sum = a + b;
            return "Example2 sum:" + sum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ifunction1 a1 = new Example1();
            Console.WriteLine(a1.Add(2, 3));
            Ifunction1 a2 = new Example2();
            Console.WriteLine(a2.Add(2, 3));

            Console.ReadKey();
        }
    }
}

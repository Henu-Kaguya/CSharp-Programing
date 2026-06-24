using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_ConstructExample
{
    class A
    {
        public A()
        { Console.WriteLine("a"); }
    }
    class B:A
    {
        public B()
        { Console.WriteLine("b"); }
    }
    class C:B
    {
        public C()
        { Console.WriteLine("c"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            C c = new C();
            Console.ReadKey();
        }
    }
}

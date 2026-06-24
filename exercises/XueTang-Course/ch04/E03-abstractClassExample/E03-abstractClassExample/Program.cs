using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_abstractClassExample
{
    public abstract class A
    {
        protected string r = "Test";
        public abstract void Draw();
    }
    public class B:A
    {
        public override void Draw()
        {
            r += "B.Draw";
            Console.Write(r);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Draw();

            Console.ReadLine();
        }
    }
}

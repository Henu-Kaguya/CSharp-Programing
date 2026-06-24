using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_InterfaceExample
{
    interface Ifunction1
    {
        string MyString { get; set; }
    }
    interface Ifunction2
    {
        int Add(int x1, int x2);
    }
    class InterfaceExampel : Ifunction1, Ifunction2
    {
        private string myString;
        public string MyString
        {
            get{ return myString; }

            set { MyString = value; }
        }

        public int Add(int x1, int x2)
        {
            return x1 + x2;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceExampel a = new InterfaceExampel();
            Ifunction1 b1 = new InterfaceExampel();
            Ifunction2 b2 = new InterfaceExampel();
        }
    }
}

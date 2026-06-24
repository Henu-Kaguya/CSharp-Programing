using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_Interface2Example
{
    interface Ifunction1
    {
        int Add(int x1, int x2);
    }
    interface Ifunction2
    {
        int Add(int x1, int x2);
    }
    class InterfaceExampel : Ifunction1, Ifunction2
    {
       //显示实现
        int Ifunction1.Add(int x1, int x2)
        {
            return x1 + x2;
        }
        int Ifunction2.Add(int x1, int x2)
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

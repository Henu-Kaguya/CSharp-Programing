using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E05_delegateExample
{
    public delegate double MyDelegate(double x);
    public class MyClass
    {
        public static double Method1(double x)
        {
            return x * 2;
        }
        public double Method2(double x)
        {
            return x * x;
        }
        public double[] Method3(double[] a, MyDelegate f)
        {
            double[] y = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                y[i] = f(a[i]);
            }
            return y;
        }
    }
    class Program
    {
        public string R { get; set; } = "";
        public void Demo1()
        {
            //用法1：调用类的静态方法
            MyDelegate m1 = MyClass.Method1;
            double r1 = m1(10);
            R += $"r1={r1:f2}";
            //用法2：调用类的实例方法
            var c = new MyClass();
            MyDelegate m2 = c.Method2;
            double r2 = m2(5);
            R += $"，r2={r2:f2}\n";
            Console.WriteLine(R);
        }
        public void Demo2()
        {
            MyClass c = new MyClass();
            double[] a = { 0.0, 0.5, 1.0 };

            //利用委托求数组a中每个元素的正弦值
            double[] r1 = c.Method3(a, Math.Sin);
            R += $"r1={string.Join("，", r1)}\n";

            //利用委托求数组a中每个元素的余弦值
            double[] r2 = c.Method3(a, Math.Cos);
            R += $"r2={string.Join("，", r2)}\n";

            Console.WriteLine(R);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Demo1();
            p.Demo2();
            Console.ReadKey();
        }
    }
}

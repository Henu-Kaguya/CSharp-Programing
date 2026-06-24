using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E06_StructExample
{
  
    public struct MyPoint
        {
            public int X;
            public int Y;
        public MyPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
    class Program
    {
        private const int LEN = 3;
        private readonly static string space = new string(' ', 2);
        public static string Result { get; set; } = "";

        public void test()
        {
            MyPoint a = new MyPoint(10, 10);
            MyPoint b = a;
            a.X = 20;
            Console.WriteLine(b.X);
        }
        static void Main(string[] args)
        {
            MyPoint[] p1 = new MyPoint[LEN];
            for (int i = 0; i < p1.Length; i++)
            {
                //必须创建对象
                p1[i] = new MyPoint { X = i, Y = i };
                Result += $"[{p1[i].X},{p1[i].Y}]{space}";
            }
            Result += "\n";

            Console.WriteLine(Result);

            Program p = new Program();
            p.test();

            Console.ReadKey();
        }
    }
}

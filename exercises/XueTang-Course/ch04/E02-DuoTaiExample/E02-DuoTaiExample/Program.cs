using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E02_DuoTaiExample
{
    public class Shape
    {
        public virtual void Draw() { Console.WriteLine("Draw"); }
    }
    public class Line:Shape
    {
        public override void Draw() { Console.WriteLine("DrawLine"); }
    }
    public class Rect:Shape
    {
        public override void Draw() { Console.WriteLine("DrawRect"); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shaples = new Shape[2];
            shaples[0] = new Line();
            shaples[1] = new Rect();
            foreach(Shape item in shaples)
            {
                item.Draw();
            }
            Console.ReadLine();
        }
    }
}

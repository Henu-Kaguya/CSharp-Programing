using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_EnumExample
{
    class Program
    {
        public enum MyColor { Black,White,Blue};
        static void Main(string[] args)
        {
            MyColor c = MyColor.Black;
            Console.WriteLine(c);
            var s = "";
            //获取枚举类型中定义的所有符号名称
            string[] colorNames = System.Enum.GetNames(typeof(MyColor));
            //获取所有枚举成员
            s += string.Join(",", colorNames);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}

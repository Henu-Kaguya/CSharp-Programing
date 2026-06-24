using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241028
{
    class Rectangle : Shape
    {
        private string s;
        public override string str {
            get { return s; }
            set { s = value; }
        }

        public override string DrawShape() //实现抽象类中的方法
        {
            s = "Rectangle \t";
            return s;
        }
    }
}

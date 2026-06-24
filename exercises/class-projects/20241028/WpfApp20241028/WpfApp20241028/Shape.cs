using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241028
{
    //抽象类：只有声明没有实现，不能实例化
    abstract class Shape
    {
        //抽象的属性
        public abstract string str { get; set; }
        //抽象的方法
        public abstract string DrawShape();
    }
}

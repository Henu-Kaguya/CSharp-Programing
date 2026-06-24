using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241028
{
    class TestClass : Interface1
    {
        //隐实现接口：类方法前自动添加public
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }
    }

    class Test : Interface1,Interface2
    {
        int Interface1.Add(int x, int y)
        {
            return x + y;
        }

        int Interface2.Add(int x, int y)
        {
            return (x + y) * 2;
        }

        int Interface2.Mul(int x, int y)
        {
            throw new NotImplementedException();
        }

        int Interface1.Sub(int x, int y)
        {
            return x -y;
        }
    }
}

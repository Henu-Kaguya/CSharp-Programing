using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241028
{
    class Student:Person
    {
        public Student()
        {
            str += "Student\t";
        }
        public Student(string st):base(st)
        {
            Name = st;
            str += "Student: " + st + "\t";
        }

        public void PrintStudent()
        {
            base.Print();//调用基类的方法
        }
    }
}

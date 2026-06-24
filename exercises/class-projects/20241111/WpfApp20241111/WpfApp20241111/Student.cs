using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241111
{
    class Student
    {
        public string SNo { get; set; }
        public string SName { get; set; }
        public string Sex { get; set; }
        public int Grade { get; set; }

        public Student(string n,string name,string se,int g)
        {
            SNo = n;
            SName = name;
            Sex = se;
            Grade = g;
        }

        public string GetInfo()
        {
            return string.Format("{0}---{1}---{2}---{3}", SNo, SName, Sex, Grade);
        }
    }
}

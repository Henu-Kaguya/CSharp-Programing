using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_classExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu1 = new Student(15, "李安");
            Student stu2 = new Student(15, "张华");
        }
    }

    public class Student
    {
        private int age;
        private string name;
        public Student(int stuage,string stuname)
        {
            age = stuage;
            name = stuname;
        }
    }
}

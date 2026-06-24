using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E01_LinqExample
{
    public class Student
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public char Gender { get; set; }
        public int Score { get; set; }
    }
    public class Family
    {
        public string StudentID { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
    }
    class Demos
    {
        private readonly List<Student> students;
        private readonly List<Family> families;
        public Demos()
        {
            students = new List<Student>
            {
                new Student{ID="001", Name="张三", Gender='男', Score=81},
                new Student{ID="002", Name="李四", Gender='男', Score=83},
                new Student{ID="003", Name="王五", Gender='女', Score=85},
                new Student{ID="004", Name="赵六", Gender='男', Score=83}
            };
            families = new List<Family>
            {
                new Family{ StudentID="001", FatherName="张三父", MotherName="张三母"},
                new Family{ StudentID="002", FatherName="李四父", MotherName="李四母"},
                new Family{ StudentID="003", FatherName="王五父", MotherName="王五母"},
                new Family{ StudentID="004", FatherName="赵六父", MotherName="赵六母"}
            };
        }
        public string Demo1_from()
        {
            string s = "";
            var q1 = from t in students select t;
            foreach (var v in q1)
            {
                s += $"{v.ID}\t{v.Name}\t{v.Gender}\t{v.Score}\n";
            }
            var q2 = from t1 in students
                     from t2 in families
                     where t1.ID == t2.StudentID
                     select new { 姓名 = t1.Name, 父亲 = t2.FatherName, 母亲 = t2.MotherName };
            foreach (var v in q2)
            {
                s += $"{v.姓名}\t{v.父亲}\t{v.母亲}\n";
            }
            return s;
        }
        public string Demo2_select()
        {
            string s = "";
            var q1 = from t in students select t.Score;
            s += $"平均成绩：{q1.Average()},最高成绩：{q1.Max()}\n";
            var q2 = from t in students
                     select new { 姓名 = t.Name, 成绩 = t.Score };
            s += "\n\n姓名\t成绩\n";
            s += $"{new string('-', 20)}\n";
            foreach (var v in q2)
            {
                s += $"{v.姓名}\t{v.成绩}\n";
            }
            return s;
        }
        public string Demo3_where()
        {
            var q = from t in students
                    where t.Name.StartsWith("李") == true && t.Gender == '男'
                    select t;
            string s = "";
            foreach (var v in q)
            {
                s += $"{v.ID}\t{v.Name}\t{v.Gender}\t{v.Score}\n";
            }
            return s;
        }
        public string Demo4_orderby()
        {
            var q = from t in students
                    where t.Score > 0
                    orderby t.Score descending, t.Name ascending
                    select t;
            string s = "";
            foreach (var v in q)
            {
                s += $"{v.ID}\t{v.Name}\t{v.Gender}\t{v.Score}\n";
            }
            return s;
        }
        public string Demo5_group()
        {
            var q = from t in students
                    orderby t.Score ascending, t.Name ascending
                    where t.Score > 0
                    group t by t.Gender;
            string s = "";
            foreach (var v in q)
            {
                foreach (var v1 in v)
                {
                    s += $"{v1.ID}\t{v1.Name}\t{v1.Gender}\t{v1.Score}\n";
                }
            }
            return s;
        }
    }
}

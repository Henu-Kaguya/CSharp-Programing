using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20241014
{
    class Book
    {   
        //字段
        public string BookISBN;
        public string BookName;
        public string Author;
        public string Publisher;

        //属性：先定义字段，后定义属性：
        //（1）类中存在一个只读/只修的字段时，一定是先定义一个私有字段，然后再定义属性；<VS2017
        private double Price;//不允许修改
        public double BookPrice //只读
        {
            get { return Price; } //读
        }
        //(2)当一个字段有取值范围或者约束条件时，一定是先定义一个私有字段，然后再定义属性；
        private int sellCount;
        public int SellCount
        {
            get { return sellCount; }
            set { if (value >= 0)     //限定sellcount》=0
                    sellCount = value;
            }
        }

        //2.自动实现的属性：可以不用定义字段，直接定义属性
        public int Rank { get; set; }
        public int Degree { get; private set; } //(1) >=2017

        ////错误形式!!!!
        //public string Tuijian
        //{
        //    get { return Tuijian; }
        //    set { Tuijian = value; }
        //}

        public static int counter = 0;
        //构造函数
        public Book()
        {
            Price = 10;
            counter++;
        }
        public Book(string bno,string bname,string pb)
        {
            BookISBN = bno;
            BookName = bname;
            Publisher = pb;
            counter++;
            Price = 10;
        }
        public Book(string bno, string bname, string at,string pb,double p)
        {
            BookISBN = bno;
            BookName = bname;
            Author = at;
            Publisher = pb;
           // Price = p;
            counter++;
            Price = 10;
        }
        //方法
        public string GetBookInfo()
        {
            return string.Format("{0}-{1}-{2}-{3}-{4:C}", BookISBN, BookName, Author, Publisher, Price);
        }
        
    }
}

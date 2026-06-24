using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20241014
{
    class Program
    {
        //1.值参数：数据类型  参数名   （数据类型：值类型） 例如：int a
        static void AddOne(int x) {
            x++;
            Console.WriteLine("x:"+x);
        }
        //2.引用参数： ref 数据类型  参数名/  引用类型  参数名  例如：ref int a， Book bk， ref Book bk
        static void AddOne(ref int y)
        {
            y++;
            Console.WriteLine("y:" + y);
        }
        //3.输出参数：out 数据类型 参数名 （本质上是传引用）
        static void AddOne(int x, out int y)
        {
            x++;
            y = 12;
        }
        //4.数组参数： parmas 数据类型[] 参数名
        static double GetAverage(params double[] arr)
        {
            double total = 0;
            for (int i = 0; i < arr.Length; i++)
                total += arr[i];
            return total / arr.Length;
        }
        static void Main(string[] args)
        {
            Book bk = new Book();
            bk.SellCount = -123;
            Console.WriteLine(bk.SellCount);
            //bk.Tuijian = "aa";

            int a = 3;
            AddOne(a);
            Console.WriteLine("a:"+a);//a=3
            int b = 4;
            AddOne(ref b);//b与y有相同的地址
            Console.WriteLine("b:" + b);//b=5
            int c = 5;
            AddOne(a, out c);
            Console.WriteLine("c:" + c);//c=12
            double[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(GetAverage(arr));
            double[] arr1 = { 1, 2, 3, 4, 5,6,7,8,9,10 };
            Console.WriteLine(GetAverage(arr1));

            Console.WriteLine(GetAverage(12,34,56,78,100,-12));

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            Book bk = new Book();
            Console.WriteLine(bk.GetBookInfo());
            Console.WriteLine(Book.counter);
            Book bk1 = new Book("913123456", "C#程序设计", "人民邮电出版社");
            Console.WriteLine(bk1.GetBookInfo());
            Console.WriteLine(Book.counter);
            Book bk2 = new Book("913123467", "C#程序设计", "李四", "人民邮电出版社", 53.26);
            Console.WriteLine(bk2.GetBookInfo());
            Console.WriteLine(Book.counter);
        }
    }
}

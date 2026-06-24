using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //import java.util.*; #include<stdio.h>
//引用命名空间

namespace ConsoleAppHelloWorld //命名空间
{
    //枚举类型定义：建议命名空间下，类的外边
    public enum Weeks:byte{Monday,Tuesday=254,Wednesday};
    class Program //类
    {
        
        static void Main(string[] args) //方法
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(1);
            sb.Append("abc123");
            sb.AppendFormat("{0}",123);
            sb.AppendLine("afffff");
            sb.Append(234);
            Console.WriteLine(sb.ToString());

            string str = "abcxy123abcxy123abcxydefxygr";
            string ss = "xy";
            int startIndex = 0;
            int count = 0;
            while(true)
            {
                int index = str.IndexOf(ss, startIndex);
                if (index != -1)
                {
                    startIndex = index + 1;
                    count++;
                    Console.WriteLine("第{0}次，出现的位置是{1}", count, index);
                }
                else
                    break;
            }

            Console.ReadLine();
        }

        private static void NewMethod()
        {
            //数组的声明和赋值
            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = (i+1) * (i+1);
            //}
            ////数组元素的输出
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            ////常用函数
            //Console.WriteLine(arr.Max() + "," + arr.Min() + "," + arr.Average());
            //if(arr.Contains(169))
            //{           }
            //int index=Array.IndexOf(arr, 169);
            int[] new_arr = { -2, 4, 78, 9, -123 };
            Array.Sort(new_arr);
            Array.Reverse(new_arr);
            Console.WriteLine(string.Join(" ", new_arr));

            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {
                new_arr[i] = r.Next(101);
            }
            Console.WriteLine(string.Join(" ", new_arr));
        }

    }
}

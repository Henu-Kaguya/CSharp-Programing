using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace E02_fileReadWriteExample
{
    class Program
    {

        static void Main(string[] args)
        {
            Method1();
            Method2();
            Console.ReadKey();
        }

        private static void Method1()
        {
            //演示程序之前请确保E盘存在temp目录
            string path = @"E:\temp\MyTest.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string[] appendText = { "单位", "姓名", "成绩" };
            File.WriteAllLines(path, appendText, Encoding.Default);
            string[] readText = File.ReadAllLines(path, Encoding.Default);
            Console.WriteLine(string.Join(Environment.NewLine, readText));
        }

        private static void Method2()
        {
            //演示程序之前请确保E盘存在temp目录
            string path = @"E:\temp\MyTest.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            string appendText =  "你好"+ Environment.NewLine;
            File.AppendAllText(path, appendText, Encoding.Default);
            string readText = File.ReadAllText(path, Encoding.Default);
            Console.WriteLine(readText);
        }
    }
}

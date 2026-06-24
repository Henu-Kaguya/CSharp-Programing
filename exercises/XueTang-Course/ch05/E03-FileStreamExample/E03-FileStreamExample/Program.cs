using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_FileStreamExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //演示前确保e盘存在temp文件夹。
            //在此文件夹下创建一个E0603.txt的文件作为演示。
            string path = @"e:\temp\E0603.txt";
            //写文件
            using (FileStream fs = File.Open(path, FileMode.Create))
            {
                byte[] b = Encoding.UTF8.GetBytes("你好！\nThis is some text in the file.");
                fs.Write(b, 0, b.Length);
            }
            //读文件
            using (FileStream fs = File.Open(path, FileMode.Open))
            {
                byte[] b = new byte[1024];   //每次读取的缓存大小
                int len = 0;
                while ((len = fs.Read(b, 0, b.Length)) > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(b, 0, len));
                }
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace E01_DirectoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\Windows\system32\notepad.exe";
            Console.WriteLine("以下是带扩展名的文件名:");
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine("以下是不带扩展名的文件名:");
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));

            string dir = @"E:\test\123";
            if (!Directory.Exists(dir))
            {
                //创建目录
                Directory.CreateDirectory(dir);
            }
            //删除和重命名(不要同时演示，查看时可以先创建，而后删除）
            //Directory.Delete(@"E:\test\123",true);

            //重命名
            //Directory.Move(@"E:\test\123", @"E:\new\123");

            string dirfile = @"E:\test\123\123.txt";
            if (File.Exists(dirfile))
            {
                Console.WriteLine("True");
            }

            File.Copy(dirfile, @"e:\test\123\a.txt", true);

            //删除和重命名(不要同时演示)
           // File.Delete(dirfile);

            //重命名
            //File.Move(dirfile, @"E:\test\123\b.txt");

            if(File.GetAttributes(dir) == FileAttributes.Directory)
            {
                Console.WriteLine("{0}是目录", dir);
            }
            else
            {
                Console.WriteLine("{0}是文件", dir);
            }

            Console.ReadLine();
        }
    }
}

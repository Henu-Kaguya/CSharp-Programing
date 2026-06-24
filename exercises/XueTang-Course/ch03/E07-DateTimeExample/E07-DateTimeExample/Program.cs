using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E07_DateTimeExample
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            //用法1：创建实例
            DateTime dt1 = new DateTime(2013, 1, 30);
            sb.AppendLine("dt1："+dt1.ToLongDateString());
            //用法2：获取当前日期和时间
            DateTime dt2 = DateTime.Now;
            //用法3：格式化输出
            sb.AppendLine("dt2：" + dt2.ToString("yyyy-MM-dd"));
            sb.AppendLine("dt2年份：" + dt2.Year);
            sb.AppendLine("dt2月份：" + dt2.Month);
            sb.AppendLine("dt2时间：" + dt2.Hour+"点"+dt2.Minute+"分");
            //获取两个日期相隔的天数
            TimeSpan ts = dt2 - dt1;
            sb.AppendLine("dt1和dt2相隔"+ts.Days+"天");
            Console.WriteLine(sb.ToString());
            Console.ReadKey();
        }
    }
}

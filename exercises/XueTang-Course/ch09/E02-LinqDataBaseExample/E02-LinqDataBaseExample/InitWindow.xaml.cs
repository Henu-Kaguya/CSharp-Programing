using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace E02_LinqDataBaseExample
{
    /// <summary>
    /// InitWindow.xaml 的交互逻辑
    /// </summary>
    public partial class InitWindow : Window
    {
        public InitWindow()
        {
            InitializeComponent();
            Loaded += delegate { Init(); };
        }

        private async void Init()
        {
            bool isSuccess = true;
            await Task.Run(() =>
            {
                AddTip("【使用 SQL命令 清除数据库表】\n");
                using (var c = new MyDb1Entities())
                {
                    try
                    {
                        var v = c.Database;
                        int n1 = v.ExecuteSqlCommand("delete from student");
                        int n2 = v.ExecuteSqlCommand("delete from KC");
                        int n3 = v.ExecuteSqlCommand("delete from CJ");
                        AddTip($"清除表数据：已删除Student表中的{n1}记录，KC表中的{n2}记录，CJ表中的{n3}记录\n");
                    }
                    catch
                    {
                        AddTip("数据库操作失败，注意首次启动LocalDB用时较长，请稍等几秒（等待LocalDB启动完成），然后再次运行即可\n");
                        isSuccess = false;
                    }
                }
            });
            if (!isSuccess) return;
            await Task.Run(() =>
            {
                AddTip("【使用 LINQ to Entities 添加初始数据】\n");
                using (var c = new MyDb1Entities())
                {
                    List<Student> students = new List<Student>
                    {
                        new Student { XueHao = "20180001", XingMing = "张三一", XingBie = "男", ChuShengRiQi = DateTime.Parse("1999-01-25") },
                        new Student { XueHao = "20180002", XingMing = "张三二", XingBie = "男", ChuShengRiQi = DateTime.Parse("1999-09-01") },
                        new Student { XueHao = "20180003", XingMing = "李四", XingBie = "男", ChuShengRiQi = DateTime.Parse("2000-02-25") },
                        new Student { XueHao = "20180004", XingMing = "王五", XingBie = "女", ChuShengRiQi = DateTime.Parse("2001-10-25") }
                    };
                    c.Student.AddRange(students);
                    AddTip($"Student表：添加{students.Count}条，");
                    List<KC> kc = new List<KC>
                    {
                        new KC { KCBianMa = "001", KCMingCheng = "C++程序设计", KCLeiBie = "专业基础课" },
                        new KC { KCBianMa = "002", KCMingCheng = "C#程序设计", KCLeiBie = "专业选修课" },
                        new KC { KCBianMa = "003", KCMingCheng = "Java程序设计", KCLeiBie = "专业选修课" },
                        new KC { KCBianMa = "004", KCMingCheng = "Python程序设计", KCLeiBie = "专业选修课" }
                    };
                    c.KC.AddRange(kc);
                    AddTip($"KC表：添加{kc.Count}条，");
                    List<CJ> cj = new List<CJ>
                    {
                        new CJ { XueHao = "20180001", KCBianMa = "001", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 95 },
                        new CJ { XueHao = "20180001", KCBianMa = "002", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 80 },
                        new CJ { XueHao = "20180002", KCBianMa = "001", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 90 },
                        new CJ { XueHao = "20180002", KCBianMa = "002", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 85 },
                        new CJ { XueHao = "20180003", KCBianMa = "001", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 80 },
                        new CJ { XueHao = "20180003", KCBianMa = "002", XueNianXueQi = "2018-2019-1", XiuDuLeiBie = "初修", ChengJi = 90 }
                    };
                    c.CJ.AddRange(cj);
                    AddTip($"CJ表：添加{cj.Count}条。\n");
                    if (MyDb1Helps.SaveChanges(c, out string errMsg))
                    {
                        AddTip("更新数据库成功。");
                    }
                    else
                    {
                        AddTip($"更新数据库失败。异常：{errMsg}\n");
                    }
                }
            });
        }
        private void AddTip(string text)
        {
            this.Dispatcher.Invoke(() => txtBlock1.Text += text);
        }
    }
}

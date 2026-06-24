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
    /// QueryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class QueryWindow : Window
    {
        public QueryWindow()
        {
            InitializeComponent();
            Loaded += E04_Loaded;
        }

        private void E04_Loaded(object sender, RoutedEventArgs e)
        {
            using (var c = new MyDb1Entities())
            {
                //(1)from
                var q1 = from t in c.Student select t;
                dataGrid_from1.ItemsSource = q1.ToList();
                var q2 = from t in c.KC select t;
                dataGrid_from2.ItemsSource = q2.ToList();
                var q3 = from t in c.CJ select t;
                dataGrid_from3.ItemsSource = q3.ToList();
                var q4 = from t1 in c.Student
                         from t2 in c.CJ
                         from t3 in c.KC
                         where t1.XueHao == t2.XueHao && t2.KCBianMa == t3.KCBianMa
                         let t = new
                         {
                             学号 = t1.XueHao,
                             姓名 = t1.XingMing,
                             学年学期 = t2.XueNianXueQi,
                             课程编码 = t2.KCBianMa,
                             课程名称 = t3.KCMingCheng,
                             修读类别 = t2.XiuDuLeiBie,
                             成绩 = t2.ChengJi
                         }
                         select t;
                dataGrid_from4.ItemsSource = q4.ToList();
                //(2)where
                var q5 = from t in c.Student
                         where t.XingMing.StartsWith("李") == true && t.XingBie == "男"
                         select t;
                dataGrid_where.ItemsSource = q5.ToList();
                //(3)orderby
                var q6 = from t1 in c.Student
                         from t2 in c.CJ
                         where t1.XueHao == t2.XueHao && t2.ChengJi > 85
                         orderby t2.XueHao ascending, t2.ChengJi descending
                         select new
                         {
                             学号 = t2.XueHao,
                             姓名 = t1.XingMing,
                             成绩 = t2.ChengJi
                         };
                dataGrid_orderby.ItemsSource = q6.ToList();
                //(4)group
                var q7 = from t1 in c.CJ
                         from t2 in c.Student
                         from t3 in c.KC
                         where t1.XueHao == t2.XueHao && t1.KCBianMa == t3.KCBianMa
                         let t = new
                         {
                             学号 = t1.XueHao,
                             姓名 = t2.XingMing,
                             性别 = t2.XingBie,
                             课程编码 = t1.KCBianMa,
                             课程名称 = t3.KCMingCheng,
                             成绩 = t1.ChengJi
                         }
                         group t by t2.XingBie;
                foreach (var v in q7)
                {
                    var textBlock = new TextBlock { Text = $"性别：{v.Key}" };
                    stackPanel_group.Children.Add(textBlock);
                    var dataGrid = new DataGrid { ItemsSource = v.ToList() };
                    stackPanel_group.Children.Add(dataGrid);
                }
                //(5)select
                var q8 = from t in c.CJ select t.ChengJi;
                textBlock_select.Text = $"平均成绩：{q8.Average():f2}，最高成绩：{q8.Max()}";
                var q9 = from t1 in c.Student
                         from t2 in c.CJ
                         where t1.XueHao == t2.XueHao
                         let t = new { 学号 = t1.XueHao, 姓名 = t1.XingMing, 成绩 = t2.ChengJi }
                         select t;
                dataGrid_select.ItemsSource = q9.ToList();
            }
        }
    }
}

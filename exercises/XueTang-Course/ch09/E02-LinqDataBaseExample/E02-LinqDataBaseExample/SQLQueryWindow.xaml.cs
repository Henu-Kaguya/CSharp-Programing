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
    /// SQLQueryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SQLQueryWindow : Window
    {
        public SQLQueryWindow()
        {
            InitializeComponent();
            btn1.Click += delegate
            {
                using (var c = new MyDb1Entities())
                {
                    if (r1.IsChecked == true)
                    {
                        var v = c.Database.SqlQuery<Student>("select * from student");
                        dataGrid1.ItemsSource = v.ToList();
                    }
                    if (r2.IsChecked == true)
                    {
                        var v = c.Database.SqlQuery<Student>("select * from student where XingMing like {0}", "张%");
                        dataGrid1.ItemsSource = v.ToList();
                    }
                    if (r3.IsChecked == true)
                    {
                        var v = c.Database.SqlQuery<Student>("select * from student where XingBie = {0}", "男");
                        dataGrid1.ItemsSource = v.ToList();
                    }
                }
            };
        }
    }
}

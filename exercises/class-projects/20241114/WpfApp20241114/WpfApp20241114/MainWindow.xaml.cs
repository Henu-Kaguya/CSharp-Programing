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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp20241114
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //1.获得数据源  2.写LINQ查询表达式 3.执行查询
            MyDBEntities context = new MyDBEntities();
            var q = from t in context.Student
                    select t;
            this.datagrid.ItemsSource = q.ToList();

            foreach(var m in q)
            {
                listbox.Items.Add(m.XueHao + "--" + m.XingMing);
            }

        }
    }
}

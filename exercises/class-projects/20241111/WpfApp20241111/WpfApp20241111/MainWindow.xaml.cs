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

namespace WpfApp20241111
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
            //1.数据源
            List<Student> stuList = new List<Student>();
            stuList.Add(new Student("120101001","张三风","男",98));
            stuList.Add(new Student("120101002", "张丽丽", "女", 82));
            stuList.Add(new Student("120101003", "赵大强", "男", 75));
            stuList.Add(new Student("120101004", "李明明", "女", 75));
            stuList.Add(new Student("120101005", "王大力", "男", 54));
            //2.查询表达式
            var q = from t in stuList   //select * from student 
                    orderby t.Grade ascending,t.SNo descending
                    select t;
            //var q1 = from t1 in stuList  //select sno,sname from student 
            //         select new { sn = t1.SNo, sname = t1.SName };

            var query = from t in stuList
                        group t by t.Sex;
            //3.执行查询
            foreach (var m in q)
                listbox.Items.Add(m.GetInfo());

            foreach(var g in query) //遍历的是组
            {
                listbox.Items.Add("组：" + g.Key);
                foreach (var n in g)//遍历组内的元素
                    listbox.Items.Add(n.GetInfo());
            }

        }
    }
}

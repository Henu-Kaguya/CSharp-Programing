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

namespace WpfApp1
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

        //第一步：创建对象
        MyDBEntities context = new MyDBEntities();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            switch (btn.Tag)
            {
                case "1": //All
                    var q = from t in context.Student select t;
                    //  var q = context.Database.SqlQuery<Student>("select * from student"); //第二步：写Sql语句调用方法
                    datagrid.ItemsSource = q.ToList(); //3.执行查询
                    break;
                case "2": //张
                    var q1 =
                        from t in context.Student
                        where t.XingMing.StartsWith("张") == true
                        select t;
                    //var q1 = context.Database.SqlQuery<Student>("select * from student where xingming like {0}","张%");
                    datagrid.ItemsSource = q1.ToList();
                    break;
                default: //男
                    var q2 = from t in context.Student where t.XingBie == "男" select t;
                    //var q2 = context.Database.SqlQuery<Student>("select * from student where xingbie={0}", "男");
                    datagrid.ItemsSource = q2.ToList();
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            switch (btn.Tag)
            {
                case "4": //Insert
                    try
                    { //第二步：写Sql语句调用方法
                        //int r = context.Database.ExecuteSqlCommand("insert into student(xuehao,xingming,xingbie,chushengriqi) values({0},{1},{2},{3})","20180006","王丽丽","女","2000-6-3");
                        //linq第二步：创建一个对象；
                        Student std = new Student();
                        std.XueHao = "20180001";
                        std.XingMing = "张三玉";
                        std.XingBie = "女";
                        std.ChuShengRiQi = DateTime.Parse("2000-1-5");
                        context.Student.Add(std); //linq第3步 3.添加对象到集合
                        int r = context.SaveChanges(); //linq第4步 保存更新
                        if (r > 0)
                            MessageBox.Show("插入成功！");
                        else
                            MessageBox.Show("插入失败！");
                    }
                    catch
                    {
                        MessageBox.Show("插入异常!");
                    }
                    break;
                case "5": //update
                    try
                    {
                        //int r = context.Database.ExecuteSqlCommand("update student set chushengriqi={0} where xuehao={1}", "2000-6-23","20180001");
                        //linq第2步：查找修改的对象
                        var q = from t in context.Student where t.XueHao == "20180001" select t;
                        //linq第3步：修改对象属性
                        if (q.Count() > 0)
                        {
                            // var m = q.FirstOrDefault(); //仅有一个时
                            // m.ChuShengRiQi = DateTime.Parse("2000-6-23");
                            foreach (var m in q)
                                m.ChuShengRiQi = DateTime.Parse("2000-6-23");
                        }
                        //linq第4步：保存修改
                        int r = context.SaveChanges();
                        if (r > 0)
                            MessageBox.Show("修改成功！");
                        else
                            MessageBox.Show("修改失败！");
                    }
                    catch
                    {
                        MessageBox.Show("修改异常!");
                    }
                    break;
                default: //delete
                    try
                    {
                        //int r = context.Database.ExecuteSqlCommand("delete from student where xuehao={0}", "20180001");
                        //linq第2步：查找对象
                        var q = from t in context.Student where t.XueHao == "20180006" select t;
                        //linq第3步：从集合中移除对象
                        if (q.Count() > 0)
                        {
                            //单一对象
                            // var m = q.FirstOrDefault();
                            // context.Student.Remove(m);
                            foreach (var m in q)
                                context.Student.Remove(m);
                        }
                        //linq第4步：保存修改
                        int r = context.SaveChanges();
                        if (r > 0)
                            MessageBox.Show("删除成功！");
                        else
                            MessageBox.Show("删除失败！");
                    }
                    catch
                    {
                        MessageBox.Show("删除异常!");
                    }
                    break;
            }
        }
    }
}

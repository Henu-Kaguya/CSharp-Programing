using Microsoft.Win32;
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

namespace DataExampleWpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataGrid1.SelectedIndex = -1;
            RefreshDataGrid();
        }

        //显示DataGrid的内容
        private void RefreshDataGrid()
        {
            using (var c = new MyDBEntities())
            {
                var q = from t in c.Student
                        select t;
                dataGrid1.ItemsSource = q.ToList();
            }
        }

        //添加
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AddWindow ad = new AddWindow();
            ad.ShowDialog();

            RefreshDataGrid();
        }

        //修改
        private void btnModify_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedIndex == -1)
            {
                MessageBox.Show("请先单击要修改的行");
                return;
            }
            string xuehao = ((Student)dataGrid1.SelectedItem).Xuehao;
            ModifyWindow mf = new ModifyWindow();
            mf.xuehao = xuehao;
            mf.ShowDialog();

            RefreshDataGrid();
        }

        //删除
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedIndex == -1)
            {
                MessageBox.Show("请先单击要删除的行");
                return;
            }
            using (var c = new MyDBEntities())
            {
                Student student = (Student)dataGrid1.SelectedItem;
                var q = (from t in c.Student where t.Xuehao == student.Xuehao select t).FirstOrDefault();
                c.Student.Remove(q);
                c.SaveChanges();
            }

            RefreshDataGrid();
        }

        
    }
}

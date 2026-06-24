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

namespace E01_WPFWindowExample
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
        NewWindow frm = new NewWindow();
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //设置新打开的窗体属于该MainWindow窗体的子窗体
            frm.Owner = this;
            frm.Show();
            //frm.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            frm.Hide();//窗口隐藏还可以再次调用show方法打开
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            frm.Close();//窗口关闭之后，对象回收，此时再调用show方法会出现异常！
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("是否退出应用程序？", "提示", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (result != MessageBoxResult.OK)
                e.Cancel = true;
            else
            {
                App.Current.Shutdown();
            }
        }
    }
}

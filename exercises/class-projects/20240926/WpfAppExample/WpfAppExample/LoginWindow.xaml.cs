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

namespace WpfAppExample
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
            //this.txtAccountNo.Text = "haha";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("用户名不对！", "提示",MessageBoxButton.YesNoCancel,MessageBoxImage.Warning);

            //admin,123
            string userName = this.txtAccountNo.Text;
            string pwd = this.txtPasswd.Password;
            if (userName == "admin" && pwd == "123")
            {
                MainWindow mw = new MainWindow();
                mw.ShowDialog();
            }
            else
                MessageBox.Show("用户名或密码不正确！");


           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.txtAccountNo.Clear();
            this.txtPasswd.Clear();
            //退出应用程序
            App.Current.Shutdown();
        }
    }
}

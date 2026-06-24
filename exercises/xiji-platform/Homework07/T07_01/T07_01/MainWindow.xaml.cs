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

namespace T07_01
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

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if(Selection.SelectedIndex == 0)
            {
                if (Password.Password == "abc")
                {
                    MessageBox.Show("登录成功！");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            else if (Selection.SelectedIndex == 1)//admin
            {
                if (Password.Password == "123")
                {
                    MessageBox.Show("登录成功！");
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            else
            {
                MessageBox.Show("请选择登录身份！");
            }
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

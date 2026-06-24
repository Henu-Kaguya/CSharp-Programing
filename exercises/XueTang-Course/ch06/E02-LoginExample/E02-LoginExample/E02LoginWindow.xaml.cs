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

namespace E02_LoginExample
{
    /// <summary>
    /// LoginWindow.xaml 的交互逻辑
    /// </summary>
    public partial class E02LoginWindow : Window
    {
        /// <summary>
        /// 登录用户名
        /// </summary>
        public string UserName { get; set; }

        public E02LoginWindow()
        {
            InitializeComponent();
            this.Closing += LoginWindow_Closing;
        }

        void LoginWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(this.UserName))
            {
                this.UserName = "（匿名用户）";
                if (MessageBox.Show("注意：此处仅为了避免直接退出，实际项目\n的登录窗口不应该显示此对话框。\n\n退出应用程序吗？", "",
                    MessageBoxButton.YesNo, MessageBoxImage.Question,
                    MessageBoxResult.Yes)== MessageBoxResult.Yes)
                {
                    App.Current.Shutdown();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Content.ToString())
            {
                case "确定":
                    this.UserName = userNameTextBox.Text;
                    this.Close();
                    break;
                case "取消":
                    this.Close();
                    break;
            }
        }
    }
}

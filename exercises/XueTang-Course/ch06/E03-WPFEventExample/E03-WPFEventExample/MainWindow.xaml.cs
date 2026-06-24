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

namespace E03_WPFEventExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnNo.Click += BtnNo_Click;
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("该按钮采用的是代码注册事件！");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is  button click event！");
        }

        private void StackPanel_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("The event is defined in StackPanel");
        }
    }
}

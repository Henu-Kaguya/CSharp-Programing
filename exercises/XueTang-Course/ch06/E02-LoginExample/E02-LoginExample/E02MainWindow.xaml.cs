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
    /// E02MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class E02MainWindow : Window
    {
        public E02MainWindow()
        {
            InitializeComponent();
            this.SourceInitialized += E02MainWindow_SourceInitialized;
        }

        void E02MainWindow_SourceInitialized(object sender, EventArgs e)
        {
            E02LoginWindow w = new E02LoginWindow();
            w.ShowDialog();
            this.Title = "欢迎您，" + w.UserName;
        }
    }
}

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

namespace E01_LinqExample
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
            Demos d = new Demos();
            string s = (e.Source as Button).Tag.ToString();
            switch (s)
            {
                case "1": textBlockResult.Text = d.Demo1_from(); break;
                case "2": textBlockResult.Text = d.Demo2_select(); break;
                case "3": textBlockResult.Text = d.Demo3_where(); break;
                case "4": textBlockResult.Text = d.Demo4_orderby(); break;
                case "5": textBlockResult.Text = d.Demo5_group(); break;
            }
        }
    }
}

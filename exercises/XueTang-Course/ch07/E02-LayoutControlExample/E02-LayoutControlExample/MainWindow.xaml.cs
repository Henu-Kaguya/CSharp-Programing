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

namespace E02_LayoutControlExample
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
            Button btn = e.Source as Button;
            Window w;
            switch (btn.Tag.ToString())
            {
                case "E1":
                    w = new CanvasWindow();
                    break;
                case "E2":
                    w = new DockPanelExample();
                    break;
                case "E3":
                    w = new GridExample();
                    break;
                case "E4":
                    w = new StackPanelAndWrapPanel();
                    break;
                case "E5":
                    w = new GroupBoxExample();
                    break;
                case "E6":
                    w = new BorderExample();
                    break;
                default:
                    w = null;
                    break;
            }
            if (w != null)
                w.ShowDialog();
        }
    }
}

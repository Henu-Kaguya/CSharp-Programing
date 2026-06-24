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

namespace T07_02
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

        private void Font_Add_Click(object sender, RoutedEventArgs e)
        {
            if (TestText.FontSize != 20)
            {
                TestText.FontSize += 4;
                //TestText.Content = "字体大小为" + TestText.FontSize;
                if (TestText.FontSize == 20)
                {
                    Font_Add.IsEnabled = false;
                }
            }
            Text_Change();
            ShowInfo();
        }

        private void Font_Shrink_Click(object sender, RoutedEventArgs e)
        {
            if (TestText.FontSize != 12)
            {
                TestText.FontSize -= 4;
                //TestText.Content = "字体大小为" + TestText.FontSize;
            }
            Text_Change();
            ShowInfo();
        }

        private void Clolor_Change_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte r = (byte)random.Next(0, 255);
            byte g = (byte)random.Next(0, 255);
            byte b = (byte)random.Next(0, 255);
            TestText.Foreground = new SolidColorBrush(Color.FromRgb(r, g, b));
            ShowInfo();
        }

        private void Text_Change()
        {
            if (TestText.FontSize != 20)
            {
                Font_Add.IsEnabled = true;
            }
            else
            {
                Font_Add.IsEnabled = false;
            }
            if (TestText.FontSize != 12)
            {
                Font_Shrink.IsEnabled = true;
            }
            else
            {
                Font_Shrink.IsEnabled = false;
            }
        }

        private void ShowInfo()
        {
            TestText.Content = "字体大小为" + TestText.FontSize + ", 字体颜色为" + TestText.Foreground.ToString();
        }
    }
}

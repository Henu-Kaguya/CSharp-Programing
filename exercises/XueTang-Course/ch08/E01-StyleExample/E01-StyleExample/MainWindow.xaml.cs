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

namespace E01_StyleExample
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnAdd.Click += (s, e) =>
            {
                Button btn = e.Source as Button;
                ResourceDictionary d1 = border1.Resources;
                d1.Add("backgroundKey", Brushes.Blue);
                d1.Add("borderBrushKey", new SolidColorBrush(Color.FromRgb(0xFF, 0, 0)));
                textBlock1.Resources.Add("forgroundKey", Brushes.White);
                textBlock2.Text = "样式定义成功";
                btn.IsEnabled = false;
            };
            btnRef.Click += (s, e) =>
            {
                //演示如何查找XAML资源
                Brush b1 = (Brush)border1.TryFindResource("backgroundKey");
                Brush b2 = (Brush)border1.TryFindResource("borderBrushKey");
                Brush b3 = (Brush)textBlock1.TryFindResource("forgroundKey");
                //演示如何将b1、b3作为静态资源来引用
                if (b1 != null) border1.Background = b1;
                if (b3 != null) textBlock1.Foreground = b3;
                //演示如何将b2作为动态资源来引用
                if (b2 != null) border1.SetResourceReference(Border.BorderBrushProperty, b2);
            };
        }
    }
}

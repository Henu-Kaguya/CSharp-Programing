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

namespace E01_BaseControlExample
{
    /// <summary>
    /// RadioandCheckBox.xaml 的交互逻辑
    /// </summary>
    public partial class RadioandCheckBox : Window
    {
        public RadioandCheckBox()
        {
            InitializeComponent();
        }

        //这个事件仅仅演示Checked事件的用法
        string s = "已选择:";
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.IsChecked == true)
                s += cb.Content.ToString() + "、";

            tbResult.Text = s.TrimEnd('、');
        }

        //注意如要同步显示选择和不选的功能实现，请用下面这个事件
        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {
            string s = "已选择：";
            foreach (var v in wp1.Children)
            {
                CheckBox cb = v as CheckBox;
                if (cb.IsChecked == true)
                {
                    s += cb.Content.ToString() + "、";
                }
            }
            tbResult.Text = s.TrimEnd('、');
        }
    }
}

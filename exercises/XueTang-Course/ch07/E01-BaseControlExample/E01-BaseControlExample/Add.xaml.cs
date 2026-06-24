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
    /// Add.xaml 的交互逻辑
    /// </summary>
    public partial class Add : Window
    {
        public Add()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            if(btn.Content.ToString()=="计算")
            {
                if(!double.TryParse(txtFirstNum.Text,out double t1)|| !double.TryParse(txtSecondNum.Text,out double t2))
                {
                    txtResult.Text = "输入有误无法计算";
                    return;
                }
                txtResult.Text = (t1 + t2).ToString();
            }
            if(btn.Content.ToString()=="清除结果")
            {
                txtFirstNum.Clear();
                txtSecondNum.Clear();
                txtResult.Clear();
            }
        }

      
    }
}

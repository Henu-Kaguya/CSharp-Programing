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

namespace WpfApp240930
{
    /// <summary>
    /// WindowCalc.xaml 的交互逻辑
    /// </summary>
    public partial class WindowCalc : Window
    {
        public WindowCalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //1.获取数据
            double x = double.Parse(this.txtNumber1.Text);
            double y = double.Parse(this.txtNumber2.Text);
            double z = 0;
            //2.获得运算类型并计算
            string op = this.lblop.Text;//"+"
            if (op == "+")
                z = x + y;
            else if (op == "-")
                z = x - y;
            //3.结果显示
            tblresult.Text = z.ToString();
        }

        //加法
        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (rbtAdd.IsChecked == true)
            {
                lblop.Text = "+";
                this.tblresult.Text = "";
            }

        }
        //减法
        private void RbtSub_Checked(object sender, RoutedEventArgs e)
        {
            if (this.rbtSub.IsChecked == true)
            {
                lblop.Text = "-";
                this.tblresult.Text = "";
            }
        }
    }
}

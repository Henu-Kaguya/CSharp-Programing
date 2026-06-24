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
            double x;
            bool tryX = double.TryParse(this.txtNumber1.Text,out x);
            double y;
            bool tryY = double.TryParse(this.txtNumber2.Text, out y);
            double z = 0;
            bool canCal = tryX && tryY;
            bool isInvalid = false;
            //2.获得运算类型并计算
            if (canCal)
            {
                string op = this.lblop.Text;//"+"
                if (op == "+")
                    z = x + y;
                else if (op == "-")
                    z = x - y;
                else if (op == "*")
                    z = x * y;
                else if (op == "/")
                {
                    if (y == 0)
                        isInvalid = true;
                    else
                        z = x / y;
                }
                else
                {
                    if (y == 0)
                        isInvalid = true;
                    else
                        z = x % y;
                }
            }
            //3.结果显示
            if (!isInvalid && canCal)
                tblresult.Text = z.ToString();
            else
               tblresult.Text = "?";
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

        private void rbtMul_Checked(object sender, RoutedEventArgs e)
        {
            if (this.rbtMul.IsChecked == true)
            {
                lblop.Text = "*";
                this.tblresult.Text = "";
            }
        }

        private void rbtDiv_Checked(object sender, RoutedEventArgs e)
        {
            if (this.rbtDiv.IsChecked == true)
            {
                lblop.Text = "/";
                this.tblresult.Text = "";
            }
        }

        private void rbtMod_Checked(object sender, RoutedEventArgs e)
        {
            if (this.rbtMod.IsChecked == true)
            {
                lblop.Text = "%";
                this.tblresult.Text = "";
            }
        }
    }
}

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

namespace WpfApp20241028
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
            Student st = new Student();
            listbox.Items.Add(st.str); //Person student
            Student st1 = new Student("Tom");
            listbox.Items.Add(st1.str);//Person:Tom Student:Tom

            Rectangle r = new Rectangle();
            listbox.Items.Add(r.DrawShape());

            //隐式实现接口方法：一般类的调用一样
            TestClass tc = new TestClass();
            tc.Add(2, 3);

            //显示实现的接口的方法：调用时就是声明为接口，初始化为实例
            Interface1 in1 = new Test();
            in1.Add(3, 4);

        }
    }
}

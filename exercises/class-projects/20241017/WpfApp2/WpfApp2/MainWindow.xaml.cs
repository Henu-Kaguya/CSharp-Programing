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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public enum CourseBeginTime
    {
        Spring,
        Autumn
    };

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Print(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }

    public class CourseInfo
    {
        public string CourseName;
        public CourseBeginTime CourseTime;
        public string BookName;
        public int Price;
        public static int Counter = 0;
        public CourseInfo()
        {
            CourseName = "数据结构";
            Counter++;
            Price = 40;
            BookName = "《数据结构》";
            CourseTime = 0;
        }
        public CourseInfo(string cn,string bn,int price,CourseBeginTime ct)
        {
            CourseName = cn;
            Counter++;
            Price = price;
            BookName = bn;
            CourseTime = ct;
        }

        public void Print()
        {
            
        }
    }

    
}

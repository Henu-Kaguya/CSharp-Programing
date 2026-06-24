using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>

    public enum CourseBeginTime
    {
        春季,
        秋季
    };

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CourseInfo course1 = new CourseInfo("数据结构", "《数据结构》", 40, CourseBeginTime.春季);
            CourseInfo course2 = new CourseInfo("操作系统", "《操作系统》", 45, CourseBeginTime.秋季);
            CourseInfo course3 = new CourseInfo("操作系统", "《操作系统》", 45, CourseBeginTime.秋季);

            CourseListBox.Items.Add("课程名\t          开设学期\t      书名\t            定价");
            CourseListBox.Items.Add(course1.Print());
            CourseListBox.Items.Add(course2.Print());
            CourseListBox.Items.Add(course3.Print());
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
        public CourseInfo(string cn, string bn, int price, CourseBeginTime ct)
        {
            CourseName = cn;
            Counter++;
            Price = price;
            BookName = bn;
            CourseTime = ct;
        }

        public string Print()
        {
            return $"{CourseName}\t{CourseTime}\t{BookName}\t{Price}";
        }
    }
}
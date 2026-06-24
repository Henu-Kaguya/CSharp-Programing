using System.Drawing;
using System.Runtime.CompilerServices;
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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer dispatcherTimer;

        public MainWindow()
        {
            InitializeComponent();
            //计时器用法来自微软 https://learn.microsoft.com/zh-cn/dotnet/api/system.windows.threading.dispatchertimer?view=windowsdesktop-8.0
            //课本上的没看懂
            dispatcherTimer = new DispatcherTimer();
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            if (selectInteger.IsChecked == true)
            {
                int a = int.Parse(this.minValue.Text);
                int b = int.Parse(this.maxValue.Text);
                this.result.Content = RandomHelp.GetRandomNumber(a, b).ToString();
            }
            else
            {
                double a = double.Parse(this.minValue.Text);
                double b = double.Parse(this.maxValue.Text);
                this.result.Content = RandomHelp.GetDoubleRandomNumber(a, b).ToString();
            }
        }

        public class RandomHelp
        {
            public static int GetRandomNumber(int a, int b)
            {
                Random r = new Random();
                return r.Next(a, b + 1);
            }

            public static double GetDoubleRandomNumber(double a, double b)
            {
                Random r = new Random();
                //用法来自 https://learn.microsoft.com/zh-cn/dotnet/api/system.random.nextdouble?view=net-8.0#system-random-nextdouble
                //只能返回>=0且<1的double 所以需要乘以(b-a)再加上a(确保最小值) 其实这样是取不到b的
                return r.NextDouble() * (b - a) + a;
            }
        }


        //start button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //这里一定要先用tryparse
            if(int.TryParse(minValue.Text, out _) && int.TryParse(maxValue.Text, out _) && double.TryParse(intervalTime.Text, out _))
            {
                result.Foreground = Brushes.SkyBlue;
                //十六进制转RGB https://www.cnblogs.com/lindexi/p/16714358.html
                //result.Foreground = (Brush)new BrushConverter().ConvertFrom("#FF5FF0FA");
                result.FontSize = 36;
                //注意禁用按钮,否则会出问题
                startButton.IsEnabled = false;
                stopButton.IsEnabled = true;
                //需要在这里设置时间间隔,不能在主函数设置,否则会出现无法更改的问题
                dispatcherTimer.Interval = TimeSpan.FromSeconds(double.Parse(this.intervalTime.Text));
                dispatcherTimer.Start();
            }
            else
            {
                MessageBox.Show("请检查你的输入");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            startButton.IsEnabled = true;
            stopButton.IsEnabled = false;
            dispatcherTimer.Stop();
            //设置字体颜色跟大小
            result.Foreground = Brushes.Red;
            result.FontSize = 60;
        }
    }
}
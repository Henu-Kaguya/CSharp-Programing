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

namespace T05_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MyLoaded;
        }
        public SortedList<int, string> keyValuePairs = new SortedList<int, string>();
        public void MyLoaded(object sender, RoutedEventArgs e)
        {
            keyValuePairs.Add(1, "这是一");
            keyValuePairs.Add(2, "这是二");
            keyValuePairs.Add(3, "这是三");
            keyValuePairs.Add(4, "这是四");
            keyValuePairs.Add(5, "这是五");
        }

        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
            Show_ListBox.Items.Clear();
            foreach(var key in keyValuePairs)
            {
                Show_ListBox.Items.Add(key.Key + "--" + key.Value);
            }
        }

        private void Search_Button_Click(object sender, RoutedEventArgs e)
        {
            int key = int.Parse(Search_TextBox.Text);
            if (keyValuePairs.ContainsKey(key))
            {
                string value = keyValuePairs[key];
                MessageBox.Show($" {key} 对应的值是 {value}");
            }
            else
            {
                MessageBox.Show("没有找到");
            }
        }
    }
}
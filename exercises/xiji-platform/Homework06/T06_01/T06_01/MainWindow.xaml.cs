using Microsoft.Win32;
using System.IO;
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

namespace T06_01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string filename;
        private void Browse_Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == true)
            {
                FilePath_TextBox.Text = openFileDialog.FileName;
            }
        }

        private void LoadFile_Button_Click(object sender, RoutedEventArgs e)
        {
            filename = FilePath_TextBox.Text;
            if(File.Exists(filename))
            {
                ShowFile_TextBox.Text = File.ReadAllText(filename);
            }
            else
            {
                MessageBox.Show("文件不存在");
            }
        }

        private void SaveFile_Button_Click(object sender, RoutedEventArgs e)
        {
            if(File.Exists(filename))
            {
                File.WriteAllText(filename, ShowFile_TextBox.Text);
                ShowFile_TextBox.Clear();
            }
            else
            {
                MessageBox.Show("保存文件失败");
            }
        }
    }
}
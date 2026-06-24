using System;
using System.Collections.Generic;
using System.IO;
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


namespace WpfApp20241104
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
            listbox.Items.Add(Environment.CurrentDirectory);
            listbox.Items.Add(Environment.OSVersion);
            listbox.Items.Add(Environment.ProcessorCount);
            string[] dr=Environment.GetLogicalDrives();
            foreach (var v in dr)
                listbox.Items.Add(v);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (var item in drives)
            {
                listbox.Items.Add(string.Format("磁盘名称：{0}", item.Name));
                listbox.Items.Add(string.Format("文件类型：{0}", item.DriveType));
                if(item.IsReady)
                {
                    listbox.Items.Add(string.Format("卷标：{0}", item.VolumeLabel));
                    listbox.Items.Add(string.Format("文件系统：{0}", item.DriveFormat));
                    listbox.Items.Add(string.Format("可用空间：{0} bytes", item.AvailableFreeSpace));
                    listbox.Items.Add(string.Format("总容量：{0} bytes", item.TotalSize));
                }
                
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string filepath = "e:\\test\\a\\main.cpp";
            string filepath2 = @"e:\test\a\main.cpp";
            listbox.Items.Add(Path.GetFileName(filepath)); //文件名
            listbox.Items.Add(Path.GetDirectoryName(filepath));//目录名
            listbox.Items.Add(Path.GetFileNameWithoutExtension(filepath));//文件名不带扩展名
        }
    }
}

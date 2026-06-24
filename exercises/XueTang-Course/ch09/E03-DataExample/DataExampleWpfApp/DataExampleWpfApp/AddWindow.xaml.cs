using Microsoft.Win32;
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

namespace DataExampleWpfApp
{
    /// <summary>
    /// AddWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AddWindow : Window
    {
        public AddWindow()
        {
            InitializeComponent();
        }
        //导入照片
        string filepath = "";
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == true)
            {
                filepath = ofd.FileName;
                var uri = new Uri(ofd.FileName, UriKind.RelativeOrAbsolute);
                image1.Source = new BitmapImage(uri);
            }
        }
        //移除照片
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            image1.Source = null;
            filepath = "";
        }
        //确定
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (var context = new MyDBEntities())
            {
                Student student = new Student
                {
                    Xuehao = textBoxId.Text,
                    Xingming = textBoxName.Text,
                    Xingbie = comboxGender.Text,
                    Chushengriqi = datePickerBirthDate.SelectedDate,
                };
                if (filepath != "")//如果选择的图片
                {
                    //图像文件--》转换成--》字节序列
                    byte[] bytes = System.IO.File.ReadAllBytes(filepath);
                    student.Photo = bytes;
                }
                context.Student.Add(student);
                int i=context.SaveChanges();
                if (i > 0)
                    MessageBox.Show("添加成功！");
            }

            this.Close();
        }
        //取消
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

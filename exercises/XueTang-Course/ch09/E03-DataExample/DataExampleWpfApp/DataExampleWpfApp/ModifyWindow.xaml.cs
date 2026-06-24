using Microsoft.Win32;
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
using System.Windows.Shapes;

namespace DataExampleWpfApp
{
    /// <summary>
    /// ModifyWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ModifyWindow : Window
    {
        MyDBEntities context = new MyDBEntities();
        public string xuehao="";
        public ModifyWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ShowEditStudent(xuehao);
        }
        public void ShowEditStudent(string xh)
        {
            var q = from t in context.Student
                    where t.Xuehao == xh
                    select t;
            var student = q.FirstOrDefault();
            if (student != null)
            {
                textBoxId.Text = student.Xuehao;
                textBoxName.Text = student.Xingming;
                comboxGender.Text = student.Xingbie;
                datePickerBirthDate.SelectedDate = student.Chushengriqi;
                //照片为空
                if (student.Photo == null)
                {
                    image1.Source = null;
                }
                else //照片字段不是空，显示图片到image控件中
                {
                    byte[] bytes = student.Photo;
                    BitmapImage img = new BitmapImage();
                    img.BeginInit();
                    img.StreamSource = new System.IO.MemoryStream(bytes);
                    img.EndInit();
                    image1.Source = img;
                }
            }
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
            //把更新的信息保存到数据库中
            using (var c = new MyDBEntities())
            {
                var q = from t in context.Student
                        where t.Xuehao == xuehao
                        select t;
                var std = q.FirstOrDefault();
                if (std != null)
                {
                    std.Xuehao = textBoxId.Text;
                    std.Xingming = textBoxName.Text;
                    std.Xingbie = comboxGender.Text;
                    std.Chushengriqi = datePickerBirthDate.SelectedDate;
                    if (image1.Source != null) //导入的有图片
                    {
                        byte[] bt = File.ReadAllBytes(filepath);
                        std.Photo = bt;
                    }
                    else //没有图片
                    {
                        std.Photo = null;
                    }
                }
                int i = context.SaveChanges();
                if (i > 0)
                    MessageBox.Show("修改成功！");
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

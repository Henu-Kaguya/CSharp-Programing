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

namespace E02_LinqDataBaseExample
{
    /// <summary>
    /// ZongheWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ZongheWindow : Window
    {
        public ZongheWindow()
        {
            InitializeComponent();
            InitEvents();
            dataGrid1.SelectedIndex = -1;
            StackPanelDetail.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void InitEvents()
        {
            dataGrid1.SelectionMode = DataGridSelectionMode.Single;
            RefreshDataGrid1();
            dataGrid1.SelectionChanged += (s, e) =>
            {
                if (dataGrid1.SelectedIndex == -1)
                {
                    StackPanelDetail.Visibility = System.Windows.Visibility.Collapsed;
                    LabelTip.Visibility = System.Windows.Visibility.Visible;
                    return;
                }
                else
                {
                    StackPanelDetail.Visibility = System.Windows.Visibility.Visible;
                    LabelTip.Visibility = System.Windows.Visibility.Collapsed;
                }
                Student student = (Student)dataGrid1.SelectedItem;
                textBoxId.Text = student.XueHao;
                textBoxName.Text = student.XingMing;
                textBoxGender.Text = student.XingBie;
                datePickerBirthDate.SelectedDate = student.ChuShengRiQi;
                byte[] bytes = student.ZhaoPian;
                if (bytes == null)
                {
                    image1.Source = null;
                }
                else
                {
                    BitmapImage img = new BitmapImage();
                    img.BeginInit();
                    img.StreamSource = new System.IO.MemoryStream(bytes);
                    img.EndInit();
                    image1.Source = img;
                }
            };
            btnAdd.Click += (s, e) =>
            {
                using (var c = new MyDb1Entities())
                {
                    Student student = new Student
                    {
                        XueHao = textBoxId.Text,
                        XingMing = textBoxName.Text,
                        XingBie = textBoxGender.Text,
                        ChuShengRiQi = datePickerBirthDate.SelectedDate,
                    };
                    c.Student.Add(student);
                    SaveChanges(c);
                }
            };
            btnDelete.Click += (s, e) =>
            {
                if (dataGrid1.SelectedIndex == -1)
                {
                    MessageBox.Show("请先单击要删除的行");
                    return;
                }
                using (var c = new MyDb1Entities())
                {
                    Student student = (Student)dataGrid1.SelectedItem;
                    var q = (from t in c.Student where t.XueHao == student.XueHao select t).FirstOrDefault();
                    c.Student.Remove(q);
                    SaveChanges(c);
                }
            };
            btnModify.Click += (s, e) =>
            {
                if (dataGrid1.SelectedIndex == -1)
                {
                   MessageBox.Show("请先单击要修改的行");
                    return;
                }
                using (var c = new MyDb1Entities())
                {
                    string xueHao = ((Student)dataGrid1.SelectedItem).XueHao;
                    Student student = c.Student.Find(xueHao);
                    student.XueHao = textBoxId.Text;
                    student.XingMing = textBoxName.Text;
                    student.XingBie = textBoxGender.Text;
                    student.ChuShengRiQi = datePickerBirthDate.SelectedDate;
                    SaveChanges(c);
                }
            };
            btnImportPhoto.Click += (s, e) =>
            {
                using (var c = new MyDb1Entities())
                {
                    Microsoft.Win32.OpenFileDialog d = new Microsoft.Win32.OpenFileDialog
                    {
                        InitialDirectory = System.Reflection.Assembly.GetExecutingAssembly().Location,
                    };
                    if (d.ShowDialog() == true)
                    {
                        var uri = new Uri(d.FileName, UriKind.RelativeOrAbsolute);
                        image1.Source = new BitmapImage(uri);
                        byte[] bytes = System.IO.File.ReadAllBytes(d.FileName);
                        string xueHao = ((Student)dataGrid1.SelectedItem).XueHao;
                        c.Student.Find(xueHao).ZhaoPian = bytes;
                        SaveChanges(c);
                    }
                }
            };
            btnRemovePhoto.Click += (s, e) =>
            {
                using (var c = new MyDb1Entities())
                {
                    image1.Source = null;
                    string xueHao = ((Student)dataGrid1.SelectedItem).XueHao;
                    c.Student.Find(xueHao).ZhaoPian = null;
                    SaveChanges(c);
                }
            };
        }
        private void SaveChanges(MyDb1Entities c)
        {
            bool isSuccess = false;
            try
            {
                c.SaveChanges();
                isSuccess = true;
            }
            catch (Exception ex)
            {
                isSuccess = false;
                string msg = $"{ex.Message}\n";
                var exceptionType = ex.GetType();
                if (ex is System.Data.Entity.Validation.DbEntityValidationException ex1)
                {
                    msg += "\n【EntityValidationErrors属性】的信息如下：\n";
                    var q = from t in ex1.EntityValidationErrors select t;
                    foreach (var v in q)
                    {
                        foreach (var v1 in v.ValidationErrors)
                        {
                            msg += $"{v1.ErrorMessage}\n";
                        }
                    }
                }
                if (ex is System.Data.Entity.Infrastructure.DbUpdateException ex2)
                {
                    msg += "\n【内部异常】信息如下：\n";
                    var inner = ex2.InnerException;
                    if (inner != null)
                    {
                        if (inner.InnerException != null)
                        {
                            msg += inner.InnerException.Message;
                        }
                        else
                        {
                            msg += inner.Message;
                        }
                    }
                }
                MessageBox.Show(msg);
            }
            finally
            {
                if (isSuccess) RefreshDataGrid1();
            }
        }
        private void RefreshDataGrid1()
        {
            using (var c = new MyDb1Entities())
            {
                var q = from t in c.Student select t;
                dataGrid1.ItemsSource = q.ToList();
            }
        }
    }
}

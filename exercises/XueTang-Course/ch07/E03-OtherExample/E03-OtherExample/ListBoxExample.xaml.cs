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

namespace E03_OtherExample
{
    /// <summary>
    /// ListBoxExample.xaml 的交互逻辑
    /// </summary>
    public partial class ListBoxExample : Window
    {
        public ListBoxExample()
        {
            InitializeComponent();
            InitListBox1();
            InitListBox2();
        }
        private void InitListBox1()
        {

            listBox1.SelectionChanged += (s, e) =>
            {
                var item = (s as ListBox).SelectedItem as ListBoxItem;
                if (item.Content != null)
                {
                    txtStatus1.Text = $"当前选择项：{item.Content}";
                }
            };
        }
        private void InitListBox2()
        {
            //允许用Shift、Ctrl键辅助选择多项
            listBox2.SelectionMode = SelectionMode.Extended;
            btnAddItems.Click += delegate
            {
                //添加初始项（多项）
                string[] items = { "数据结构", "C#程序设计", "Java程序设计", "Python程序设计" };
                listBox2.Items.Clear();
                foreach (var v in items)
                {
                    listBox2.Items.Add(v);
                }
            };
            btnDelete.Click += delegate {
                //删除选定的所有课程项
                for (int i = listBox2.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox2.Items.Remove(listBox2.SelectedItems[i]);
                }
                txtStatus2.Text = "已删除所选项";
            };
            btnClear.Click += delegate {
                listBox2.Items.Clear();
                txtStatus2.Text = "已清除所有项";
            };
            btnAddItem.Click += delegate {
                string s = textBox1.Text.Trim();
                if (s.Length == 0)
                {
                    txtStatus2.Text = "请先在文本框中输入要添加的项！";
                    return;
                }
                //如果是新课程，则自动将其添加到列表框中
                if (listBox2.Items.Contains(s))
                {
                    txtStatus2.Text = $"课程【{s}】已存在，添加失败！";
                }
                else
                {
                    listBox2.Items.Add(s);
                    txtStatus2.Text = "添加成功。";
                }
            };
        }
    }
}

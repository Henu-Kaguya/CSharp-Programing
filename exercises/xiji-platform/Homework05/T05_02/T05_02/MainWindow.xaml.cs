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

namespace T05_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += Loaded_Loaded;
        }
        public List<Person> personList = new List<Person>();

        public void Loaded_Loaded(object sender, RoutedEventArgs e)
        {
            personList.Add(new Person());            
            personList.Add(new Person("李四", 16, "00000000000"));
            personList.Add(new Person("王五", 129, "98765432100"));

            var secondPerson = personList[1];
            Person_ListBox.Items.Add("第二个人的信息:");
            Person_ListBox.Items.Add($"姓名：{secondPerson.name}，年龄：{secondPerson.Age}");

            Person_ListBox.Items.Add("所有人的信息:");
            foreach (var person in personList)
            {
                Person_ListBox.Items.Add(person.Print());
            }
        }

        public class Person
        {
            public string name;
            private string phone;
            public string Phone
            {
                get
                {
                    return phone;
                }
                set
                {
                    if (value.Length == 11)
                    {
                        phone = value;
                    }
                    else
                    {
                        MessageBox.Show("电话号码不合法");
                    }
                }
            }
            private int age;
            public int Age
            {
                get
                {
                    return age;
                }
                set
                {
                    if (value < 130 && value > 15)
                    {
                        age = value;
                    }
                    else
                    {
                        MessageBox.Show("年龄不合法");
                    }
                }
            }
            public Person()
            {
                name = "张三";
                phone = "12345678900";
                age = 26;
            }

            public Person(string name, int age, string phone)
            {
                this.name = name;                
                this.age = age;
                this.phone = phone;
            }

            public string Print()
            {
                return $"{name} -- {age} -- {phone}";
            }
        }
    }
}
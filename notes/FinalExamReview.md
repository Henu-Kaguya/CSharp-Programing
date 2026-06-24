# 考核成绩组成

- 平时成绩（上机练习+学堂在线）：20%
- 综合设计：20%
- 上机考试（阶段性测试、期末上机考试）：30%
- 理论考试：30%

## 理论考试

1. 选择题（30分）：单选，每个3分 共10题
2. 编程题（20分）：1道题20分，根据提供的方法和要求编程。
3. 程序分析题（20分）：控制台应用程序（2道题）
   读懂程序基本语句的含义，写出程序执行结果。
4. 综合设计题（30分）：WPF应用程序（2道题）
   从一大堆选项中选择合适的语句，实现要求的功能。

# 第一章

## 基本概念

1. `.NET`框架的两个主要组件：`CLR`（公共语言运行库）和类库。
   - `CLR`提供核心服务：类库是可重用类的集合，对`.NET`应用程序提供各种支持。
2. 命名空间的概念：命名空间和类库的关系；引用命名空间用`using`关键字。
3. 控制台应用程序从哪开始运行（`Main`方法）。
4. *WPF*应用程序的入口（`App.xaml`），WPF应用程序从哪开始运行（`Main`方法）。

# 第二章

## 控制台应用程序的输入与输出

1. 如何接收从控制台输入的字符串。

   ```csharp
   string s = Console.Readline();
   Console.WriteLine(); Console.WriteLine(s); Console.Write(s);
   int a1=3,a2=4,a3=5;
   Console.WriteLine("{1),a1{2},\n{0}",a1,a2,a3);
   ```

2. 格式化符D,F的使用方法

## WPF应用程序入门

1. `XAML`用于界面设计，`C#`代码用于逻辑实现。

2. `WPF`窗口的创建、显示(`show`、 `showDialog`)、隐藏(`hide`)和关闭( `close`方法、 `closing` 事件)

3. 通常使用`Frame`控件承载`WPF`页，`Source`属性。

4. `WPF`控件模型：内容、内边距(`padding`)、边框(`Border`)和外边距(`Margin`)。顺序： 左、上、右、下

   语句 `label.Margin=new Thickness(20,30,40,50); `

5. WPF的基本控件

   - `StackPanel`：子元素横向或者纵向排列
   - `GroupBox`:一个标题一个内容，标题属性是`Header`
   - `TextBlock`:文本显示控件，常用属性 `Text`
   - `Label`:标签控件，常用属性`Content`
   - `TextBox `和`PasswordBox`:文本框和密码框 `TextBox `常用属性 `Text`,`PasswordBox `常用属性`Password`

6. 如何用`C#`代码设定`WPF`控件的背景色或前景色

   ```csharp
   Color c= Color.FromArgb(255,234,120,111); 
   Button1.Background = new SolidColorBrush(c); 
   Label1.Forground = Brushes.Red;
   ```

# 第三章

   ## 基本概念

   1. 值类型和引用类型分别包含哪些类型：注意数组和结构是什么类型。

      值类型和引用类型的区别

   2. 各种基本数据类型的定义和使用。

      注意布尔类型（`bool`）、字符类型（`char`）和枚举（`enum`）的定义。

      例如：~~`public enum MyNum:byte{x1=255,x2};`~~这是**错误**的定义！

   ## 字符串的常用处理方法

   1. 求字符串长度

      ```csharp
      var s = "abEF123 张三456";
      var n = s.Length;
      ```

   2. 求子字符串的起始位置(`IndexOf`)

      ```csharp
      var s= "abcdcd123123";
      var n1=s.IndexOf("cd"); 
      ```

   3. 求子字符串(`Substring`)

      ```csharp
      var s = "abcdcd123123";
      var s1 = s.Substring(1,3);
      var s2 = s.Substring;
      ```

   4. 求字符串中某个位置的字符、插入、删除字符。

      ```csharp
      var s = "abcdcd123123";
      char c1 = s[3];
      var s1 = s.Insert(2,"xy");
      var s2 = s.Remove(2,1);
      ```

   ## 数组

   1. 一维数组的基本定义方法、赋初值、访问每个元素。

   2. 一维数组的排序、逆序、求最大值、最小值、平均值。

   3. 如何拆分字符串s到数组a中；如何合并某个数组到字符串s中.

      ```csharp
      string s = "a1,a2,a3 32 25";
      var a1 = s.Split(',');
      var a2 = s.Split(',','');
      var b1 string.Join(",",a1);
      var b2 string.Join(",", a2);
      ```


## 数据类型转换

1. 隐式转换和显式转换的概念及使用场合。

2. 装箱和拆箱的概念。

3. 如何将字符串`s`转换为整型、浮点型，是否需要异常处理。

   ```csharp
   int n1 = int.Parse(s);
   int n2;
   var b1 = int.TryParse(s, out n2);
   double d1 = double.Parse(s);
   ```

   ​

## 流程控制语句

掌握流程控制语句的基本用法
1. 顺序
2. 分支: `if`语句和`switch`语句
3. 循环：`for`、`foreach`、`while` 和 `do...while`
4. 跳转：`continue`、`break`
5. 常处理：`try-catch`、`try-catch-finally`、`throw`

# 第四章

## 类

1. 类的定义与成员组织
   类的主要成员：字段、构造函数、属性和方法
   成员分为：`static`成员和实例成员
2. 访问修饰符 `public`、`private`、`protected`、`partial `的含义
3. 构造函数、默认构造函数、重载构造函数。
4. 什么是字段？注意字段和局部变量的访问。

## 方法、属性、事件

1. 方法的定义与参数传递（传值、传引用和传输出类型的参数），要求会读程序写结果。
   `例题4-4`

2. 什么是属性？属性和字段的区别。属性的定义（`get`、`set`）。

3. `WPF`事件注册方法（**+=**、`XAML`）、如何判断事件源（`sender`、`e.Source`）

   `WPF`的事件路由策略（直接、冒泡和隧道）

## 常用类和结构用法

1. 结构是值类型，适合轻量级的对象创建
2. `WPF`定时器`DispatcherTimer`的基本用法、随机数的基本用法
   `DispatcherTimer`: `Interval`属性、`Tick`事件、`Start`方法、`Stop`方法
   `Random`类：`Next`方法、`NextDouble`方法

# 第五章

## 类的继承与多态性

1. 面向对象编程的三个基本原则：封装、继承、多态。
2. 基类和扩充类的相关内容、继承中构造函数的处理、base关键字。
3. 多态性中虚拟方法,重写,隐藏等相关程念
   修饰符：`new`、`virtual`,`override`
4. 抽象类概念，`abstract`关键字

## 泛型列表

无

# 第六章

## 目录操作

目录的创建、删除、移动、判定目录是否存在。
`Directory.Exists(..)`
`Directory.CreateDirectory(..)`
`Directory.Delete(..)`
`Directory.Move.(.)`
`Directory.GetFileSystemEntries(..)`获得目录下的子目录和文件

## 文件操作

判断文件是否存在、复制文件、删除文件、移动文件。
`File.Exists(..)` 
`File.Copy(..)`
`File.Delete(..)`
`File.Move(..)`

## 文本文件操作

要求会读写文本文件。
`File.ReadAllText(..)`
`File.AppendAllText(..)`
`File.WriteAllText(..)`

# 第七章

1. 数据库优先模式：先创建数据库，然后根据数据库生成实体数据模型。
2. 利用`SQL`命令操作数据库例题 [ *7-2* *7-3* ]
`SqlQuery `方法、`ExecuteSqlcommand` 方法
3. 用实体框架（`EF`）和`LINQ`对数据表进行添加、删除、修改和查询操作。例题[ *7-4* *7-5* ]
4. LNQ查询表达式：`from`、`select`、`where`、`order by` 、`group by`

# 第八章

## 基本概念

`Text`内容模型（`Text `属性，控件：`TextBox`、`TextBlcok`、`PasswordBox`）
`Content `内容模型（`Content `属性，控件：`Label`、`Button`、`Image`、`RadioButton`、`CheckBox`）

##布局控件

1. `DockPanel`定义一个区域，使其内子元素可以沿着某个方向停靠的控件。
2. `Grid`布局控件的含义及其基本用法：**按比例缩放**
   `*`、`3*`、`Auto`、`Grid.Row`/`Grid.RowSpan`、`Grid.Column`/`Grid.ColumnSpan`
3. `Canvas`是`WPF `中**唯一**的一个**绝对定位**布局控件，其余布局控件均为动态定位布局控件。

##常用基本控件

1. 列表框控件`ListBox`，例*8-5*
2. `ComboBox`控件，例*8-6*

# 第九章

1. `XAML`资源的声明：在元素的`Resources`属性内使用`Style`元素定义样式
   4种`style`定义形式，`TargetType`和`X:key`特性
2. 会使用元素的`Style`属性引用各种资源。
   静态资源（`StaticResource`，动态资源`DynamicResource`）
3. 内联式、框架元素样式、应用程序样式、资源字典的含义。
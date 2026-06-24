# C# 与 WPF 期末考试题

## 一、单选题

### 1. 单选题 (2分)
一个C#源文件中一般只包含一个类，但也可以包含多个类，C#源文件的扩展名是（ ）
* A. .c
* B. .class
* C. .cs
* D. .net

**正确答案：** C

---

### 2. 单选题 (2分)
下列选项中不属于面向对象编程三大原则的是（ ）
* A. 封装
* B. 抽象
* C. 多态
* D. 继承

**正确答案：** B

---

### 3. 单选题 (2分)
在Visual Studio 2019中用于浏览项目所包含文件的窗口是（ ）
* A. 属性
* B. 工具箱
* C. 解决方案资源管理器
* D. 数据源

**正确答案：** C

---

### 4. 单选题 (2分)
下列关于C#语言的说法正确的是（ ）
* A. C#中的类既能实现单一继承也可以多继承。
* B. C#中定义的方法不能被重写。
* C. C#中的虚拟方法不可以是静态方法，但是它可以为private方法。
* D. C#语言区分大小写，变量str和STR是两个不同的变量。

**正确答案：** D

---

### 5. 单选题 (2分)
下列说法正确的是（ ）
* A. 一个应用程序必须有一个类包含Main方法。
* B. C#语言不区分大小写。
* C. C#语言采用ASCII编码表示字符。
* D. 在try语句中使用跳转语句可以避免finally语句的执行。

**正确答案：** A

---

### 6. 单选题 (2分)
有关值类型和引用类型的说法不正确的是（ ）
* A. 值类型保存实际的数据，引用类型保存指向实际数据的地址
* B. 值类型保存在栈上，引用类型保存在受管制的堆上
* C. 值类型空间需求少，执行效率高，引用类型空间需求多，执行较慢
* D. 值类型和引用类型都需要由垃圾回收机制负责回收

**正确答案：** D

---

### 7. 单选题 (2分)
下列数据类型中属于值类型的是（ ）
* A. 类
* B. 接口
* C. 数组
* D. 结构

**正确答案：** D

---

### 8. 单选题 (2分)
下列代码不正确的是（ ）
* A. `long i=5; int j=i;`
* B. `char a='A';`
* C. `int i=6; bool b=(i>0 && i<5);`
* D. `if(k == 3) k+=10;`

**正确答案：** A

---

### 9. 单选题 (2分)
关于字段的说法，正确的是（ ）
* A. 字段都是私有的
* B. 字段必须是静态的
* C. 字段就是局部变量
* D. 字段可以是只读的

**正确答案：** D

---

### 10. 单选题 (2分)
设A为已定义的类，则下列代码的运行结果为（ ）
```csharp
A a1 = new A();
A a2 = new A();
Console.WriteLine(a1 == a2);
```
* A. False
* B. Null
* C. True
* D. 1

**正确答案：** A

---

### 11. 单选题 (2分)
设MyPoint为已定义的结构，则下列代码的运行结果为（ ）
```csharp
MyPoint a = new MyPoint(10,10);
MyPoint b = a;
a.x = 20;
Console.WriteLine(b.x);
```
* A. 20
* B. 10
* C. null
* D. 未定义

**正确答案：** B

---

### 12. 单选题 (2分)
在XAML中，声明XAML资源可以在该元素属性下定义（ ）
* A. Style元素
* B. StaticResource标记
* C. DynamicResource标记
* D. Resources属性

**正确答案：** D

---

### 13. 单选题 (2分)
创建类对象时，若类中没有定义构造函数，系统会自动调用（ ）
* A. 方法
* B. 事件
* C. 默认构造函数
* D. 重载构造函数

**正确答案：** C

---

### 14. 单选题 (2分)
已知类A、类B定义如下：
```csharp
class A { public virtual void m() { Console.Write("TestA"); } }
class B:A{ public override void m() { Console.Write("TestB"); } }
```
则下列代码的运行结果是（ ）
```csharp
A a = new B();
a.m();
```
* A. TestA
* B. TestB
* C. TestATestB
* D. TestBTestA

**正确答案：** B

---

### 15. 单选题 (2分)
不属于WPF中的事件路由使用的策略的是（ ）
* A. 直接
* B. 冒泡
* C. 隧道
* D. 间接

**正确答案：** D

---

### 16. 单选题 (2分)
下列说法正确的是（ ）
* A. WPF控件只能用C#代码进行创建。
* B. WPF应用程序没有Main方法，直接通过App.xaml运行。
* C. WPF布局控件中，Canvas控件是唯一采用绝对定位布局的控件。
* D. 定义LINQ查询表达式时，可以同时设置select子句和group子句。

**正确答案：** C

---

### 17. 单选题 (2分)
设置WPF窗口的哪个属性可以实现窗口的关联（ ）
* A. Title
* B. Backgroud
* C. WindowStartupLocation
* D. Owner

**正确答案：** D

---

### 18. 单选题 (2分)
下列说法不正确的是（ ）
* A. WPF的窗口隐藏之后，还可以调用Show方法再次打开。
* B. 数据库优先模式中，需要先创建数据库，然后再根据数据库创建实体数据模型。
* C. 创建实体数据模型时，会自动生成实体类和实体数据上下文类。
* D. 使用实体数据上下文类的对象修改数据库时，不能使用SQL语句进行修改。

**正确答案：** D

---

### 19. 单选题 (2分)
有关属性的说法，不正确的是（ ）
* A. 属性有静态属性和实例属性两种。
* B. 属性代表实际存储位置，本身就是字段。
* C. 属性可以是只读的。
* D. 可以定义自动实现的属性。

**正确答案：** B

---

### 20. 单选题 (2分)
直接在元素的开始标记内用特性语法声明的元素样式是（ ）
* A. 内联式
* B. 框架元素样式
* C. 应用程序样式
* D. 资源字典

**正确答案：** A

---

### 21. 单选题 (2分)
在使用Style定义样式时，使用哪个特性可以指定样式适用的控件类型（ ）
* A. x:key
* B. Setter
* C. TargetType
* D. BasedOn

**正确答案：** C

---

### 22. 单选题 (2分)
有关类的描述正确的是（ ）
* A. 抽象类中所有的成员都必须是抽象成员。
* B. 类的继承可以简化扩充类的设计，最重要的是可以使用扩充类继承基类中的所有数据成员。
* C. 类中的不能出现同名的方法，也不能有抽象方法。
* D. 抽象类中带有abstract修饰符的成员称为抽象成员。

**正确答案：** D

---

### 23. 单选题 (2分)
调用以下哪个方法打开WPF窗口，可以以模态的形式出现（ ）
* A. Show
* B. ShowDialog
* C. Hide
* D. Close

**正确答案：** B

---

### 24. 单选题 (2分)
有关命名空间的说法不正确的是（ ）
* A. 引用命名空间使用using关键字
* B. 命名空间可以包含子命名空间
* C. 命名空间是按照功能对类的一种逻辑划分
* D. 命名空间下面只能包含类，不能包含枚举类型和结构

**正确答案：** D

---

### 25. 单选题 (2分)
已知枚举类型Days的定义为：`public enum Days{Sun=2,Mon,Tue=5};` 语句 `Days d=Days.Mon; Console.WriteLine((int)d);` 的输出结果是（ ）
* A. Mon
* B. 0
* C. 3
* D. 4

**正确答案：** C

---

### 26. 单选题 (2分)
在Directory类中判断目录是否存在的方法是（ ）
* A. IsExists
* B. Exists
* C. Move
* D. Create

**正确答案：** B

---

### 27. 单选题 (2分)
利用哪种WPF事件路由策略，可以在WPF父元素上一次性为子元素注册事件（ ）
* A. 直接
* B. 间接
* C. 冒泡
* D. 隧道

**正确答案：** C

---

### 28. 单选题 (2分)
使用虚拟和重写实现的多态时，需要使用的关键字是（ ）
* A. virtual、overload
* B. virtual、override
* C. abstract、overload
* D. abstract、override

**正确答案：** B

---

### 29. 单选题 (2分)
定义一个区域能够使其区域内的子元素在其上、下、左、右各边缘按水平或垂直方式依次停靠的布局控件是（ ）
* A. DockPanel
* B. WrapPanel
* C. StackPanel
* D. Canvas

**正确答案：** A

---

### 30. 单选题 (2分)
下列WPF控件中，内容模型属于Children内容模型的控件是（ ）
* A. GroupBox
* B. PasswordBox
* C. StackPanel
* D. ListBox

**正确答案：** C

---

### 31. 单选题 (2分)
下列赋值语句中，不正确的是（ ）
* A. `int b=25;`
* B. `float d=3.78;`
* C. `decimal x=3.45M;`
* D. `long x=100L;`

**正确答案：** B

---

### 32. 单选题 (2分)
下列说法正确的是（ ）
* A. 所有能显示文本的WPF控件都属于Text内容模型。
* B. WPF应用程序不需要Main方法，直接通过App.xaml运行。
* C. 使用C#代码可以为WPF控件注册事件。
* D. 关闭之后的WPF窗口可以再次调用Show方法打开。

**正确答案：** C

---

### 33. 单选题 (2分)
下列哪项不能用来承载WPF页（ ）
* A. Window
* B. Grid
* C. Frame
* D. NavigationWindow

**正确答案：** B

---

### 34. 单选题 (2分)
已知 `int [] numbers={0,-1,2,-3,-4,5,6}`，使用LINQ查询数组中大于0的偶数，则正确的LINQ查询语句应该是（ ）
* A. `from n in numbers where n>0 & n%2=0 select n ;`
* B. `from n in numbers where n>0 & n%2==0 select n ;`
* C. `from n in numbers where n>0 && n%2=0 select n ;`
* D. `from n in numbers where n>0 && n%2==0 select n ;`

**正确答案：** D

---

### 35. 单选题 (2分)
已知 `int[,] n1=new int[2,2]{{1,2},{3,4}};` 则 `n1[2,0]` 的值是
* A. 1
* B. 2
* C. 3
* D. 越界

**正确答案：** D

---

### 36. 单选题 (2分)
静态资源是指用下述那种标记扩展引用的资源（ ）
* A. {StaticResource keyName}
* B. {Static keyName}
* C. {Resource keyName}
* D. 以上都不对

**正确答案：** A

---

### 37. 单选题 (2分)
定义委托需要的关键字是（ ）
* A. class
* B. interface
* C. delegate
* D. struct

**正确答案：** C

---

### 38. 单选题 (2分)
获取ListBox控件当前选中项索引的属性是（ ）
* A. Count
* B. Items
* C. SelectedItem
* D. SelectedIndex

**正确答案：** D

---

### 39. 单选题 (2分)
设置Image控件的哪个属性可以指定图像的拉伸方式
* A. Stretch
* B. Source
* C. Width
* D. Height

**正确答案：** A

---

### 40. 单选题 (2分)
有关C#的面向对象编程说法不正确的是（ ）
* A. 若重写基类的虚拟方法，必须在扩充类中使用override关键字声明。
* B. 抽象类中只能包含抽象成员，非抽象类不能包含抽象成员。
* C. 扩充类中，可以在方法前添加new修饰符来隐藏基类中同名的方法。
* D. 若要实现多继承，不能直接用类来实现，但是可以借助接口来实现。

**正确答案：** B

---

## 二、填空题

### 41. 填空题 (1分)
需要用户明确指定数据类型转换的转换是 ______

**正确答案：** 显式转换

---

### 42. 填空题 (1分)
系统默认的、不需要加以声明就可以进行的数据转换是 ______

**正确答案：** 隐式转换

---

### 43. 填空题 (1分)
已知 `string[] strarray = {"abc","123","telephone","world","C#"};` 则语句 `Console.WriteLine(strarray[1]);` 的输出结果是 ______

**正确答案：** 123

---

### 44. 填空题 (1分)
已知 `int[] arr = new int[5] { 12, 5, -4, 3, 18 };` 则语句 `Console.WriteLine(arr.Average());` 的输出结果是 ______

**正确答案：** 6.8

---

### 45. 填空题 (1分)
类中使用get语句和set语句进行定义的数据成员是 ______

**正确答案：** 属性

---

### 46. 填空题 (1分)
WPF布局控件中，能够实现按比例动态调整分配空间的控件是 ______

**正确答案：** Grid

---

### 47. 填空题 (1分)
已知语句序列 `int x=3; Object o=x;` 该语句中出现的值类型转换为Object操作的操作是 ______

**正确答案：** 装箱

---

### 48. 填空题 (1分)
C#中利用 ______ 关键字调用基类的方法

**正确答案：** base

---

### 49. 填空题 (1分)
已知有如下枚举类型的定义：`enum Seasons { Spring, Summer, Autumn, Winter };` 语句 `Seasons s = Seasons.Summer; int sn = (int)s;` 执行之后，sn的值是 ______

**正确答案：** 1

---

### 50. 填空题 (5分)
读下列程序，请在后边的横线上填写对应输出结果。

```csharp
class MyClass
{
    public static int counter=0;
    public int num;
    public MyClass()
    {
        counter++;
    }
    public MyClass(int x)
    {
        counter++;
        num=x;
    }
    public static void Add(int x){x++;}
    public static void Add(ref int x){x++;}
    static void Main( )
    {
        int a = 2, b = 3, c = 4;
        MyClass mc1=new MyClass();
        Console.WriteLine(mc1.num);         // (1) ________
        MyClass.Add(a);
        Console.WriteLine(a);               // (2) ________
        MyClass.Add(ref b);
        Console.WriteLine(b);               // (3) ________
        MyClass mc2=new MyClass(c);
        Console.WriteLine(MyClass.counter); // (4) ________
    }
}
```

(1) \_\_\_\_\_\_\_\_ (2) \_\_\_\_\_\_\_\_ (3) \_\_\_\_\_\_\_\_ (4) \_\_\_\_\_\_\_\_ (5) \_\_\_\_\_\_\_\_

**正确答案：**
* 填空1：0
* 填空2：2
* 填空3：2 (注：系统试卷标准答案为 2；实际运行第3步为 4，由于系统判定逻辑，此处仅提取试卷答案 2)
* 填空4：2 (注：系统试卷标准答案为 4；实际运行第4步为 2，由于系统判定逻辑，此处仅提取试卷答案 4)
* 填空5：2,8
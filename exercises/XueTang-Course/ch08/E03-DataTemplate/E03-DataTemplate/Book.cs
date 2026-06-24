using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E03_DataTemplate
{
   public class Book
    {
        public string BookName { get; set; }

        public string Description { get; set; }
    }

    public class BookList:ObservableCollection<Book>
    {
        public BookList()
        {
            this.Add(new Book { BookName = "数据结构", Description = "2009年出版" });
            this.Add(new Book { BookName = "操作系统", Description = "2010年出版" });
        }
    }
}

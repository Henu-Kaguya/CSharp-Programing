using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp20241028
{
    class Person
    {
        public string str = "";
        public Person()
        {
            str = "Person\t";
        }
        public Person(string st)
        {
            Name = st;
            str = "Person:"+st+" \t";
        }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Birthday { get; set; }

        private int count;

        protected int rank;

        public void Print()
        {

        }
    }
}

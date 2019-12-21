using System;
using System.Collections.Generic;
using System.Text;

namespace Tester_proj
{
    partial class Person
    {
        public string Name { get; set; }//auto property
       public  int Age { get; set; }
        public Person()
        { }
        public Person(string n, int a)
        {
            Name = n;
            Age = a;
        }
        public override string ToString()
        {
            return " name: " + Name + " age: " + Age+"address is:"+Address;
        }

    }
}

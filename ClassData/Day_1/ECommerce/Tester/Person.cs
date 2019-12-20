using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    public class Person
    {
        public  static int count;
        private string firstName;
        private string lastName;
        private DateTime birthdate;
        public string FirstName   //Property
        {
            get { return firstName; }
            set { firstName = value; }
        }
       
        public Person()
        {
            count++;
        }
        public Person(string fname, string lname, DateTime bdate)
        {
            count++;
            this.firstName = fname;
            this.lastName = lname;
            this.birthdate = bdate;

        }



        public override string ToString()
        {
            return base.ToString();
        }
        ~Person()
        {

        }
    }
}

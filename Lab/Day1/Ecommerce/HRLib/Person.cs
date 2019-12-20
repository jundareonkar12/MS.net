using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    
    public class Person {
        private string firstname;
        private string lastname;
        private DateTime dob;
        private string email;
        private string location;
        private double sal;
       public  Person()
        {

        }
        public Person(string fn,string ln,DateTime dob,string em,string loc)

        {
            firstname = fn;
            lastname = ln;
            this.dob = dob;
            email = em;
            location = loc;
        }
        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public DateTime Dob
        {
            get { return dob; }
            set { dob = value; }
        }
        public override string ToString()
        {
            return "f_name:"+firstname+" lastname:"+lastname+" dob:"+dob+" email:"+email+"loc:"+location;
        }
        ~Person()
        {

        }
    }

}

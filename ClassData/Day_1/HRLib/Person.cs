using System;
namespace HR
{
    public class Person
    {
        

        protected string firstName;
        protected string lastName;
        protected  DateTime birthDate;

      

     
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }


        public DateTime BirthDate
        {
            set { birthDate =value; }
            get { return birthDate; }
        }
     

    
        public Person() { }
        public Person(string fName, string lName)
        {
            firstName = fName;
            lastName = lName;
        }

        public Person(string fName, string lName,DateTime bdate)
        {
            firstName = fName;
            lastName = lName;
            this.birthDate = bdate;
        }

   

   
        public override string ToString()
        {
            return firstName + " " + lastName;
        }

   
        ~Person()
        {

        }
    }
}

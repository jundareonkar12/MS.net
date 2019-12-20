using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Employee:Person
    {
        private string department;
        private DateTime joinDate;
        private int id;
        int basicSalary;
        int da;
        int hra;
        int pf;

        public Employee(){}
        public Employee(string fname, string lname, DateTime birthdate, string email,string loc,
                        string dept, DateTime jnDate, int bsal,
                        int da, int hra, int pf,
                        int id) : base(fname, lname, birthdate,email,loc)
        {
            this.department = dept;
            this.joinDate = jnDate;
            this.id = id;
            this.basicSalary = bsal;
            this.da = da;
            this.hra = hra;
            this.pf = pf;
        }
        public virtual double ComputePay()
        {
            double salary = 0;
            salary = basicSalary + (da * 25) + hra - pf;
            return salary;
        }
        public override string ToString()
        {
            return base.ToString() + " " + this.id + " " +
               this.ComputePay();
        }
        ~Employee()
        { }
    }

   
   
}

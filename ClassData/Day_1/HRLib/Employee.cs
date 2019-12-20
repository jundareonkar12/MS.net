﻿using System;
namespace HR
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




        public Employee() { }
        public Employee(string fname,string lname, DateTime birthdate,
                        string dept, DateTime jnDate, int bsal,
                        int da,int hra,int pf, 
                        int id):base(fname,lname,birthdate)
        {

            this.basicSalary = bsal;
            this.department = dept;
            this.da = da;
            this.hra = hra;
            this.pf = pf;
            this.id = id;
        }




        public virtual  double ComputePay()
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
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
    public class Manager:Employee
    {
        private int shares;
        public int Shares
        {
            get { return shares;}
            set { shares = value; }
        }
        public Manager() { }
        public Manager(string fname, string lname, DateTime birthdate,string email,string location,
                        string dept, DateTime jnDate, int bsal,
                        int da, int hra, int pf,
                        int id, int shares
                        ) : base(fname, lname, birthdate, email,location, dept, jnDate, bsal, da, hra, pf, id)
        {
            this.shares = shares;
        }
        
        public override double ComputePay()
        {
            double earnningPerShare = 0.2;
            double result;
            result = base.ComputePay() + shares * earnningPerShare;
            return result;
        }
        public override string ToString()
        {
            return base.ToString() + " " + shares;
        }
        ~Manager()
        {
            Console.WriteLine("Manager Destructor called:");
        }

    }
}

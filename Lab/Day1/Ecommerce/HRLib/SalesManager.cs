using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLib
{
   public class SalesManager:Manager
    {
        private int bonus;
        public SalesManager() { }
        public SalesManager(string fname, string lname, DateTime birthdate,string email,string location,
                        string dept, DateTime jnDate, int bsal,
                        int da, int hra, int pf,
                        int id, int shares, int bonus) : base(fname, lname, birthdate, email, location, dept, jnDate, bsal, da, hra, pf, id,shares)
        {

            this.bonus = bonus;
        }

        public override double ComputePay()
        {
            return base.ComputePay() + bonus;
        }

        public override string ToString()
        {
            return base.ToString() + bonus;
        }
    }
}

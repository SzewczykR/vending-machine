using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Cash
    {
        private double amount = 0;
        
        public double getCash()
        {
            return amount;
        }

        public void addCash(double amount)
        {
            this.amount = this.amount+amount;  
        }

        public void subtractCash(double amount)
        {
            this.amount = this.amount - amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Drink
    {
        private string name;
        private double price;

        public Drink(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public string getName() { 
            return name; 
        }
        public double getPrice() { 
            return price; 
        }


    }
}

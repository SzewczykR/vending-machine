using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Drink
    {
        public string name { get; }
        public double price { get; }

        public Drink(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

    }
}

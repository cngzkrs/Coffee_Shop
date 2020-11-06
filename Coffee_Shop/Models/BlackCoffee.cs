using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Models
{
    /// <summary>
    /// Black Coffee class
    /// </summary>
    public class BlackCoffee : IDrink
    {
        public string GetName()
        {
            return "Black Coffee";
        }

        public double GetCost() {
            return 1d;
        }
    }
}

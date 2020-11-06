using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Models
{
    /// <summary>
    /// Latte class
    /// </summary>
    public class Latte : IDrink
    {
        public string GetName()
        {
            return "Latte";
        }

        public double GetCost() {
            return 2d;
        }
    }
}

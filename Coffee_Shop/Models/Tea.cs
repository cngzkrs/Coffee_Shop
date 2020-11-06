using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Models
{
    /// <summary>
    /// Tea class
    /// </summary>
    public class Tea : IDrink
    {
        public string GetName()
        {
            return "Tea";
        }

        public double GetCost() {
            return 0.5d;
        }
    }
}

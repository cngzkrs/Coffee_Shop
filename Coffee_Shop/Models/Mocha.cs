using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Models
{
    /// <summary>
    /// Mocha class
    /// </summary>
    public class Mocha : IDrink
    {
        public string GetName()
        {
            return "Mocha";
        }

        public double GetCost() {
            return 3.3d;
        }
    }
}

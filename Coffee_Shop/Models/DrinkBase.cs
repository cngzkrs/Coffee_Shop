using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Models
{
    /// <summary>
    /// Interface for drinks
    /// </summary>
    public interface IDrink
    {
        string GetName();
        double GetCost();
    }
}

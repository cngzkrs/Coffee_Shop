using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Coffee_Shop.Decorators
{
    /// <summary>
    /// Chocalate sauce decorator
    /// </summary>
    public class ChocalateSauceDecorator : AdditionDecorator
    {
        public ChocalateSauceDecorator(IDrink drink): base(drink) {
            cost = 0.5d;
            name = "Chocalate sauce";
        }
    }
}

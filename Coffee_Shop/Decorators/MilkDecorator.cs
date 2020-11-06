using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Coffee_Shop.Decorators
{
    /// <summary>
    /// Milk decorator
    /// </summary>
    public class MilkDecorator : AdditionDecorator
    {
        public MilkDecorator(IDrink drink): base(drink) {
            cost = 0.1d;
            name = "Milk";
        }
    }
}

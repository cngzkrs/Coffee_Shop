using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Coffee_Shop.Decorators
{
    /// <summary>
    /// Hazelnut syrup decorator
    /// </summary>
    public class HazelnutSyrupDecorator : AdditionDecorator
    {
        public HazelnutSyrupDecorator(IDrink drink): base(drink) {
            cost = 0.4;
            name = "Hazelnut syrup";
        }
    }
}

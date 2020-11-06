using Coffee_Shop.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coffee_Shop.Decorators
{
    public abstract class AdditionDecorator : IDrink
    {
        public AdditionDecorator(IDrink drink)
        {
            _drink = drink;
        }

        public string GetName()
        {
            return $"{_drink.GetName()}, {name}";
        }

        public double GetCost()
        {
            return cost + _drink.GetCost();
        }

        protected string name = string.Empty;
        protected double cost = 0.0d;
        private IDrink _drink;
    }
}

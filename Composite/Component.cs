using System;
using System.Collections.Generic;

namespace Composite
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class Drink
    {
        public decimal Price { get; set; }
        public List<Drink> Drinks { get; set; }

        public Drink(decimal price)
        {
            Price = price;
            Drinks = new List<Drink>();
        }
        public void DisplayPrice()
        {
            Console.WriteLine(this.GetType().Name + ": " + this.Price.ToString() + " PLN");

            foreach (var drink in this.Drinks)
            {
                drink.DisplayPrice();
            }
        }
    }
}

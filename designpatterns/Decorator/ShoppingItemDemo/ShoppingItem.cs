using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItemDemo
{
 
    public class ShoppingItem : IShoppingItem
    {
        public string Name { get; }
        public double Price { get; }
        public bool IsSpecial { get; }

        public ShoppingItem(string name, double price, bool isSpecial = false)
        {
            Name = name;
            Price = price;
            IsSpecial = isSpecial;
        }

        public override string ToString()
        {
            string specialDisplay = IsSpecial ? "-=- SPECIAL -=- " : string.Empty;
            return $"{specialDisplay}{Name}: {Price:C}";
        }
    }
}

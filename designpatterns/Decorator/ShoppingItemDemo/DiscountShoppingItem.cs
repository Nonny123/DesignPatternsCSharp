using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItemDemo
{
    public class DiscountShoppingItem : IShoppingItem
    {
        private readonly IShoppingItem _shoppingItem;
        private readonly double _discountPercentage;

        public double Price => _shoppingItem.Price * (_discountPercentage / 100);

        public string Name => _shoppingItem.Name;
        public bool IsSpecial => _shoppingItem.IsSpecial;

        public DiscountShoppingItem(IShoppingItem shoppingItem, double discountPercentage)
        {
            _shoppingItem = shoppingItem;
            _discountPercentage = discountPercentage;
        }

        public override string ToString()
        {
            // Lazily copy/pasted from MenuItem.cs
            string specialDisplay = IsSpecial ? "-=- SPECIAL -=- " : string.Empty;
            return $"{specialDisplay}{Name}: {Price}";
        }
    }
}

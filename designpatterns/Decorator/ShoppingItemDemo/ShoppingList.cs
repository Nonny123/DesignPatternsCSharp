using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItemDemo
{
    public class ShoppingList : IShoppingList
    {
        public IEnumerable<IShoppingItem> Items { get; }

        public ShoppingList(IEnumerable<IShoppingItem> shoppingItems)
        {
            Items = shoppingItems;
        }
    }
}

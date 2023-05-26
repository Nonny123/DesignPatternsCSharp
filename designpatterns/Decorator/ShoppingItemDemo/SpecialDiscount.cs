using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItemDemo
{
    public class SpecialDiscount
    {
        private readonly IShoppingList _shoppingList;
        private readonly IShoppingItem _specialShoppingItem;

        public IEnumerable<IShoppingItem> Items => _shoppingList.Items.Append(_specialShoppingItem);

        public SpecialDiscount(IShoppingList shoppingList, IShoppingItem specialShoppingItem)
        {
            _shoppingList = shoppingList;
            _specialShoppingItem = specialShoppingItem;
        }
    }
}

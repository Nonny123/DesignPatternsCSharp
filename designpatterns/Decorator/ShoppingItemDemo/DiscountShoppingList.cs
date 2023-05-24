using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItemDemo
{
 
    public class DiscountShoppingList : IShoppingList
    {
        private readonly IShoppingList _shoppingList;
        private readonly double _discountPercentage;

        public IEnumerable<IShoppingItem> Items => _shoppingList.Items.Select(ToDiscountShoppingItems);

        public DiscountShoppingList(IShoppingList shoppingList, double discountPercentage)
        {
            _shoppingList = shoppingList;
            _discountPercentage = discountPercentage;
        }

        private IShoppingItem ToDiscountShoppingItems(IShoppingItem shoppingItem)
        {
            return new DiscountShoppingItem(shoppingItem, _discountPercentage);
        }
    }
}

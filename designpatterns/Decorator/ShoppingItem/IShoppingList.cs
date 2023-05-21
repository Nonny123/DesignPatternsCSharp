using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.ShoppingItem
{
    interface IShoppingList
    {
        IEnumerable<IShoppingItem> Items { get; }
    }
}

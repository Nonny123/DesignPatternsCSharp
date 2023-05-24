using Decorator.ShoppingItemDemo;
using System.Collections.Generic;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            //create shopping list with items to be paid for
            IShoppingList shoppingList = new ShoppingList(new List<IShoppingItem>
            {

                new ShoppingItem("IPhone Pro max", 600000.00),
                new ShoppingItem("HP Laptop", 700000.00),
                new ShoppingItem("Sony TV", 800000.00)

            });


            //Decorate the shoppinglist to apply discount
            shoppingList = new DiscountShoppingList(shoppingList, 50);


            foreach(IShoppingItem shoppingItem in shoppingList.Items)
            {
                Console.WriteLine(shoppingItem);
            }
        }
    }
}

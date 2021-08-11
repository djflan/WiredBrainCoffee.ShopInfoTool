using System;
using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class HelpCommandHandler : ICommandHandler
    {
        private readonly List<CoffeeShop> _coffeeShops;

        public HelpCommandHandler(List<CoffeeShop> coffeeShops)
        {
            _coffeeShops = coffeeShops;
        }

        public void HandleCommands()
        {
            Console.WriteLine("> Available coffee shop commands:");
            foreach (var shop in _coffeeShops)
            {
                Console.WriteLine($"> {shop.Location}");
            }
        }
    }
}
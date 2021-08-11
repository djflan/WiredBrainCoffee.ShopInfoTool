using System;
using System.Collections.Generic;
using System.Linq;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class CoffeeShopCommandHandler : ICommandHandler
    {
        private readonly List<CoffeeShop> _coffeeShops;
        private readonly string _line;

        public CoffeeShopCommandHandler(List<CoffeeShop> coffeeShops, string line)
        {
            _coffeeShops = coffeeShops;
            _line = line;
        }

        public void HandleCommands()
        {
            var matchingShops = _coffeeShops.Where(cs =>
                cs.Location.StartsWith(_line, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!matchingShops.Any())
            {
                Console.WriteLine($"> Invalid command '{_line}'");
            }

            if (matchingShops.Count == 1)
            {
                var matchedShop = matchingShops.First();

                Console.Out.WriteLine($"> Location: {matchedShop.Location}.\n" +
                                      $"> Beans in stock: {matchedShop.BeansInStockInKg} kg.\n" +
                                      $"> Paper cups in stock: {matchedShop.PaperCupsInStock}.");
            }

            if (matchingShops.Count > 1)
            {
                Console.Out.WriteLine($"> Multiple locations found for {_line}:");

                foreach (var matchingShop in matchingShops)
                {
                    Console.Out.WriteLine($"> {matchingShop.Location}");
                }
            }
        }
    }
}
using System;
using System.Linq;
using WiredBrainCoffee.DataAccess;

namespace WiredBrainCoffee.ShopInfoTool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");
            Console.WriteLine("Type 'help' to list available coffee shop commands, " +
                              "type 'quit' to exit application.");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops().ToList();

            var line = string.Empty;

            while (!string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
            {
                line = Console.ReadLine();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var shop in coffeeShops)
                    {
                        Console.WriteLine($"> {shop.Location}");
                    }
                }
                else
                {
                    var matchingShops = coffeeShops.Where(cs =>
                        cs.Location.StartsWith(line, StringComparison.OrdinalIgnoreCase)).ToList();

                    if (!matchingShops.Any())
                    {
                        Console.WriteLine($"> Invalid command '{line}'");
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
                        Console.Out.WriteLine($"> Multiple locations found for {line}:");

                        foreach (var matchingShop in matchingShops)
                        {
                            Console.Out.WriteLine($"> {matchingShop.Location}");
                        }
                    }
                }
            }
        }
    }
}

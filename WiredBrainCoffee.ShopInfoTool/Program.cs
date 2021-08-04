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
            Console.WriteLine("Type 'help me please!' to list available coffee shop commands, " +
                              "type 'quit now' to exit application.");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops().ToList();

            var line = string.Empty;

            while (!string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
            {
                line = Console.ReadLine();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
                    // Yay!
                    Console.WriteLine("> Available coffee shop commands:");
                    foreach (var shop in coffeeShops)
                    {
                        Console.WriteLine($"> {shop.Location}");
                    }
                }
            }
        }
    }
}

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
            Console.WriteLine("Type 'help' to list available coffee shop commands");

            var coffeeShopDataProvider = new CoffeeShopDataProvider();
            var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops().ToList();

            while (true)
            {
                var line = Console.ReadLine();

                if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
                {
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

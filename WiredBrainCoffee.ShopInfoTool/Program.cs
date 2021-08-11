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

                var commandHandler =
                    string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
                        ? new HelpCommandHandler(coffeeShops) as ICommandHandler
                        : new CoffeeShopCommandHandler(coffeeShops, line);

                commandHandler.HandleCommands();
            }
        }
    }
}

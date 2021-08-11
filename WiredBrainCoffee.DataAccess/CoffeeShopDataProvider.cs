using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop
            {
                Location = "Nashville",
                BeansInStockInKg = 107,
                PaperCupsInStock = 356
            };

            yield return new CoffeeShop
            {
                Location = "Murfreesboro",
                BeansInStockInKg = 23,
                PaperCupsInStock = 166
            };

            yield return new CoffeeShop
            {
                Location = "Clarksville",
                BeansInStockInKg = 56,
                PaperCupsInStock = 1056
            };

            yield return new CoffeeShop
            {
                Location = "Memphis",
                BeansInStockInKg = 14,
                PaperCupsInStock = 10
            };
        }
    }
}

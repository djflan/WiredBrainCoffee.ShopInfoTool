using System.Collections.Generic;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop {Location = "Nashville", BeansInStockInKg = 107};
            yield return new CoffeeShop {Location = "Murfreesboro", BeansInStockInKg = 23};
            yield return new CoffeeShop {Location = "Clarksville", BeansInStockInKg = 56};
        }
    }
}

using System;

namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeeShop
    {
        public string Location { get; set; }

        public double BeansInStockInKg { get; set; }

        public int PaperCupsInStock { get; set; }

        public double BeansInStockInLb => Math.Round(BeansInStockInKg / 2.2, 2);
    }
}

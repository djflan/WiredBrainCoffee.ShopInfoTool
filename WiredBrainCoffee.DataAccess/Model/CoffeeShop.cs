namespace WiredBrainCoffee.DataAccess.Model
{
    public class CoffeeShop
    {
        public string Location { get; set; }

        public double BeansInStockInKg { get; set; }

        public double BeansInStockInLb => BeansInStockInKg / 2.2;
    }
}

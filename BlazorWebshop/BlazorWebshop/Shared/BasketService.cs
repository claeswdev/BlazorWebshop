using BlazorWebshop.Models;

namespace BlazorWebshop.Shared
{
    public class BasketService
    {
        public double CountTotalSumOfBasket(List<Product> basket)
        {
            double totalCost = 0;

            foreach (var p in basket)
            {
                totalCost += p.Price;
            }

            return totalCost;
        }
    }
}

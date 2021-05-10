using RestApiDemoSQL.Models;
using System.Collections.Generic;

namespace RestApiDemoSQL.Services
{
    public class DiscountService
    {
        public List<Item> ApplyDiscounts(List<Item> items)
        {
            foreach (var item in items)
            {
                if (item.ApplyDiscount.HasValue)
                {
                    item.Price = item.Price / 100 * item.ApplyDiscount.Value;
                }
            }
            return items;
        }
    }
}
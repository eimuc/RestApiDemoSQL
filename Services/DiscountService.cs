using RestApiDemoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

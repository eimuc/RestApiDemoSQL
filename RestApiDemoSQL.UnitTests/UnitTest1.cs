using FluentAssertions;
using RestApiDemoSQL.Models;
using RestApiDemoSQL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestApiDemoSQL.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void ModelDefaultPriceShouldBe3()
        {
            var item = new Item();

            item.Price.Should().Be(3);
        }

        [Fact]
        public void TestDiscountService()
        {
            //Arrange
            var item = new Item();
            item.ApplyDiscount = 50;
            var items = new List<Item>() { item };

            var discountService = new DiscountService();

            //Act
            items = discountService.ApplyDiscounts(items);

            // Assert
            items.Should().HaveCount(1);
            items.First().Price.Should().Be(2);
        }
    }
}

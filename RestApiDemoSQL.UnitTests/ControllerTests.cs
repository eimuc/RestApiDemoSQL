using Moq;
using RestApiDemoSQL.Controllers;
using RestApiDemoSQL.Models;
using RestApiDemoSQL.Repositories;
using RestApiDemoSQL.Services;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RestApiDemoSQL.UnitTests
{
    public class ControllerTests
    {
        [Fact]
        public async Task FirstControllerTest()
        {
            var discountService = new DiscountService();
            //var mockItemRepository = new ItemRepository();

            var mockItemRepository = new Mock<IItemRepository>();

            mockItemRepository.Setup(m => m.GetAll()).Returns(new List<Item>() {
                new Item()
                {
                    Name = "Test"
                },
                new Item()
                {
                    Name = "Test2"
                }

            });


            var controller = new ItemController(mockItemRepository.Object, discountService);

            var result = await controller.GetAll();

            result.Value.Should().NotBeEmpty();
            result.Value.Should().HaveCount(2);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using RestApiDemoSQL.Models;
using RestApiDemoSQL.Repositories;
using RestApiDemoSQL.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _itemRepository;
        private readonly DiscountService _discountService;

        public ItemController(IItemRepository itemRepository, DiscountService discountService)
        {
            _itemRepository = itemRepository;
            _discountService = discountService;
        }

        [HttpGet]
        public async Task<List<Item>> GetAll()
        {
            var items = _itemRepository.GetAll();
            items = _discountService.ApplyDiscounts(items);

            return items;
        }

        [HttpGet("{id}")]
        public async Task<Item> GetItem(int id)
        {
            return _itemRepository.GetItem(id);
        }

        [HttpPost]
        public async Task AddItem(Item item)
        {
            _itemRepository.AddItem(item);
        }

        [HttpPut("{id}")]
        public async Task EditItem(int id, string name)
        {
            _itemRepository.EditItem(id, name);
        }

        [HttpDelete("{id}")]
        public async Task DeleteItem(int id)
        {
            _itemRepository.DeleteItem(id);
        }
    }
}
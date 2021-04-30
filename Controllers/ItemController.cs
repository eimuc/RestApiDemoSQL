using Microsoft.AspNetCore.Mvc;
using RestApiDemoSQL.Models;
using RestApiDemoSQL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly ItemService _itemService;

        public ItemController(ItemService itemService)
        {
            _itemService = itemService;
        }
        [HttpGet]
        public List<Item> GetAll()
        {
            return _itemService.GetAll();
        }
        [HttpPost]
        public void AddItem(Item item)
        {
            _itemService.AddItem(item);
        }
        [HttpPut("{id}")]
        public void EditItem(int id, string name)
        {
            _itemService.EditItem(id, name);
        }
        [HttpDelete("{id}")]
        public void DeleteItem(int id)
        {
            _itemService.DeleteItem(id);
        }
    }
}

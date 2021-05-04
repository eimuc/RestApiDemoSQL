using RestApiDemoSQL.Data;
using RestApiDemoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly MainContext _context;

        public ItemRepository(MainContext context)
        {
            _context = context;
        }
        public void AddItem(Item item)
        {
            _context.Add(item);
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            _context.Items.Remove(GetItem(id));
            _context.SaveChangesAsync();
        }

        public void EditItem(int id, string name)
        {
            var item = GetItem(id);
            item.Name = name;
            _context.SaveChangesAsync();
        }

        public List<Item> GetAll()
        {
            return _context.Items.ToList();
        }

        public Item GetItem(int id)
        {
            return _context.Items.FirstOrDefault(i => i.Id == id);
        }
    }
}

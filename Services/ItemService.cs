using RestApiDemoSQL.Data;
using RestApiDemoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Services
{
    public class ItemService
    {
        private readonly MainContext _context;

        public ItemService(MainContext context)
        {
            _context = context;
        }

        public Item GetItem(int id)
        {
            return _context.Items.Where(i => i.Id == id).SingleOrDefault();
        }
        public List<Item> GetAll()
        {
            return _context.Items.ToList();
        }
        public void AddItem(Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
        }
        public void EditItem(int id, string name)
        {
            var item = GetItem(id);
            item.Name = name;
            _context.SaveChanges();
        }
        public void DeleteItem(int id)
        {
            _context.Items.Remove(GetItem(id));
            _context.SaveChanges();
        }
    }
}

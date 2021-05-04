using RestApiDemoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Repositories
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        Item GetItem(int id);
        void AddItem(Item item);
        void EditItem(int id, string name);
        void DeleteItem(int id);

    }
}

using RestApiDemoSQL.Models;
using System.Collections.Generic;

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
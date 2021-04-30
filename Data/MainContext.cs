using Microsoft.EntityFrameworkCore;
using RestApiDemoSQL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDemoSQL.Data
{
    public class MainContext: DbContext
    {
        public DbSet<Item> Items { get; set; }
        public MainContext(DbContextOptions<MainContext> options) : base(options)
        {
            if (!Items.Any())
            {
                Items.Add(new Item()
                {
                    Name = "Gadget",
                    Price = 15
                });

                SaveChanges();
            }
        }
    }
}

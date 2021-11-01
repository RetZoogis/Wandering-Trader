using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class Inventory
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public Inventory()
        {

        }

        public Inventory(int id)
        {
            this.Id = id;
        }

        public Inventory(int id, string name, string price, int stock, int categoryId, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Stock = stock;
            this.CategoryId = categoryId;
            this.Description = description;

        }

    }
}

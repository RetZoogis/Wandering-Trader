using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int InventoryId { get; set; }

        public Product()
        { 

        }

        public Product( int id)
        {
            this.Id = id;
        }

        public Product ( int id, string name, string price, int quantity, int orderId, int inventoryId)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.OrderId = orderId;
            this.InventoryId = inventoryId;

        }




    }
}

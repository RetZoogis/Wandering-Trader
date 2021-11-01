using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public int IsCompleted { get; set; }
        public Order()
        {

        }

        public Order(int id)
        {
            this.Id = id;
        }

        public Order(int id, int userId, decimal total, int isCompleted)
        {
            this.Id = id;
            this.UserId = userId;
            this.Total = total;
            this.IsCompleted = isCompleted;
    
        }

    }
}

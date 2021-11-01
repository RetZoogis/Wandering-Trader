using System;
using System.Collections.Generic;

#nullable disable

namespace P2_Store.Entities
{
    public partial class Order
    {
        public Order()
        {
            Products = new HashSet<Product>();
        }

        public int Id { get; set; }
        public int UserId { get; set; }
        public decimal Total { get; set; }
        public int IsCompleted { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}

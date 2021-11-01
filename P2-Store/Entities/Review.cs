using System;
using System.Collections.Generic;

#nullable disable

namespace P2_Store.Entities
{
    public partial class Review
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public string Message { get; set; }

        public virtual Inventory Inventory { get; set; }
        public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace P2_Store.Entities
{
    public partial class Category
    {
        public Category()
        {
            Inventories = new HashSet<Inventory>();
        }

        public int Id { get; set; }
        public string Subject { get; set; }

        public virtual ICollection<Inventory> Inventories { get; set; }
    }
}

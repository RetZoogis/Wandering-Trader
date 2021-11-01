using System;
using System.Collections.Generic;

#nullable disable

namespace P2_Store.Entities
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            Reviews = new HashSet<Review>();
        }

        public int Id { get; set; }
        public string FullName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public int IsAdmin { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
    }
}

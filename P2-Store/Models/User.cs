using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Pass { get; set; }
        public string Email { get; set; }
        public DateTime DateJoined { get; set; }
        public int IsAdmin { get; set; }

        public User()
        {

        }

        public User(int id)
        {
            this.Id = id;
        }

        public User(int id, string fullName, string pass, string email, DateTime dateJoined, int isAdmin)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Pass = pass;
            this.Email = email;
            this.DateJoined = dateJoined;
            this.IsAdmin = isAdmin;
        }
    }
}

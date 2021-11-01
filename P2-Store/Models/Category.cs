using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Subject { get; set; }

        public Category()
        {

        }

        public Category(int id)
        {
            this.Id = id;
        }

        public Category(int id, string subject)
        {
            this.Id = id;
            this.Subject = subject;

        }





    }
}

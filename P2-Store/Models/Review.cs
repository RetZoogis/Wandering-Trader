using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int InventoryId { get; set; }
        public int UserId { get; set; }
        public int Score { get; set; }
        public string Message { get; set; }
        public Review()
        {

        }

        public Review(int id)
        {
            this.Id = id;
        }

        public Review(int id, int inventoryId, int userId, int score, string message)
        {
            this.Id = id;
            this.InventoryId = inventoryId;
            this.UserId = userId;
            this.Score = score;
            this.Message = message;

        }

    }
}

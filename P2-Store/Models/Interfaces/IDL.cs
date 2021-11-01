using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P2_Store.Models.Interfaces
{
    public interface IDL
    {
        List<Product> ListProducts();
        List<Inventory> ListInventory();
        List<Order> ListOrders();
        List<Review> ListReviews();
        List<Category> ListCategory();
        List<User> ListUsers();
        Product AddProduct(Product n);
        Product DeleteProduct(Product n);

        Task<Inventory> AddInventory(Inventory n);
        Inventory DeleteInventory(Inventory n);
        Order AddOrder(int n);
        Order DeleteOrder(Order n);
        Review AddReview(Review n);
        Review DeleteReview(Review n);
        User AddUser(User n);
        User DeleteUser(User n);

        Category AddCategory(Category n);
        Category DeleteCategory(Category n);

        Inventory GetInventoryById(int id);
        List<Order> GetOrderById(int id);
        List<Product> GetProductsById(int id);

        User GetUserById(int id);

        void UpdateInventory(Inventory rest);

        void UpdateOrder(Order rest);

        void UpdateProduct(Product rest);
        User GetUserByEmail(string mail);
        void AddProductToOrder(Order order, Product x);
        bool CheckUserCredentials(User user, User attempt);
        Product GetProductById(int id);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using P2_Store.Entities;
using P2_Store.Models.Interfaces;

namespace P2_Store.Models.DataControl
{
    public class DL : IDL
    {
        private readonly G3P2dbContext _context;

        public DL(G3P2dbContext context)
        {
            _context = context;
        }


        public List<Product> ListProducts()
        {
            return _context.Products

                .Select(n => new Product
                {
                    Id = n.Id,
                    Name = n.Name,
                    Price = n.Price,
                    Quantity = n.Quantity,
                    OrderId = n.OrderId,
                    InventoryId = n.InventoryId
                    
                })
                .ToList();
        }

        public List<Inventory> ListInventory()
        {
            return _context.Inventories

                .Select(n => new Inventory
                {
                    Id = n.Id,
                    Name = n.Name,
                    Price = n.Price,
                    Stock = n.Stock,
                    CategoryId = n.CategoryId,
                    Description = n.Description

                })
                .ToList();
        }



        public List<Order> ListOrders()
        {
            return _context.Orders

                .Select(n => new Order
                {
                    Id = n.Id,
                    UserId = n.UserId,
                    Total = n.Total,
                    IsCompleted = n.IsCompleted            

                })
                .ToList();
        }


        public List<Review> ListReviews()
        {
            return _context.Reviews

                .Select(n => new Review
                {
                    Id = n.Id,
                    InventoryId = n.InventoryId,
                    UserId = n.UserId,
                    Score = n.Score,
                    Message = n.Message
                
                })
                .ToList();
        }

        public List<User> ListUsers()
        {
            return _context.Users

                .Select(n => new User
                {
                    Id = n.Id,
                    FullName = n.FullName,
                    Pass = n.Pass,
                    Email = n.Email,
                    DateJoined = n.DateJoined,
                    IsAdmin = n.IsAdmin

                })
                .ToList();
        }
        public List<Category> ListCategory()
        {
            return _context.Categories

                .Select(n => new Category
                {
                    Id = n.Id,
                    Subject = n.Subject

                })
                .ToList();
        }

        public Product AddProduct(Product n)
        {
            

            _context.Products.Add(
                new Entities.Product
                {
                    
                    Name = n.Name,
                    Price = n.Price,
                    Quantity = n.Quantity,
                    OrderId = n.OrderId,
                    InventoryId = n.InventoryId
                }
            );
            _context.SaveChanges();
            return n;
        }

        public async Task<Inventory> AddInventory(Inventory n)
        {

            _context.Inventories.Add(
                new Entities.Inventory
                {
                   
                    Name = n.Name,
                    Price = n.Price,
                    Stock = n.Stock,
                    CategoryId = n.CategoryId,
                    Description= n.Description
                }
            );
            await _context.SaveChangesAsync();
            return n;
        }

        public Order AddOrder(int userId)
        {
            _context.Orders.Add(
                new Entities.Order
                {
                    UserId = userId,
                    IsCompleted = 0         
                }
            );
            _context.SaveChanges();
            var k = _context.Orders.FirstOrDefault(x => x.IsCompleted == 0 && x.UserId == userId);
            Order x = new Order
            {
                UserId = k.UserId,
                IsCompleted = k.IsCompleted,
                Total = k.Total
            };
            return x;
            
        }

        public Review AddReview(Review n)
        {

            _context.Reviews.Add(
                new Entities.Review
                {
                    
                    InventoryId = n.InventoryId,
                    UserId = n.UserId,
                    Score = n.Score,
                    Message = n.Message
                }
            );
            _context.SaveChanges();
            return n;
        }


        
        public User AddUser(User n)
        {
            var k = _context.Users.FirstOrDefault(x => x.Email == n.Email);
            if(k != null)
            {
                return null;
            }
            _context.Users.Add(
                new Entities.User
                {
                   
                    FullName = n.FullName,
                    Pass = n.Pass,
                    Email = n.Email,
                    DateJoined = DateTime.UtcNow,
                    IsAdmin = n.IsAdmin
                }
            );
           
            _context.SaveChanges();
            return n;
        }

        public Category AddCategory(Category n)
        {

            _context.Categories.Add(
                new Entities.Category
                {
                    Subject = n.Subject
                }
            );
            _context.SaveChanges();
            return n;
        }


        public Inventory DeleteInventory(Inventory n)
        {
            _context.Inventories.Remove(
                new Entities.Inventory
                {
                    Id = n.Id,
                    Name = n.Name,
                    Price = n.Price,
                    Stock = n.Stock,
                    CategoryId = n.CategoryId,
                    Description = n.Description
                });
            _context.SaveChanges();
            return n;
        }
      

        public Order DeleteOrder(Order n)
        {
            _context.Orders.Remove(
                new Entities.Order
                {
                    Id = n.Id,
                    UserId = n.UserId,
                    Total = n.Total,
                    IsCompleted = n.IsCompleted
                });
            _context.SaveChanges();
            return n;
        }

        public Product DeleteProduct(Product n)
        {

            Entities.Product pro = new Entities.Product
                {
                   Id = n.Id,
                    Name = n.Name,
                    Price = n.Price,
                    Quantity = n.Quantity,
                    OrderId = n.OrderId,
                    InventoryId = n.InventoryId
                };
            _context.Products.Remove(pro);
            _context.SaveChanges();
            return n;
        }

        public Review DeleteReview(Review n)
        {
            _context.Reviews.Remove(
                new Entities.Review
                {
                    Id = n.Id,
                    InventoryId = n.InventoryId,
                    UserId = n.UserId,
                    Score = n.Score,
                    Message = n.Message
                });
            _context.SaveChanges();
            return n;
        }
        public User DeleteUser(User n)
        {
            _context.Users.Remove(
                new Entities.User
                {
                    Id = n.Id,
                    FullName = n.FullName,
                    Pass = n.Pass,
                    Email = n.Email,
                    DateJoined = n.DateJoined,
                    IsAdmin = n.IsAdmin
                });
            _context.SaveChanges();
            return n;
        }
        public Category DeleteCategory(Category n)
        {
            _context.Categories.Remove(
                new Entities.Category
                {
                    Id = n.Id,
                    Subject = n.Subject
                });
            _context.SaveChanges();
            return n;
        }


        public Inventory GetInventoryById(int id)
        {

            var rest = _context.Inventories.FirstOrDefault(r => r.Id == id);
            Inventory newRest = new Inventory(rest.Id, rest.Name, rest.Price, rest.Stock, rest.CategoryId, rest.Description);
            return newRest;
           

        }
        public List<Order> GetOrderById(int id)
        {
            List<Order> list = new List<Order>();
            var orders = _context.Orders.Where(r => r.UserId == id).ToList();
            if(orders == null)
            {
                AddOrder(id);
            }
            orders = _context.Orders.Where(r => r.UserId == id).ToList();
            foreach (var order in orders)
            {
                var products = _context.Products.Where(x => x.OrderId == order.Id);

                order.Total = 0;


                foreach(var item in products)
                {
                    order.Total += Convert.ToDecimal(item.Price) * item.Quantity;
                }

            }
            foreach(var k in orders)
            {
                list.Add(new Order
                {
                    Id = k.Id,
                    UserId = k.UserId,
                    Total = k.Total,
                    IsCompleted = k.IsCompleted,
                });
            }

            return list;

        }
        public List<Product> GetProductsById(int id)
        {

            var rest = _context.Products.Where(r => r.Id == id);
            List<Product> newRest = new List<Product>();
            foreach (var k in rest)
            {
                newRest.Add(new Product(k.Id, k.Name, k.Price, k.Quantity, k.OrderId, k.InventoryId));
               
            }
            return newRest;
        }

        public User GetUserById(int id)
        {

            var user = _context.Users.FirstOrDefault(r => r.Id == id);
            User newUser = new User(user.Id, user.FullName, user.Pass, user.Email, user.DateJoined, user.IsAdmin);
            return newUser;

        }


        public void UpdateInventory(Inventory r)
        {
            var Original = GetInventoryById(r.Id);
            Original.Name = r.Name;
            Original.Price = r.Price;
            Original.Stock = r.Stock;
            Original.CategoryId = r.CategoryId;
            Original.Description = r.Description;
            _context.SaveChanges();

        }

        public void UpdateOrder(Order p)
        {
            var Original = GetOrderById(p.UserId);
            var newOriginal = Original.FirstOrDefault(x => x.IsCompleted == 0);
            newOriginal.UserId = p.UserId;
            newOriginal.Total = p.Total;
            newOriginal.IsCompleted = p.IsCompleted;
            _context.SaveChanges();

        }
        public Product GetProductById(int id)
        {
            var rest = _context.Products.FirstOrDefault(r => r.Id == id);
            Product k = new Product
            {
                Id = rest.Id,
                Name = rest.Name,
                Price = rest.Price,
                InventoryId = rest.InventoryId,
                OrderId = rest.OrderId,
                Quantity = rest.Quantity

            };
            return k;
        }
        public void UpdateProduct(Product p)
        {
            var Original = GetProductById(p.Id);

            Original.Name = p.Name;
            Original.Price = p.Price;
            Original.Quantity = p.Quantity;
            Original.OrderId = p.OrderId;
            Original.InventoryId = p.InventoryId;
   
          _context.SaveChanges();

        }


        public User GetUserByEmail(string mail)
        {
            var search = _context.Users.FirstOrDefault(u => u.Email == mail);
            if (search != null)
            {
                User newUser = new User(search.Id, search.FullName, search.Pass, search.Email, search.DateJoined, search.IsAdmin);
                return newUser;
            } else
            {
                return null;
            }

        }

        public void AddProductToOrder(Order order, Product x)
        {
            
        }
        public bool CheckUserCredentials(User user, User attempt)
        {
            if(user.Email == attempt.Email && user.Pass == attempt.Pass)
            {
                return true;
            }
                return false;
            

        }

    };

}

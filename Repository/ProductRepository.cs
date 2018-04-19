using System;
using testMVC.Interfaces;
using testMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace testMVC.Repository
{
    public class ProductRepository : IProductRepository
    {
        private ApplicationDbContext _dbContext;
        public ProductRepository(){
            _dbContext = new ApplicationDbContext();
        }

        public  static List<Product> products = new List<Product>{
            new Product {Name = "Sock", Price = 1, Category = "Clothing"},
            new Product {Name = "Shirt", Price = 3, Category = "Clothing"} 
        };

        public List<Product> Products()
        {
            return products;
        }

        public void InsertProducts()
        {
           
            _dbContext.Products.Add(new Product {Name = "Shirt", Price = 3, Category = "Clothing"} );
            _dbContext.SaveChanges();
            
        }

        public List<Product> GetProducts(string category = "clothing")
        {
            return _dbContext.Products.Where(prod => prod.Category == category).ToList();
        }
    }
}
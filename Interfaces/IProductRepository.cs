using testMVC.Models;
using System.Collections.Generic;

namespace testMVC.Interfaces
{
    public interface IProductRepository
    {
         List<Product> Products();
         void InsertProducts();

         List<Product> GetProducts(string category);
    }
}
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;
namespace WebApplication1.Models.Repositories
{
    public class ProductRepository : IProductStore<Product>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void ADD(Product Model)
        {
            db.products.Add(Model);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.products.Remove(Find(id));
            db.SaveChanges();
        }

        public Product Find(int? id)
        {
            return db.products.FirstOrDefault(p=>p.ID==id);
        }

        public List<Product> List()
        {
            return db.products.ToList();
        }

        public void Update(int id, Product newProduct)
        {
            var product = Find(id);
            product.Name =newProduct.Name;
            product.Price = newProduct.Price;
            product.picture= newProduct.picture;
            product.Quntaty = newProduct.Quntaty;
            product.description= newProduct.description;
           // product.CatID = newProduct.CatID;
            db.SaveChanges();
        }
    }
}
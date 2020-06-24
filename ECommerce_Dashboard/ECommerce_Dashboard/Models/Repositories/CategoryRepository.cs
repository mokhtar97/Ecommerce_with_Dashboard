using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Repositories
{
    public class CategoryRepository : IProductStore<Category>
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public void ADD(Category Model)
        {
            db.Categories.Add(Model);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            db.Categories.Remove(Find(id));
            db.SaveChanges();
        }

        public Category Find(int? id)
        {
            return db.Categories.FirstOrDefault(c => c.ID == id);
        }

        public List<Category> List()
        {
            return db.Categories.ToList();
        }

        public void Update(int id, Category newCategory)
        {
            var category = Find(id);
            category.Name = newCategory.Name;
            db.SaveChanges();
        }
    }
}
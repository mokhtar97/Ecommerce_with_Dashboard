using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.Repositories;

namespace ECommerce_Dashboard.Controllers
{
    [Authorize(Roles = "Admin")]
    public class CategoriesController : Controller
    {
        private readonly IProductStore<Category> categoryDb;

        public CategoriesController(IProductStore<Category> CategoryDb)
        {
            categoryDb = CategoryDb;
        }
        // GET: Categories

        public ActionResult Index()
        {
            return PartialView(categoryDb.List());
        }

        // GET: Categories/Details/5
        public ActionResult Details(int id)
        {
            var category = categoryDb.Find(id);
            return PartialView(category);
        }

        // GET: Categories/Create
        public ActionResult Create()
        {
            return PartialView();
        }

        // POST: Categories/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Create([Bind("ID,Name")] Category category)
        {
            try
            {
                categoryDb.ADD(category);

                return RedirectToAction("Index");
            }
            catch
            {
                return PartialView(category);
            }
        }

        // GET: Categories/Edit/5
        public ActionResult Edit(int id)
        {
            var category = categoryDb.Find(id);
            return PartialView(category);
        }

        // POST: Categories/Edit/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] Category category)
        {
            if (id != category.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    categoryDb.Update(id, category);

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            
            return PartialView(category);
        }

        // GET: Categories/Delete/5
        public ActionResult Delete(int id)
        {
            var category = categoryDb.Find(id);
            return PartialView(category);
        }

        // POST: Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            
                
                categoryDb.Delete(id);
                return RedirectToAction("Index");
            
        }

        private bool CategoryExists(int id)
        {
            return categoryDb.List().Any(e => e.ID == id);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ECommerce_Dashboard.Hubs;
using ECommerce_Dashboard.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using WebApplication1.Models.Repositories;
using PagedList;



namespace ECommerce_Dashboard.Controllers
{
    [Authorize]
    public class ProductsController : Controller
    {
        private readonly IProductStore<Product> productDb;
        private readonly IProductStore<Category> categoryDb;
        private readonly IWebHostEnvironment webHostEnvironment;
        public ProductsController(IProductStore<Product> ProductDb,IProductStore<Category> CategoryDb, IWebHostEnvironment hostEnvironment)
        {
            productDb = ProductDb;
            categoryDb = CategoryDb;


            webHostEnvironment = hostEnvironment;
        }

        // GET: Products
        public IActionResult Index(int? pageNumber, string searchString)
        {
 
            ViewData["CatID"] = categoryDb.List();
            ViewData["CurrentFilter"] = searchString;

            var products = productDb.List();
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(p => p.Name.Contains(searchString)).ToList();
            }
            return PartialView(products.ToPagedList(pageNumber ?? 1,5));
        }

        // GET: Products/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productDb.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return PartialView(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewData["CatID"] = new SelectList(categoryDb.List(), "ID", "Name");
            return PartialView();
        }


        [HttpPost]
        public IActionResult Create(productVM model)
        {
            Product product;
            if (ModelState.IsValid)
            {
                string uniqueFileName = UploadedFile(model);

                product = new Product
                {
                    Name = model.Name,
                    Price = model.Price,
                    Quntaty = model.Quntaty,
                    CatID = model.CatID,
                    description = model.description,
                    picture = uniqueFileName,
                };

                productDb.ADD(product);
                ViewBag.CatID = new SelectList(categoryDb.List(), "ID", "Name", product.CatID);
              
                return RedirectToAction("Index");
            }

            return PartialView();
        }


        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        /////[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID,Name,Quntaty,Price,ImgID,description,CatID")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        productDb.ADD(product);

        //        return RedirectToAction("Index");
        //    }
        //    ViewData["CatID"] = new SelectList(categoryDb.List(), "ID", "Name", product.CatID);
        //    return PartialView(product);
        //}

        // GET: Products/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productDb.Find(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewBag.CatID = new SelectList(categoryDb.List(), "ID", "Name", product.CatID);
            ViewBag.pic = product.picture;
            productVM prd = new productVM();
            prd.Name = product.Name;
            prd.Price = product.Price;
            prd.Quntaty = product.Quntaty;
            prd.description = product.description;
            prd.CatID = product.CatID;
            return PartialView(prd);
        }

        // POST: Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
       // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Quntaty,Price,picture,description,CatID")] productVM product)
        {
            if (id != product.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    var prd = productDb.Find(id);
                    string uniqueFileName = UploadedFile(product);
                    if(uniqueFileName==null || uniqueFileName.Length<5)
                    {
                        prd.ID = product.ID;
                        prd.CatID = product.CatID;
                        prd.Price = product.Price;
                        prd.Quntaty = product.Quntaty;
                        prd.description = product.description;
                        prd.Name = product.Name;
                       
                    }
                    else
                    {
                        prd.ID = product.ID;
                        prd.CatID = product.CatID;
                        prd.Price = product.Price;
                        prd.Quntaty = product.Quntaty;
                        prd.description = product.description;
                        prd.Name = product.Name;
                        prd.picture = uniqueFileName;
                    }
                   
                    productDb.Update(id,prd);
                    
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ID))
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
            ViewBag.CatID = new SelectList(categoryDb.List(), "ID", "Name", product.CatID);
           
            return PartialView(product);
        }

        // GET: Products/Delete/5
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = productDb.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return PartialView(product);
        }

        // POST: Products/Delete/5
        [HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
          
            productDb.Delete(id);
           
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return productDb.List().Any(e => e.ID == id);
        }

       
        private string UploadedFile(productVM model )
        {
            string uniqueFileName = null;

            if (model.picture != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.picture.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.picture.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }



}

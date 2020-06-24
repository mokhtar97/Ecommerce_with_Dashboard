using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApplication1.Models;
using WebApplication1.Models.Repositories;

namespace WebApplication1.Controllers
{
   
    public class ProductsController : ApiController
    {
        private  ProductRepository productRepository=new ProductRepository();


        
        // GET: api/Products
        public ICollection<ProductDTO> Getproducts()
        {
            var products = productRepository.List();
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            foreach (var x in products)
            {
                productDTOs.Add(new ProductDTO { ID = x.ID, Name = x.Name, picture = x.picture, description = x.description, Price = x.Price, Quntaty = x.Quntaty, CatID = x.CatID });
            }
            return productDTOs.ToList();
        }

        // GET: api/Products/5
        [ResponseType(typeof(ProductDTO))]
        public IHttpActionResult GetProduct(int id)
        {
            Product prod= productRepository.Find(id);
            ProductDTO product = new ProductDTO
            {
                ID = prod.ID,
                Name = prod.Name,
                picture = prod.picture,
                description = prod.description,
                CatID = prod.CatID,
                Price = prod.Price,
                Quntaty = prod.Quntaty
            };

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }
       
        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != product.ID)
            {
                return BadRequest();
            }

            productRepository.Update(id, product);

            

            return StatusCode(HttpStatusCode.NoContent);
        }
        [Authorize]
        // POST: api/Products
        [ResponseType(typeof(Product))]
        public IHttpActionResult PostProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

           productRepository.ADD(product);
            

            return CreatedAtRoute("Default", new { id = product.ID }, product);
        }
        [Authorize]
        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = productRepository.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            productRepository.Delete(id);

            return Ok(product);
        }


        

    }
}
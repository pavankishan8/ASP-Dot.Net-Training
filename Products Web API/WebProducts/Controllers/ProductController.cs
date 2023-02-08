using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebProducts.Models;


namespace WebProducts.Controllers
{
    [EnableCors("*","*","*","*")]
    public class ProductController : ApiController
    {
        public List<Product> GetAllProducts()
        {
            var context = new Entities();
            return context.Products.ToList();
        }

        public Product GetProduct(string id)
        {
            var pId = int.Parse(id);
            var context = new Entities();
            return context.Products.FirstOrDefault(p => p.ProductId == pId);
        }

        [HttpPost]
        public Product AddNewProduct(Product product)
        {
            try
            {
                var context = new Entities();
                context.Products.Add(product);
                context.SaveChanges();
                return product;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPut]
        public void UpdateProduct(Product product)
        {
            var context = new Entities();
            var foundProduct = context.Products.Find(product.ProductId);
            if (foundProduct == null)
                throw new Exception("Product not found");
            foundProduct.ProductImage = product.ProductImage;
            foundProduct.ProductName = product.ProductName;
            foundProduct.Price = product.Price;
            foundProduct.Quantity = product.Quantity;
            context.SaveChanges();
        }

        [HttpDelete]
        public void DeleteProduct(string id)
        {
            var pId = int.Parse(id);
            var context = new Entities();
            var found = context.Products.Find(pId);
            context.Products.Remove(found);
            context.SaveChanges();
            
        }
    }
}

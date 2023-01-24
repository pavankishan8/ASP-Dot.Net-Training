using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductWebApplication.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; } = 1;

    }

    public static class ProductRepo
    {
        private static List<Product> _repo = new List<Product>();

        static ProductRepo()
        {
            getAll();
        }
        public static List<Product> AllProducts => _repo;

        private static void getAll()
        {
            
            _repo.Add(new Product
            {
                ProductId = 1,
                Image = @".\Images\Coffee.jpg",
                Price = 10,
                ProductName = "Coffee"
            });
            _repo.Add(new Product
            {
                ProductId = 2,
                Image = @".\Images\Tea.jpg",
                Price = 15,
                ProductName = "Tea"
            });
            _repo.Add(new Product
            {
                ProductId = 3,
                Image = @".\Images\ColdCoffee.jfif",
                Price = 49,
                ProductName = "Cold Coffee"
            });
            _repo.Add(new Product
            {
                ProductId = 4,
                Image = @".\Images\Lemon Tea.jpg",
                Price = 25,
                ProductName = "Lemon Tea"
            });
            _repo.Add(new Product
            {
                ProductId = 5,
                Image = @".\Images\Sandwich.jpg",
                Price = 49,
                ProductName = "Sandwich"
            });

            _repo.Add(new Product
            {
                ProductId = 6,
                Image = @".\Images\Maggie.jpg",
                Price = 20,
                ProductName = "Maggie"
            });

            _repo.Add(new Product
            {
                ProductId = 7,
                Image = @".\Images\Maghreb.jfif",
                Price = 30,
                ProductName = "Maghreb"
            });

            _repo.Add(new Product
            {
                ProductId = 8,
                Image = @".\Images\Matcha Tea.jfif",
                Price = 25,
                ProductName = "Matcha Tea"
            });
        }

        public static void UpdateProduct(Product product)
        {
            var found = _repo.Find((p) => p.ProductId == product.ProductId);
            found.ProductName = product.ProductName;
            found.Price = product.Price;
        }

        public static void DeleteProduct(int id)
        {
            var found = _repo.Find((p) => p.ProductId == id);
            _repo.Remove(found);
        }

        internal static void AddNewProduct(Product product) => _repo.Add(product);
    }

}


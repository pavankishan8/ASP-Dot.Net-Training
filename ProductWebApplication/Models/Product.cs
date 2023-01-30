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

            _repo.Add(new Product
            {
                ProductId = 9,
                Image = @".\Images\Blue Tea.jpg",
                Price = 45,
                ProductName = "Blue Tea"
            });

            _repo.Add(new Product
            {
                ProductId = 10,
                Image = @".\Images\Bubble Tea.png",
                Price = 145,
                ProductName = "Bubble Tea"
            });

            _repo.Add(new Product
            {
                ProductId = 11,
                Image = @".\Images\Iced Coffee.jpg",
                Price = 169,
                ProductName = "Iced Coffee"
            });

            _repo.Add(new Product
            {
                ProductId = 12,
                Image = @".\Images\Zavarka.jpg",
                Price = 49,
                ProductName = "Zavarka"
            });

            _repo.Add(new Product
            {
                ProductId = 13,
                Image = @".\Images\Bajji.jpg",
                Price = 49,
                ProductName = "Bajji"
            });

            _repo.Add(new Product
            {
                ProductId = 14,
                Image = @".\Images\Pav Bhaji.jpg",
                Price = 120,
                ProductName = "Pav Bhaji"
            });

            _repo.Add(new Product
            {
                ProductId = 15,
                Image = @".\Images\Chole Bhature.jpg",
                Price = 110,
                ProductName = "Chole Bhature"
            });

            _repo.Add(new Product
            {
                ProductId = 16,
                Image = @".\Images\Nachos.jpg",
                Price = 160,
                ProductName = "Nachos"
            });

            _repo.Add(new Product
            {
                ProductId = 17,
                Image = @".\Images\Kulfi.jpg",
                Price = 80,
                ProductName = "Kulfi"
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


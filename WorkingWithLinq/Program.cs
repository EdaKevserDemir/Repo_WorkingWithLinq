using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkingWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategotyName="ComputerCategory"},
                new Category{CategoryId=2,CategotyName="Phone" }
            };

            List<Product> products = new List<Product>
            {
               new Product { ProductId = 1, CategoryId = 1, ProductName = "Acer Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 1000, UnitsInStock=5 },
               new Product { ProductId = 2, CategoryId = 1, ProductName = "Asus Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 8000, UnitsInStock=3},
               new Product { ProductId = 3, CategoryId = 2, ProductName = "Hp Laptop", QuantityPerUnit = "32 GB RAM", UnitPrice = 6000, UnitsInStock=2 },
               new Product { ProductId = 4, CategoryId = 2, ProductName = "Samsung Phone", QuantityPerUnit = "4 GB RAM", UnitPrice = 5000, UnitsInStock=15 },
               new Product { ProductId = 5, CategoryId = 2, ProductName = "Apple Phone", QuantityPerUnit = "4 GB RAM", UnitPrice = 8000, UnitsInStock=0 },


            };


            foreach (var product in GetProductsLinq(products))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.ReadLine();

        }
        static List<Product> GetProductsLinq(List<Product> products)
        {
            return products.Where(p => p.CategoryId == 2 && p.UnitPrice<8000).ToList();
        }




        // Linq olmasaydı yazılacak metot

        //static List<Product> GetProducts(List<Product> products)
        //{
        //    List<Product> filteredProduct = new List<Product>();

        //    Console.WriteLine("algoritmik------------------");
        //    foreach (var product in products)
        //    {
        //        if (product.UnitPrice > 5000 && product.UnitsInStock > 3)
        //        {
        //            filteredProduct.Add(product);
        //        }
        //    }
        //    return filteredProduct;



    }
}


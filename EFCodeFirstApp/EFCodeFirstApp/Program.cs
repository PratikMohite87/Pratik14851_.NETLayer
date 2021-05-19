using System;
using System.Linq;

namespace EFCodeFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //SeedDataBase();
            UpdateTable();
            Console.WriteLine("Finish");
        }

        private static void SeedDataBase()
        {
            EFCodeFirstDbContext eFCodeFirstDbContext = new EFCodeFirstDbContext();

            Category category1 = new Category()
            {
                CategoryId = 1,
                CategoryName = "Electronics"
            };

            eFCodeFirstDbContext.Categories.Add(category1);     // only in-memorychange happens here
            eFCodeFirstDbContext.SaveChanges();     // changes gets reflected in db


            Product product1 = new Product()
            {
                ProductId = 101,
                ProductName = "Laptop",
                ProductCategory = category1,
                ProductPrice = 100000
            };

            eFCodeFirstDbContext.Products.Add(product1);
            eFCodeFirstDbContext.SaveChanges();
        }

        private static void UpdateTable()
        {
            EFCodeFirstDbContext eFCodeFirstDbContext = new EFCodeFirstDbContext();

            Product product = eFCodeFirstDbContext.Products.SingleOrDefault(p => p.ProductId == 101);

            if (product != null)
            {
                product.ProductName = "Mobile";
                product.ProductPrice = 30000;

                eFCodeFirstDbContext.SaveChanges();
                Console.WriteLine("Updated");
            }
            else
                Console.WriteLine("Not Found");

        }
    }
}

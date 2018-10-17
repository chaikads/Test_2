using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    public class ContextInitializer : DropCreateDatabaseAlways<UserContext>
    {
        public void Seed(UserContext db)
        {
            // создание и добавление моделей
            //Product pr1 = new Product {ProductId = 1, ProductName = "TV"};
            //Product pr2 = new Product {ProductId = 2, ProductName = "Table"};
            //Product pr3 = new Product {ProductId = 3, ProductName = "Book"};
            //db.Products.AddRange(new List<Product>
            //{
            //    pr1,
            //    pr2,
            //    pr3
            //});
            //db.SaveChanges();

            //Category c1 = new Category {CategoryId = 1, CategoryName = "C1"};
            //c1.Products.Add(pr2);
            //c1.Products.Add(pr3);
            //Category c2 = new Category {CategoryId = 2, CategoryName = "C2"};
            //c2.Products.Add(pr1);
            //db.Categories.Add(c1);
            //db.Categories.Add(c2);

            Product pr4 = new Product { ProductId = 4, ProductName = "Chair" };
            Product pr5 = new Product { ProductId = 5, ProductName = "Lamp" };
            db.Products.AddRange(new List<Product>
            {
                pr4,
                pr5
                
            });
            db.SaveChanges();

            Category c1 = new Category { CategoryId = 1, CategoryName = "C1" };
            
            Category c2 = new Category { CategoryId = 2, CategoryName = "C2" };
           

            pr5.Categories.Add(c1);
            pr5.Categories.Add(c2);
            db.SaveChanges();
        }
    }
}

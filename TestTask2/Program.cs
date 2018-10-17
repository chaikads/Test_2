using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask2
{
    class Program: ContextInitializer
    {
        static void Main(string[] args)
        {

            using (UserContext db = new UserContext())
            {
                var ci = new ContextInitializer();
                ci.Seed(db);
                Console.WriteLine("Объекты успешно сохранены");

                // получаем объекты из бд и выводим на консоль
                var users = db.Products;
                Console.WriteLine("Список объектов:");
                foreach (var u in users)
                {
                    Console.WriteLine("{0}.{1} - {2}", u.Categories, u.ProductId, u.ProductName);
                }
            }
            Console.Read();
        }
    }
}

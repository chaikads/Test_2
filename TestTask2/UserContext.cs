using System.Data.Entity;


namespace TestTask2
{
    public class UserContext : DbContext
    {
        //static UserContext()
        //{
        //    Database.SetInitializer<UserContext>(new ContextInitializer());
        //}

        public UserContext(): base("DbConnection") { }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}

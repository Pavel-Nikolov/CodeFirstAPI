using BusinessLayer;
using System;
using System.Data.Entity;

namespace DataAccessLayer
{
    public class Context : DbContext
    {
        public Context() 
            : base(@"Server=DESKTOP-E57GMEU\SQLEXPRESS;Database=CodeFirstAPI;Trusted_Connection=True;")
            //: base(@"Server=(localdb)\v11.0;Integrated Security=true;")
        {

        }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<User> Users { get; set; }

    }
}

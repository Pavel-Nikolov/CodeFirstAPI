using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer
{
    public static class FactoryManager
    {
        private static Context context;

        public static void InitializeContext()
        {
            context = new Context();
        }

        public static BrandManager CreateBrandManager()
        {
            return new BrandManager(context);
        }

        public static ProductManager CreateProductManager()
        {
            return new ProductManager(context);
        }

        public static UserManager CreateUserManager()
        {
            return new UserManager(context);
        }
    }
}

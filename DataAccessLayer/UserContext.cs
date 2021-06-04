using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace DataAccessLayer
{
    public class UserContext : IDBContext<User, int>
    {
        private Context context;

        public UserContext(Context context)
        {
            this.context = context;
        }

        public void Create(User item)
        {
            ICollection<Product> products = new List<Product>(item.Products.Count);

            foreach (Product product in item.Products)
            {
                Product productFromDB = context.Products.Find(product.Barcode);

                if (productFromDB != null)
                {
                    products.Add(productFromDB);
                }
                else
                {
                    products.Add(product);
                }
            }

            item.Products = products;
            context.Users.Add(item);
            context.SaveChanges();
        }

        public User Read(int key)
        {
            User user = context.Users.Find(key);

            if (user == null)
            {
                throw new ArgumentException("There is no user with that key in the database!");
            }

            return user;
        }

        public ICollection<User> ReadAll()
        {
            ICollection<User> users = context.Users.ToList();

            if (users == null)
            {
                throw new ArgumentException("There are no users in the database!");
            }

            return users;
        }

        public void Update(User item)
        {
            User userFromDB = context.Users.Find(item.ID);

            if (userFromDB != null)
            {
                List<Product> productsForUser = new List<Product>(item.Products.Count);

                foreach (Product product in item.Products)
                {
                    Product productFromDB = context.Products.Find(product.Barcode);
                    if (productFromDB != null)
                    {
                        //context.Entry(productFromDB).CurrentValues.SetValues(product);
                        productsForUser.Add(productFromDB);
                    }
                    else
                    {
                        productsForUser.Add(product);
                    }
                }

                userFromDB.Products = productsForUser;

                context.Entry(userFromDB).CurrentValues.SetValues(item);
                context.SaveChanges();
            }
            else
            {
                Create(item);
            }
        }

        public void Delete(int key)
        {
            User user = context.Users.Find(key);
            context.Users.Remove(user);
            context.SaveChanges();

        }

    }
}

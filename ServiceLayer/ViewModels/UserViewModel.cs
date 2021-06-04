using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceLayer.ViewModels
{
    public class UserViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int? Age { get; set; }

        public virtual ICollection<ProductViewModel> Products { get; set; }

        public static User GetModel(UserViewModel uvm)
        {
            return new User
            {
                ID = uvm.ID,
                Age = uvm.Age,
                Name = uvm.Name,

                Products = uvm.Products.Select(x => ProductViewModel.GetModel(x)).ToList()
            };
        }

        public static ICollection<User> GetModels(ICollection<UserViewModel> uvmList)
        {
            ICollection<User> users = new List<User>(uvmList.Count);

            foreach (var uvm in uvmList)
            {
                User user = GetModel(uvm);
                users.Add(user);
            }

            return users;
        }

        public static UserViewModel GetViewModel(User user)
        {
            return new UserViewModel
            {
                ID = user.ID,
                Age = user.Age,
                Name = user.Name,

                Products = user.Products.Select(x => ProductViewModel.GetViewModel(x)).ToList()
            };
        }

        public static ICollection<UserViewModel> GetViewModels(ICollection<User> users)
        {
            ICollection<UserViewModel> userViewModels = new List<UserViewModel>(users.Count);

            foreach (var user in users)
            {
                UserViewModel uvm = GetViewModel(user);
                userViewModels.Add(uvm);
            }

            return userViewModels;
        }


    }
}

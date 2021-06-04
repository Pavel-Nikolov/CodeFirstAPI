using BusinessLayer;
using DataAccessLayer;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ServiceLayer
{
    public class UserManager
    {
        private UserContext userContext;

        public UserManager(Context context)
        {
            userContext = new UserContext(context);
        }

        public void Create(UserViewModel item)
        {
            User user = UserViewModel.GetModel(item);
            userContext.Create(user);
        }

        public UserViewModel Read(int key)
        {
            return UserViewModel.GetViewModel(userContext.Read(key));
        }

        public ICollection<UserViewModel> ReadAll()
        {
            return userContext.ReadAll().Select(x=>UserViewModel.GetViewModel(x)).ToList();
        }

        public void Update(UserViewModel item)
        {
            User user = UserViewModel.GetModel(item);
            userContext.Update(user);
        }

        public void Delete(int key)
        {
            userContext.Delete(key);
        }

    }
}

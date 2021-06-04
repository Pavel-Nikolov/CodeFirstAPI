using BusinessLayer;
using DataAccessLayer;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class BrandManager
    {
        private BrandContext brandContext;

        public BrandManager(Context context)
        {
            brandContext = new BrandContext(context);
        }

        public void Create(BrandViewModel item)
        {
            Brand brand = BrandViewModel.GetModel(item);
            brandContext.Create(brand);
        }

        public BrandViewModel Read(int key)
        {
            Brand brand = brandContext.Read(key);
            return BrandViewModel.GetViewModel(brand);
        }

        public ICollection<BrandViewModel> ReadAll()
        {
            ICollection<Brand> brands = brandContext.ReadAll();
            return BrandViewModel.GetViewModels(brands);
        }

        public void Update(BrandViewModel item)
        {
            Brand brand = BrandViewModel.GetModel(item);
            brandContext.Update(brand);
        }

        public void Delete(int key)
        {
            brandContext.Delete(key);
        }

    }
}

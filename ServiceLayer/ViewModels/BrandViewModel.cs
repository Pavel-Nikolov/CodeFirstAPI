using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.ViewModels
{
    public class BrandViewModel
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<ProductViewModel> Products { get; set; }

        public static Brand GetModel(BrandViewModel bvm)
        {
            return new Brand
            {
                ID = bvm.ID,
                Name = bvm.Name
            };
        }

        public static ICollection<Brand> GetModels(ICollection<BrandViewModel> bvmList)
        {
            ICollection<Brand> brands = new List<Brand>(bvmList.Count);

            foreach (var bvm in bvmList)
            {
                Brand brand = GetModel(bvm);
                brands.Add(brand);
            }

            return brands;
        }

        public static BrandViewModel GetViewModel(Brand brand)
        {
            return new BrandViewModel
            {
                ID = brand.ID,
                Name = brand.Name
            };
        }

        public static ICollection<BrandViewModel> GetViewModels(ICollection<Brand> brands)
        {
            ICollection<BrandViewModel> brandViewModels = new List<BrandViewModel>(brands.Count);

            foreach (var brand in brands)
            {
                BrandViewModel bvm = GetViewModel(brand);
                brandViewModels.Add(bvm);
            }

            return brandViewModels;
        }

    }
}

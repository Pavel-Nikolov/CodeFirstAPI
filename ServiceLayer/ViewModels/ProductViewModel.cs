using BusinessLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.ViewModels
{
    public class ProductViewModel
    {
        public string Barcode { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

        public virtual BrandViewModel Brand { get; set; }

        public virtual ICollection<UserViewModel> Users { get; set; }

        public static Product GetModel(ProductViewModel pvm)
        {
            return pvm.Brand != null ? new Product
            {
                Barcode = pvm.Barcode,
                Name = pvm.Name,
                Price = pvm.Price,
                Quantity = pvm.Quantity,



                Brand = new Brand()
                {
                    ID = pvm.Brand.ID,
                    Name = pvm.Brand.Name
                }
            }
            : new Product()
            {
                Barcode = pvm.Barcode,
                Name = pvm.Name,
                Price = pvm.Price,
                Quantity = pvm.Quantity,
            };
        }

        public static ICollection<Product> GetModels(ICollection<ProductViewModel> pvmList)
        {
            ICollection<Product> products = new List<Product>(pvmList.Count);

            foreach (var pvm in pvmList)
            {
                Product product = GetModel(pvm);
                products.Add(product);
            }

            return products;
        }

        public static ProductViewModel GetViewModel(Product product)
        {
            return new ProductViewModel
            {
                Barcode = product.Barcode,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,

                Brand = BrandViewModel.GetViewModel(product.Brand)
            };
        }

        public static ICollection<ProductViewModel> GetViewModels(ICollection<Product> products)
        {
            ICollection<ProductViewModel> productViewModels = new List<ProductViewModel>(products.Count);

            foreach (var product in products)
            {
                ProductViewModel pvm = GetViewModel(product);
                productViewModels.Add(pvm);
            }

            return productViewModels;
        }

    }
}

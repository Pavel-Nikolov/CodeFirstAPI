using BusinessLayer;
using DataAccessLayer;
using ServiceLayer.ViewModels;
using System;
using System.Collections.Generic;

namespace ServiceLayer
{
    public class ProductManager
    {
        private ProductContext productContext;

        public ProductManager(Context context)
        {
            productContext = new ProductContext(context);
        }

        public void Create(ProductViewModel item)
        {
            Product product = ProductViewModel.GetModel(item);
            product.Brand = BrandViewModel.GetModel(item.Brand);
            productContext.Create(product);
        }

        public ProductViewModel Read(string key)
        {
            Product product = productContext.Read(key);
            ProductViewModel productViewModel = ProductViewModel.GetViewModel(product);
            productViewModel.Brand = BrandViewModel.GetViewModel(product.Brand);

            return productViewModel;
        }

        public ICollection<ProductViewModel> ReadAll()
        {
            ICollection<Product> products = productContext.ReadAll();
            ICollection<ProductViewModel> productViewModels = new List<ProductViewModel>(products.Count);

            foreach (var item in products)
            {
                ProductViewModel productViewModel = ProductViewModel.GetViewModel(item);
                productViewModel.Brand = BrandViewModel.GetViewModel(item.Brand);

                productViewModels.Add(productViewModel);
            }

            return productViewModels;
        }

        public void Update(ProductViewModel item)
        {
            Product product = ProductViewModel.GetModel(item);
            product.Brand = BrandViewModel.GetModel(item.Brand);

            productContext.Update(product);
        }

        public void Delete(string key)
        {
            productContext.Delete(key);
        }

    }
}

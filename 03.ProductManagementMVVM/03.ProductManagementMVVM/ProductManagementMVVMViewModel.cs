using System;
using System.Collections.Generic;
using System.Text;

namespace _03.ProductManagementMVVM
{
    class ProductManagementMVVMViewModel : Notifier
    {
        private ProductsFactory productsFactory;

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged("SearchText");
                OnSearchTextChanged();
            }
        }

        private IEnumerable<Product> productsList;
        public IEnumerable<Product> ProductsList
        {
            get { return productsList; }
            set
            {
                productsList = value;
                OnPropertyChanged("ProductsList");
            }
        }

        public ProductManagementMVVMViewModel()
        {
            productsFactory = new ProductsFactory();
            ProductsList = productsFactory.GetAllProducts();
        }

        private void OnSearchTextChanged()
        {
            ProductsList = productsFactory.FindProducts(SearchText);
        }
    }
}

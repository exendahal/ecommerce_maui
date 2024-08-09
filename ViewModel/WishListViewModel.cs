﻿using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class WishListViewModel: BaseViewModel
    {
        private ObservableCollection<ProductModel> _Products = [];
        public ObservableCollection<ProductModel> Products
        {
            get => _Products;
            set => SetProperty(ref _Products, value);
        }
        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }

        public ICommand SelectProductCommand { get; }
        public WishListViewModel()
        {
            SelectProductCommand = new Command<ProductModel>(SelectProduct);
            _ = InitializeAsync();
        }

        private async void SelectProduct(ProductModel model)
        {
            if (model.IsAvailable)
            {
                await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetailsView());
            }
        }

        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }
      
        async Task PopulateDataAsync()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API
            Products.Clear();
            Products.Add(new ProductModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = 755, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png",IsAvailable = true});
            Products.Add(new ProductModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = 450, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            Products.Add(new ProductModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = 900, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            Products.Add(new ProductModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = 1200, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });
            Products.Add(new ProductModel() { Name = "Smart Bluetooth Speaker", BrandName = "Bang and Olufsen", Price = 90, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png", IsAvailable = true });
            Products.Add(new ProductModel() { Name = "B&o Desk Lamp", BrandName = "Bang and Olufsen", Price = 450, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image7.png" });
            Products.Add(new ProductModel() { Name = "BeoPlay Stand Speaker", BrandName = "Bang and Olufse", Price = 3000, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image8.png" });
            Products.Add(new ProductModel() { Name = "Airpods", BrandName = "B&o Phone Case", Price = 30, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image9.png" });
            IsLoaded = true;
        }

    }
}

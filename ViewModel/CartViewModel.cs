using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class CartViewModel : BaseViewModel
    {
        private ObservableCollection<ProductListModel> _Products = [];
        public ObservableCollection<ProductListModel> Products
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
        private double _SubTotal = 0;
        public double SubTotal
        {
            get => _SubTotal;
            set => SetProperty(ref _SubTotal, value);
        }

        public ICommand DeleteCommand { get; }
        public ICommand FavoriteCommand { get; }
        public ICommand QtyChangeCommand { get; }
        public ICommand CheckoutCommand { get; }
        public CartViewModel()
        {           
            DeleteCommand = new Command<ProductListModel>(DeleteProduct);
            FavoriteCommand = new Command<ProductListModel>(FavoriteProduct);
            QtyChangeCommand = new Command<ProductListModel>(ChangeProductQty);
            CheckoutCommand = new Command(Checkout);
            _ = InitializeAsync();
        }      

        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }
        async Task PopulateDataAsync()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API
            Products.Add(new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Qty = 1, Price = 755, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            Products.Add(new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Qty = 1, Price = 450, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            Products.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Qty = 1, Price = 900, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            Products.Add(new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = 1200, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });
            Products.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Bang and Olufsen", Qty = 1, Price = 90, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            Products.Add(new ProductListModel() { Name = "B&o Desk Lamp", BrandName = "Bang and Olufsen", Qty = 1, Price = 450, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image7.png" });
            Products.Add(new ProductListModel() { Name = "BeoPlay Stand Speaker", BrandName = "Bang and Olufse", Qty = 1, Price = 3000, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image8.png" });
            Products.Add(new ProductListModel() { Name = "Airpods", BrandName = "B&o Phone Case", Qty = 1, Price = 30, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image9.png" });
            SubTotal = Products.Sum(item => (item.Qty * item.Price));
            IsLoaded = true;
        }
        private async void DeleteProduct(ProductListModel product)
        {
            
        }
        private async void FavoriteProduct(ProductListModel product)
        {

        }
        private void ChangeProductQty(ProductListModel product)
        {
            SubTotal = Products.Sum(item => (item.Qty * item.Price));
        }
        private async void Checkout()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new CartCalculation(Products));
        }
    }
}

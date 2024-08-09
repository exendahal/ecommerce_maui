using Camera.MAUI.ZXingHelper;
using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        private ObservableCollection<CategoyModel> _Categories = [];
        public ObservableCollection<CategoyModel> Categories
        {
            get => _Categories;
            set => SetProperty(ref _Categories, value);

        }

        private ObservableCollection<ProductModel> _BestSellingProducts = [];
        public ObservableCollection<ProductModel> BestSellingProducts
        {
            get => _BestSellingProducts;
            set => SetProperty(ref _BestSellingProducts, value);
        }

        private ObservableCollection<BrandModels> _FeaturedBrands = [];
        public ObservableCollection<BrandModels> FeaturedBrands
        {
            get => _FeaturedBrands;
            set => SetProperty(ref _FeaturedBrands, value);
        }

        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public ICommand SelectProductCommand { get; }
        public ICommand BrandTapCommand { get; }
        public ICommand RecommendedTapCommand { get; }
        public ICommand CategoryTapCommand { get; }
        public ICommand OpenCameraCommand { get; }
        public HomePageViewModel()
        {
            SelectProductCommand = new Command<BrandModels>(SelectProduct);
            RecommendedTapCommand = new Command<object>(SelectRecommend);
            CategoryTapCommand = new Command<CategoyModel>(SelectCategory);
            BrandTapCommand = new Command<ProductModel>(SelectBrand);
            OpenCameraCommand = new Command(OpenCamera);
            _ = InitializeAsync();
        }
        private async Task InitializeAsync()
        {            
            await PopulateDataAsync(); 
        }
        async Task PopulateDataAsync()
        {
            // Delay added to display loading, remove during api call
            await Task.Delay(500);
            //TODO: Remove Delay here and call API
            Categories.Add(new CategoyModel() { CategoryID = 1, CategoryName = "Men", Icon = "\ufb22" });
            Categories.Add(new CategoyModel() { CategoryID = 2, CategoryName = "Women", Icon = "\ufb23" });
            Categories.Add(new CategoyModel() { CategoryID = 2, CategoryName = "Devices", Icon = "\uf322" });
            Categories.Add(new CategoyModel() { CategoryID = 2, CategoryName = "Gadgets", Icon = "\uf2cb" });
            Categories.Add(new CategoyModel() { CategoryID = 2, CategoryName = "Games", Icon = "\uf5ba" });

            FeaturedBrands.Add(new BrandModels() { BrandName = "B&o", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png" });
            FeaturedBrands.Add(new BrandModels() { BrandName = "Beats", Details = "1124 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/beats.png" });
            FeaturedBrands.Add(new BrandModels() { BrandName = "Apple Inc", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Apple.png" });

            BestSellingProducts.Add(new ProductModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = 755, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            BestSellingProducts.Add(new ProductModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = 450, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            BestSellingProducts.Add(new ProductModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = 900, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            BestSellingProducts.Add(new ProductModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = 1200, ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });

           

            IsLoaded = true;
        }

        private async void SelectBrand(ProductModel product)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BrandDetailView());
        }
        private async void SelectProduct(BrandModels brand)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetailsView());
        }

        private async void SelectCategory(CategoyModel category)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CategoryDetailView(category));
        }
        private async void SelectRecommend(object product)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AllProductView());
        }
        private async void OpenCamera()
        {
            var response = await App.Current.MainPage.DisplayAlert("Scan QR", "Do you want to open camera?", "Yes", "No");
            if (response)
            {
                PermissionStatus status = await Permissions.RequestAsync<Permissions.Camera>();
                if (status == PermissionStatus.Granted)
                {
                    await Application.Current.MainPage.Navigation.PushModalAsync(new ScanCameraView());
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Permission Denied", "Camera access is required but not granted. Please enable camera permissions in your device settings.", "OK");

                }

            }
        }

        private void CameraViewBarcodeDetected(object sender, BarcodeEventArgs args)
        {
           
        }

        private void CameraViewCamerasLoaded(object sender, EventArgs e)
        {
           
        }
    }
}

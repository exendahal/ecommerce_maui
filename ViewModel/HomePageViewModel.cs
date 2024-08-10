using Camera.MAUI.ZXingHelper;
using EcommerceMAUI.Constants;
using EcommerceMAUI.Helpers;
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
            SelectProductCommand = new Command<ProductModel>(SelectProduct);
            RecommendedTapCommand = new Command<object>(SelectRecommend);
            CategoryTapCommand = new Command<CategoyModel>(SelectCategory);
            BrandTapCommand = new Command<BrandModels>(SelectBrand);
            OpenCameraCommand = new Command(OpenCamera);
            _ = InitializeAsync();
        }
        private async Task InitializeAsync()
        {            
            await PopulateDataAsync(); 
        }
        async Task PopulateDataAsync()
        {            
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            var categoryResponse = await HttpHelper.GetHttpResponse(ApiUrl.CATEGORY_URL);
            var brandResponse = await HttpHelper.GetHttpResponse(ApiUrl.BRAND_URL);
            var productResponse = await HttpHelper.GetHttpResponse(ApiUrl.PRODUCT_URL);
            
            if (!string.IsNullOrWhiteSpace(categoryResponse))
            {
                Categories = new ObservableCollection<CategoyModel>(JsonSerializer.Deserialize<List<CategoyModel>>(categoryResponse, options));  
            }

            if (!string.IsNullOrWhiteSpace(brandResponse))
            {
                FeaturedBrands = new ObservableCollection<BrandModels>(JsonSerializer.Deserialize<List<BrandModels>>(brandResponse, options));
            }

            if (!string.IsNullOrWhiteSpace(productResponse))
            {
                BestSellingProducts = new ObservableCollection<ProductModel>(JsonSerializer.Deserialize<List<ProductModel>>(productResponse, options));
            }

            IsLoaded = true;
        }

        private async void SelectBrand(BrandModels product)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BrandDetailView());
        }
        private async void SelectProduct(ProductModel brand)
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

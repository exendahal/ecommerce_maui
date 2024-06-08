
using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {
        private ObservableCollection<CategoriesModel> _CategoriesDataList = [];
        public ObservableCollection<CategoriesModel> CategoriesDataList
        {
            get => _CategoriesDataList;
            set => SetProperty(ref _CategoriesDataList, value);

        }

        private ObservableCollection<ProductListModel> _BestSellingDataList = [];
        public ObservableCollection<ProductListModel> BestSellingDataList
        {
            get => _BestSellingDataList;
            set => SetProperty(ref _BestSellingDataList, value);
        }

        private ObservableCollection<ProductListModel> _FeaturedBrandsDataList = [];
        public ObservableCollection<ProductListModel> FeaturedBrandsDataList
        {
            get => _FeaturedBrandsDataList;
            set => SetProperty(ref _FeaturedBrandsDataList, value);
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
        public HomePageViewModel()
        {
            SelectProductCommand = new Command<ProductListModel>(SelectProduct);
            RecommendedTapCommand = new Command<object>(SelectRecommend);
            CategoryTapCommand = new Command<CategoriesModel>(SelectCategory);
            BrandTapCommand = new Command<ProductListModel>(SelectBrand);
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
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 1, CategoryName = "Men", Icon = "\ufb22" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Women", Icon = "\ufb23" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Devices", Icon = "\uf322" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Gadgets", Icon = "\uf2cb" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID = 2, CategoryName = "Games", Icon = "\uf5ba" });

            BestSellingDataList.Add(new ProductListModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            BestSellingDataList.Add(new ProductListModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });

            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "B&o", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png" });
            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "Beats", Details = "1124 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/beats.png" });
            FeaturedBrandsDataList.Add(new ProductListModel() { BrandName = "Apple Inc", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Apple.png" });

            IsLoaded = true;
        }

        private async void SelectBrand(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new BrandDetailView());
        }
        private async void SelectProduct(ProductListModel obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetailsView());
        }

        private async void SelectCategory(CategoriesModel obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new CategoryDetailView(obj));
        }
        private async void SelectRecommend(object obj)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AllProductView());
        }
    }
}

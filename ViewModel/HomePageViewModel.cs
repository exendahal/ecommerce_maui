

using EcommerceMAUI.Model;
using System.Collections.ObjectModel;

namespace EcommerceMAUI.ViewModel
{
    public class HomePageViewModel : BaseViewModel
    {

        public ObservableCollection<CategoriesModel> _CategoriesDataList = new ObservableCollection<CategoriesModel>();
        public ObservableCollection<CategoriesModel> CategoriesDataList
        {
            get
            {
                return _CategoriesDataList;
            }
            set
            {
                _CategoriesDataList = value;
                OnPropertyChanged("CategoriesDataList");
            }
        }

        public ObservableCollection<ProductModel> _BestSellingDataList = new ObservableCollection<ProductModel>();
        public ObservableCollection<ProductModel> BestSellingDataList
        {
            get
            {
                return _BestSellingDataList;
            }
            set
            {
                _BestSellingDataList = value;
                OnPropertyChanged("BestSellingDataList");
            }
        }

        public ObservableCollection<ProductModel> _FeaturedBrandsDataList = new ObservableCollection<ProductModel>();
        public ObservableCollection<ProductModel> FeaturedBrandsDataList
        {
            get
            {
                return _FeaturedBrandsDataList;
            }
            set
            {
                _FeaturedBrandsDataList = value;
                OnPropertyChanged("FeaturedBrandsDataList");
            }
        }
        public HomePageViewModel()
        {
            PopulateData();
        }

        void PopulateData()
        {
            CategoriesDataList.Clear();
            CategoriesDataList.Add(new CategoriesModel() { CategoryID=1, CategoryName="Men", Icon= "\ufb22" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID=2, CategoryName="Women", Icon= "\ufb23" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID=2, CategoryName="Devices", Icon= "\uf322" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID=2, CategoryName="Gadgets", Icon= "\uf2cb" });
            CategoriesDataList.Add(new CategoriesModel() { CategoryID=2, CategoryName="Games", Icon= "\uf5ba" });

            BestSellingDataList.Clear();
            BestSellingDataList.Add(new ProductModel() { Name = "BeoPlay Speaker", BrandName = "Bang and Olufsen", Price = "$755",ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image1.png" });
            BestSellingDataList.Add(new ProductModel() { Name = "Leather Wristwatch", BrandName = "Tag Heuer", Price = "$450",ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image2.png" });
            BestSellingDataList.Add(new ProductModel() { Name = "Smart Bluetooth Speaker", BrandName = "Google LLC", Price = "$900",ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image3.png" });
            BestSellingDataList.Add(new ProductModel() { Name = "Smart Luggage", BrandName = "Smart Inc", Price = "$1200",ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image4.png" });

            FeaturedBrandsDataList.Clear();
            FeaturedBrandsDataList.Add(new ProductModel() { BrandName = "B&o", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png" });
            FeaturedBrandsDataList.Add(new ProductModel() { BrandName = "Beats", Details = "1124 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/beats.png" });
            FeaturedBrandsDataList.Add(new ProductModel() { BrandName = "Apple Inc", Details = "5693 Products", ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Apple.png" });
           
        }
    }
}

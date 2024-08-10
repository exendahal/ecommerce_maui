using EcommerceMAUI.Constants;
using EcommerceMAUI.Helpers;
using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class AllProductViewModel : BaseViewModel
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
        public AllProductViewModel()
        {
            SelectProductCommand = new Command<ProductModel>(SelectProduct);
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

            var productResponse = await HttpHelper.GetHttpResponse(ApiUrl.PRODUCT_URL);
            if (!string.IsNullOrWhiteSpace(productResponse))
            {
                Products = new ObservableCollection<ProductModel>(JsonSerializer.Deserialize<List<ProductModel>>(productResponse, options));
            }          
            IsLoaded = true;
        }

        private async void SelectProduct(ProductModel product)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new ProductDetailsView());
        }        
    }
}

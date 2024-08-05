using EcommerceMAUI.Model;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ProductDetailsViewModel : BaseViewModel
    {
        double lastScrollIndex;
        double currentScrollIndex;       

        private bool _IsFooterVisible = false;
        public bool IsFooterVisible
        {
            get => _IsFooterVisible;
            set => SetProperty(ref _IsFooterVisible, value);
        }

        private bool _IsFavorite = false;
        public bool IsFavorite
        {
            get => _IsFavorite;
            set
            {
                if ( _IsFavorite != value)
                {
                    _IsFavorite = value;
                    OnPropertyChanged(nameof(IsFavorite));
                    OnPropertyChanged(nameof(FavStatusColor));
                }
            }
        }
        public Color FavStatusColor
        {
            get
            {
                if (IsFavorite)
                {
                    return Color.FromArgb("#00C569");
                }
                return Color.FromArgb("#000000");
            }
        }

        private ProductDetail _ProductDetail = new();
        public ProductDetail ProductDetail
        {
            get => _ProductDetail;
            set => SetProperty(ref _ProductDetail, value);
        }

        private bool _IsLoaded;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public ICommand BackCommand { get; }
        public ICommand FavCommand { get; }
        public ICommand AddToCartCommand { get; }

        public ProductDetailsViewModel()
        {
            BackCommand = new Command<object>(GoBack);
            FavCommand = new Command<Color>(FavItem);
            AddToCartCommand = new Command(AddToCart);
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
            ProductDetail.Price = 1500;
            ProductDetail.Name = "Nike Dri-FIT Long Sleeve";
            ProductDetail.ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Image10.png";
            ProductDetail.Colors = Color.FromArgb("#33427D");
            ProductDetail.Details = "Nike Dri-FIT is a polyester fabric designed to help you keep dry so you can more comfortably work harder, longer.";

            List<ReviewModel> reviewData =
            [
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user1.png", Name = "Samuel Smith", Review = "Wonderful jean, perfect gift for my girl for our anniversary!", Rating = 4 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user1.png", Name = "Samuel Smith", Review = "Wonderful jean, perfect gift for my girl for our anniversary!", Rating = 4 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
                new ReviewModel() { ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/user2.png", Name = "Beth Aida", Review = "I love this, paired it with a nice blouse and all eyes on me.", Rating = 3 },
            ];
            ProductDetail.Reviews = reviewData;
            IsLoaded = true;
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

        private void FavItem(Color obj)
        {
            IsFavorite = true ? !IsFavorite : IsFavorite;
        }
        public void ChageFooterVisibility(double currentY)
        {
            currentScrollIndex = currentY;
            if (currentScrollIndex > lastScrollIndex)
            {
                IsFooterVisible = false;
            }
            else
            {
                IsFooterVisible = true;
            }
            lastScrollIndex = currentScrollIndex;
        }

        private void AddToCart()
        {
           
        }       
    }
}

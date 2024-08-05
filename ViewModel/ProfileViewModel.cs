using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {        
        public string Name { get; set; } = "David Spade";
        public string Email { get; set; } = "iamdavid@gmail.com";
        public string ImageUrl { get; set; } = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Avatar.png";

        private List<MenuItems> _MenuItems = [];
        public List<MenuItems> MenuItems
        {
            get => _MenuItems;
            set => SetProperty(ref _MenuItems, value);
        }

        private bool _IsLoaded;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }

        public ICommand SelectMenuCommand { get; }
        public ProfileViewModel()
        {
            SelectMenuCommand = new Command<MenuItems>(SelectMenu);
            _ = InitializeAsync();
        }
        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }
        async Task PopulateDataAsync()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API if needed
            MenuItems.Clear();
            //MenuItems.Add(new MenuItems() { Title = "Edit Profile", Body = "\uf3eb" });
            MenuItems.Add(new MenuItems() { Title = "Shipping Address", Body = "\uf34e", TargetType = typeof(ShippingAddressView) });
            MenuItems.Add(new MenuItems() { Title = "Wishlist", Body = "\uf2d5", TargetType = typeof(WishListView) });
            MenuItems.Add(new MenuItems() { Title = "Order History", Body = "\uf150", TargetType = typeof(OrderDetailsView) });
            MenuItems.Add(new MenuItems() { Title = "Track Order", Body = "\uf787", TargetType = typeof(OrderDetailsView) });
            MenuItems.Add(new MenuItems() { Title = "Cards", Body = "\uf19b", TargetType = typeof(CardView) });
            //MenuItems.Add(new MenuItems() { Title = "Notifications", Body = "\uf09c"});
            MenuItems.Add(new MenuItems() { Title = "Logout", Body = "\uf343", TargetType = typeof(LoginView) });
            IsLoaded = true;
        }

        private async void SelectMenu(MenuItems item)
        {
            if (item.TargetType !=null )
            {
                if (item.TargetType == typeof(LoginView))
                {
                    var response = await App.Current.MainPage.DisplayAlert("Logout", "Do you want to logout?", "Yes", "No");
                    if (response)
                        App.Current.MainPage = new LoginView();
                }
                else
                {
                    await Application.Current.MainPage.Navigation.PushAsync(((Page)Activator.CreateInstance(item.TargetType)));
                }
            }
            
        }       
    }
}

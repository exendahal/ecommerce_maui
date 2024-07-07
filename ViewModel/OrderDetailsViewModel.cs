using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class OrderDetailsViewModel : BaseViewModel
    {
        public ICommand BackCommand { get; set; }
        public ICommand SelectOrderCommand { get; set; }      

        private ObservableCollection<TrackOrderModel> _TrackData = [];
        public ObservableCollection<TrackOrderModel> TrackData
        {
            get => _TrackData;
            set => SetProperty(ref _TrackData, value);
        }

        private bool _IsLoaded;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public OrderDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
            BackCommand = new Command<object>(GoBack);
            SelectOrderCommand = new Command<object>(TrackCommand);
        }
        public override async Task OnNavigatedTo(NavigationParameters parameters)
        {
            await base.OnNavigatedTo(parameters);
            await PopulateDataAsync();
        }
        private async void TrackCommand(object obj)
        {
            //await Application.Current.MainPage.Navigation.PushAsync(new TrackOrderView((Track)obj));
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        async Task PopulateDataAsync()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API
            TrackData.Add(new TrackOrderModel("Sept 23, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                },
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$700",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));

            TrackData.Add(new TrackOrderModel("Sept 22, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$1500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                    }
                },
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$2700",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Apple.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018",
            [
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered",
                    Images= new List<ImageList>()
                    {
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"},
                        new ImageList(){ImageUrl = "https://raw.githubusercontent.com/exendahal/ecommerceXF/master/eCommerce/eCommerce.Android/Resources/drawable/Icon_Bo.png"}
                    }
                }
            ]));
            IsLoaded = true;
        }

    }
}

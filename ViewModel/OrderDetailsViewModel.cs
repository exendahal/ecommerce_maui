using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class OrderDetailsViewModel : BaseViewModel
    {
        public ICommand BackCommand { get; set; }
        public ICommand SelectOrderCommand { get; set; }
        public List<TrackOrderModel> TrackData { get; private set; } = new List<TrackOrderModel>();

        bool _IsLoaded = false;
        public bool IsLoaded
        {
            get { return _IsLoaded; }
            set
            {
                _IsLoaded = value;
                OnPropertyChanged("IsLoaded");
            }
        }
        public OrderDetailsViewModel(bool emptyGroups = false)
        {
            BackCommand = new Command<object>(GoBack);
            SelectOrderCommand = new Command<object>(TrackCommand);
            InitializeAsync();
        }
        private async void InitializeAsync()
        {
            await PopulateData();
        }
        private async void TrackCommand(object obj)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(new TrackOrderView((Track)obj));
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        async Task PopulateData()
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

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
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
            }));

            TrackData.Add(new TrackOrderModel("Sept 22, 2018", new List<Track>
            {
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
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
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
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
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
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
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
            }));
            IsLoaded = true;
        }

    }
}

using EcommerceMAUI.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ShippingAddressViewModel: BaseViewModel
    {
        private ObservableCollection<AddressModel> _Addressess = [];
        public ObservableCollection<AddressModel> Addressess
        {
            get => _Addressess;
            set => SetProperty(ref _Addressess, value);

        }
        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public ICommand SelectAddressCommand { get; private set; }

        public ShippingAddressViewModel(INavigationService navigationService) : base(navigationService)
        {
            SelectAddressCommand = new Command<AddressModel>(SelectAddress);
        }        

        public override async Task OnNavigatedTo(NavigationParameters parameters)
        {
            await base.OnNavigatedTo(parameters);
            await PopulateDataAsync();
        }

        async Task PopulateDataAsync()
        {
            // Delay added to display loading, remove during api call
            await Task.Delay(500);
            //TODO: Remove Delay here and call API
            Addressess.Add(new AddressModel() { AddressType= "Home Address", FullAddress= "21, Alex Davidson Avenue, Opposite Omegatron, Vicent Smith Quarters, Victoria Island, Lagos, Nigeria", IsSelected = true });
            Addressess.Add(new AddressModel() { AddressType= "Work Address", FullAddress= "9, Martins Crescent, Bank of Nigeria, Abuja, Nigeria" });
             IsLoaded = true;
        }

        private void SelectAddress(AddressModel model)
        {
            foreach (var address in Addressess)
            {
                if (address.AddressType == model.AddressType)
                {
                    model.IsSelected = true;
                }
                else
                {
                    model.IsSelected = false;
                }
            }
        }
    }
}

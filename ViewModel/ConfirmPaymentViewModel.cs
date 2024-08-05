using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ConfirmPaymentViewModel : BaseViewModel
    {
        readonly private DeliveryTypeModel _DeliveryType;
        readonly private AddressModel _PrimaryAddress;
        readonly private ObservableCollection<ProductListModel> _Products = [];
        private CardInfoModel _SelectedCard;
        
        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }

        private ObservableCollection<CardInfoModel> _Cards = [];
        public ObservableCollection<CardInfoModel> Cards
        {
            get => _Cards;
            set => SetProperty(ref _Cards, value);

        }
        public ICommand NextCommand { get; }
        public ICommand SelectPaymentCommand { get; }
        public ICommand BackCommand { get; }


        public ConfirmPaymentViewModel(ObservableCollection<ProductListModel> products, DeliveryTypeModel deliveryType, AddressModel address)
        {
            _DeliveryType = deliveryType;
            _Products = products;
            _PrimaryAddress = address;
            NextCommand = new Command(ConfirmPayment);
            SelectPaymentCommand = new Command<CardInfoModel>(SelectPayment);
            BackCommand = new Command(GoBack);
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
            Cards.Add(new CardInfoModel() { CardNumber = "371449635398431", CardValidationCode = "123", ExpirationDate = "2024-12-01",IsSelected = true });
            Cards.Add(new CardInfoModel() { CardNumber = "38520000023237", CardValidationCode = "456", ExpirationDate = "2025-12-01" });
            Cards.Add(new CardInfoModel() { CardNumber = "6011000990139424", CardValidationCode = "789", ExpirationDate = "2026-12-01" });
            Cards.Add(new CardInfoModel() { CardNumber = "3566002020360505", CardValidationCode = "321", ExpirationDate = "2027-12-01" });
            Cards.Add(new CardInfoModel() { CardNumber = "5555555555554444", CardValidationCode = "654", ExpirationDate = "2028-12-01" });
            Cards.Add(new CardInfoModel() { CardNumber = "4012888888881881", CardValidationCode = "987", ExpirationDate = "2028-12-01" });
            _SelectedCard = Cards[0];
            IsLoaded = true;
        }
        private async void ConfirmPayment()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new FinishCartView(_Products, _DeliveryType, _PrimaryAddress, _SelectedCard));
        }
        private void SelectPayment(CardInfoModel selectedCard)
        {
            foreach (var card in Cards)
            {
                if (card.CardNumber == selectedCard.CardNumber)
                {
                    card.IsSelected = true;
                    _SelectedCard = selectedCard;
                }
                else
                {
                    card.IsSelected = false;
                }
            }
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}

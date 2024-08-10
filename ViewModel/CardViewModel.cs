using EcommerceMAUI.Constants;
using EcommerceMAUI.Helpers;
using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Text.Json;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class CardViewModel : BaseViewModel
    {
        private ObservableCollection<CardInfoModel> _Cards = [];
        public ObservableCollection<CardInfoModel> Cards
        {
            get => _Cards;
            set => SetProperty(ref _Cards, value);

        }
        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }

        public ICommand AddNewCommand { get; }
        public CardViewModel()
        {
            AddNewCommand = new Command(AddNewCard);
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

            var cardResponse = await HttpHelper.GetHttpResponse(ApiUrl.CARD_URL);
            if (!string.IsNullOrWhiteSpace(cardResponse))
            {
                Cards = new ObservableCollection<CardInfoModel>(JsonSerializer.Deserialize<List<CardInfoModel>>(cardResponse, options));
            }

            IsLoaded = true;
        }
        private async void AddNewCard()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddNewCardView());
        }

    }
}

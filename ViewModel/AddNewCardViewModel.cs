using EcommerceMAUI.Helpers;
using EcommerceMAUI.Model;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class AddNewCardViewModel : BaseViewModel
    {
        private CardInfoModel _Card = new();
        public CardInfoModel Card
        {
            get => _Card;
            set => SetProperty(ref _Card, value);

        }

        private string _CardNumber;
        public string CardNumber
        {
            get => _CardNumber;
            set => SetProperty(ref _CardNumber, value);

        }
        private DateTime _ExpireDate = DateTime.Now;
        public DateTime ExpireDate
        {
            get => _ExpireDate;
            set
            {
                if (_ExpireDate != value)
                {
                    _ExpireDate = value;
                    OnPropertyChanged(nameof(ExpireDate));
                    OnPropertyChanged(nameof(ExpireDateString));
                }
            }

        }

        public string ExpireDateString
        {
            get
            {
                return ExpireDate.ToString("MM / dd");
            }
        }


        private string _NameOnCard;
        public string NameOnCard
        {
            get => _NameOnCard;
            set => SetProperty(ref _NameOnCard, value);

        }
        private string _CVV;
        public string CVV
        {
            get => _CVV;
            set => SetProperty(ref _CVV, value);

        }

        public ICommand SaveCommand { get; }
        public ICommand BackCommand { get; }

        public AddNewCardViewModel()
        {
            SaveCommand = new Command(SaveCard);
            BackCommand = new Command(GoBack);
        }

        private async void SaveCard()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
            await ToastHelper.ShowToast("Add card added.");
        }
        private async void GoBack()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

    }
}

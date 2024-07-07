using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class VerificationViewModel : BaseViewModel
    {
        private string _Pin;
        public string Pin
        {
            get => _Pin;
            set => SetProperty(ref _Pin, value);
        }
        public ICommand VerifyCommand { get; }
        public VerificationViewModel(INavigationService navigationService) : base(navigationService)
        {
            VerifyCommand = new Command(VerifyOtp);
        }

        private async void VerifyOtp(object obj)
        {            
            if (!string.IsNullOrWhiteSpace(Pin) && Pin.Length == 6)
            {
                await navigationService.ResetStackAndPush<AppShellView>();
            }
        }
    }
}

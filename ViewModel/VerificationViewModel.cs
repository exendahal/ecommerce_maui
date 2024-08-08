using EcommerceMAUI.Helpers;
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
        public VerificationViewModel()
        {
            VerifyCommand = new Command(VerifyOtp);
        }

        private async void VerifyOtp(object obj)
        {
            if (Pin != null && Pin.Length == 6) 
            {
                App.Current.MainPage = new AppShell();
                await ToastHelper.ShowToast("Welcome");
            }           
        }
    }
}

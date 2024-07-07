
using EcommerceMAUI.Views;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class LoginViewModel: BaseViewModel
    {
        private string _Email;
        public string Email
        {
            get => _Email;
            set => SetProperty(ref _Email, value);
        }

        private string _Password;
        public string Password
        {
            get => _Password;
            set => SetProperty(ref _Password, value);
        }

        public ICommand LoginCommand { get; }
        public ICommand LoginFacebookCommand { get; }
        public ICommand LoginGoogleCommand { get; }
        public ICommand RegisterCommand { get; }
        public ICommand ForgotPasswordCommand { get; }
        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {
            LoginCommand = new Command(Login);
            LoginFacebookCommand = new Command(LoginWithFacebook);
            LoginGoogleCommand = new Command(LoginWithGoogle);
            RegisterCommand = new Command(SignUp);
            ForgotPasswordCommand = new Command(ForgotPassword);
        }

        private void LoginWithGoogle(object obj)
        {
           
        }

        private void LoginWithFacebook(object obj)
        {
           
        }

        private void ForgotPassword(object obj)
        {
           
        }

        private async void SignUp(object obj)
        {
            await navigationService.Push<RegisterView>();
        }

        private async void Login(object obj)
        {            
            await navigationService.ResetStackAndPush<AppShellView>();
        }
    }
}

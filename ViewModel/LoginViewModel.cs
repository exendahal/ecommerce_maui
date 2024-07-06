
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
        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
            LoginFacebookCommand = new Command(Login);
            LoginGoogleCommand = new Command(Login);
            RegisterCommand = new Command(SignUp);
            ForgotPasswordCommand = new Command(ForgotPassword);
        }

        private void ForgotPassword(object obj)
        {
           
        }

        private async void SignUp(object obj)
        {
           await Application.Current.MainPage.Navigation.PushModalAsync(new RegisterView());
        }

        private void Login(object obj)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}

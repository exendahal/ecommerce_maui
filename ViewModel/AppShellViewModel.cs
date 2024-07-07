
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class AppShellViewModel : BaseViewModel
    {
        public ICommand OnNavigatingCommand { get; }
        public AppShellViewModel(INavigationService navigationService) : base(navigationService)
        {
            OnNavigatingCommand = new Command(OnNavigating);
        }
        private void OnNavigating()
        {
            // Your logic here
        }
    }
}

using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
        BindingContext = new LoginViewModel();
    }
}
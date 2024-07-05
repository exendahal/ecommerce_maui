using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class RegisterView : ContentPage
{
	public RegisterView()
	{
		InitializeComponent();
        BindingContext = new RegisterViewModel();
    }
}
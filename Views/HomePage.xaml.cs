using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
        BindingContext = new HomePageViewModel();
        InitializeComponent();       
    }

}
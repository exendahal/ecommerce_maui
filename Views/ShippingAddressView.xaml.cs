using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class ShippingAddressView : ContentPage
{
	public ShippingAddressView()
	{
		InitializeComponent();
        BindingContext = new ShippingAddressViewModel();

    }
}
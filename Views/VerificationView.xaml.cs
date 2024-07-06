using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class VerificationView : ContentPage
{
	public VerificationView()
	{
		InitializeComponent();
        BindingContext = new VerificationViewModel();
    }   
}
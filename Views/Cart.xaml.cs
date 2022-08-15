using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class Cart : ContentPage
{
	public Cart()
	{
		InitializeComponent();
		BindingContext = new CartViewModel();

    }

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{

	}

	private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        double value = e.NewValue;
    }
}
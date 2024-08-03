using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class AddNewCardView : ContentPage
{
	public AddNewCardView()
	{
		InitializeComponent();
		BindingContext = new AddNewCardViewModel();

    }
}
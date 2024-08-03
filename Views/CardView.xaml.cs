using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class CardView : ContentPage
{
    public CardView()
	{
		InitializeComponent();
		BindingContext = new CardViewModel();

    }
}
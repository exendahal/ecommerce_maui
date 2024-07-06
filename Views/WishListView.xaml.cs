using EcommerceMAUI.ViewModel;
namespace EcommerceMAUI.Views;

public partial class WishListView : ContentPage
{   
    public WishListView()
	{
		InitializeComponent();
		BindingContext = new WishListViewModel();

    }
}
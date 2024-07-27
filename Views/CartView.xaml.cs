using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class CartView : ContentPage
{
    public CartView()
    {
        InitializeComponent();
        BindingContext = new CartViewModel();
    }    
}
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class ProductDetails : ContentPage
{
    public ProductDetails()
    {
        InitializeComponent();
        BindingContext = new ProductDetailsViewModel();
    }
}
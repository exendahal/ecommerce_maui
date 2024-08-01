using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class ProductDetailsView : ContentPage
{
    public ProductDetailsView()
    {
        InitializeComponent();
        BindingContext = new ProductDetailsViewModel();
    }

}
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class BrandDetailView : ContentPage
{
    public BrandDetailView()
    {
        InitializeComponent();
        BindingContext = new BrandDetailViewModel();
    }
}
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class ProductDetailsView : ContentPage
{
    ProductDetailsViewModel viewModel;
    public ProductDetailsView()
    {
        InitializeComponent();
        BindingContext = viewModel = new ProductDetailsViewModel();
    }

    private void ScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        viewModel.ChageFooterVisibility(e.ScrollY);
    }
}
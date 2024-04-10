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

    private void ScrollView_Scrolled(object sender, ScrolledEventArgs e)
    {
        viewModel.ChageFooterVisibility(e.ScrollY);
    }
}
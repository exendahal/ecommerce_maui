namespace EcommerceMAUI.Views;

public partial class ProductDetailsView : ContentPage
{
    public ProductDetailsView()
    {
        InitializeComponent();
    }

    private void ScrollViewScrolled(object sender, ScrolledEventArgs e)
    {
        //viewModel.ChageFooterVisibility(e.ScrollY);
    }
}
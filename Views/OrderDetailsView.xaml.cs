using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class OrderDetailsView : ContentPage
{
    public OrderDetailsView()
    {
        InitializeComponent();
        BindingContext = new OrderDetailsViewModel();
    }
}
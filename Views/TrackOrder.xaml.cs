using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class TrackOrder : ContentPage
{
    public TrackOrder()
    {
        InitializeComponent();
        BindingContext = new TrackOrderViewModel();
    }
}
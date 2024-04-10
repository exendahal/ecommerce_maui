using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class ProfileView : ContentPage
{
    public ProfileView()
    {
        InitializeComponent();
        BindingContext = new ProfileViewModel();
    }
}
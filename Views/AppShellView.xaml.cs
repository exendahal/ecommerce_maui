using EcommerceMAUI.Views;

namespace EcommerceMAUI;

public partial class AppShellView : Shell
{
    public AppShellView()
    {
        InitializeComponent();
        Routing.RegisterRoute("Home", typeof(HomePageView));
        Routing.RegisterRoute("Cart", typeof(CartView));
        Routing.RegisterRoute("Profile", typeof(ProfileView));
    }
}

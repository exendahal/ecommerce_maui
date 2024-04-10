using EcommerceMAUI.ViewModel;
namespace EcommerceMAUI.Views;
public partial class AllProductView : ContentPage
{
    public AllProductView()
    {
        InitializeComponent();
        BindingContext = new AllProductViewModel();
    }
}
namespace EcommerceMAUI.Views;

public partial class CartView : ContentPage
{
    public CartView()
    {
        InitializeComponent();
    }
    private void SwipeItem_Invoked(object sender, EventArgs e)
    {

    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double value = e.NewValue;
    }
}
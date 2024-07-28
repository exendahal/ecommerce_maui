using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class CardView : ContentPage
{
    private double lastScrollY = 0;
    public CardView()
	{
		InitializeComponent();
		BindingContext = new CardViewModel();

    }

    private void OnCollectionViewScrolled(object sender, ItemsViewScrolledEventArgs e)
    {
        if (e.VerticalOffset > lastScrollY)
        {
            // Scrolling down
            FloatingButton.IsVisible = false;
        }
        else if (e.VerticalOffset < lastScrollY)
        {
            // Scrolling up
            FloatingButton.IsVisible = true;
        }

        lastScrollY = e.VerticalOffset;
    }
}
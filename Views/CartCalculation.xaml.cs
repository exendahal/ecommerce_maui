using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;
using System.Collections.ObjectModel;

namespace EcommerceMAUI.Views;

public partial class CartCalculation : ContentPage
{
	public CartCalculation(ObservableCollection<ProductListModel> ProductList)
	{
		InitializeComponent();
        BindingContext = new CartCalculationViewModel(ProductList);
    }
}
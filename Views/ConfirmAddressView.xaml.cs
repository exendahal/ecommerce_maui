using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;
using System.Collections.ObjectModel;

namespace EcommerceMAUI.Views;

public partial class ConfirmAddressView : ContentPage
{
	public ConfirmAddressView(ObservableCollection<ProductListModel> products, DeliveryTypeModel deliveryType)
	{
		InitializeComponent();
        BindingContext = new ConfirmAddressViewModel(products, deliveryType);
    }
}
using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;
using System.Collections.ObjectModel;

namespace EcommerceMAUI.Views;

public partial class ConfirmPaymentView : ContentPage
{
	public ConfirmPaymentView(ObservableCollection<ProductListModel> products, DeliveryTypeModel deliveryType, AddressModel address)
	{
		InitializeComponent();
        BindingContext = new ConfirmPaymentViewModel(products, deliveryType, address);
    }
}
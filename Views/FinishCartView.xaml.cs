using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;
using System.Collections.ObjectModel;

namespace EcommerceMAUI.Views;

public partial class FinishCartView : ContentPage
{
	public FinishCartView(ObservableCollection<ProductModel> products, DeliveryTypeModel deliveryType, AddressModel address, CardInfoModel card)
	{
		InitializeComponent();
		BindingContext = new FinishCartViewModel(products, deliveryType, address, card);

    }
}
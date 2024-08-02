using EcommerceMAUI.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class FinishCartViewModel : BaseViewModel
    {
        private DeliveryTypeModel _DeliveryType;
        public DeliveryTypeModel DeliveryType
        {
            get => _DeliveryType;
            set => SetProperty(ref _DeliveryType, value);
        }

        private AddressModel _PrimaryAddress;
        public AddressModel PrimaryAddress
        {
            get => _PrimaryAddress;
            set => SetProperty(ref _PrimaryAddress, value);
        }

        private ObservableCollection<ProductListModel> _Products = [];
        public ObservableCollection<ProductListModel> Products
        {
            get => _Products;
            set => SetProperty(ref _Products, value);
        }

        private CardInfoModel _SelectedCard;
        public CardInfoModel SelectedCard
        {
            get => _SelectedCard;
            set => SetProperty(ref _SelectedCard, value);
        }

        public ICommand FinishCommand { get; private set; }
        public FinishCartViewModel(ObservableCollection<ProductListModel> products, DeliveryTypeModel deliveryType, AddressModel address, CardInfoModel card)
        {
            _DeliveryType = deliveryType;
            _Products = products;
            _PrimaryAddress = address;
            _SelectedCard = card;
        }
    }
}

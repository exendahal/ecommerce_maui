using EcommerceMAUI.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class CartCalculationViewModel : BaseViewModel
    {
        private ObservableCollection<ProductListModel> _AllProductDataList = [];
        public ObservableCollection<ProductListModel> AllProductDataList
        {
            get => _AllProductDataList;
            set => SetProperty(ref _AllProductDataList, value);
        }

        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        private double _SubTotal = 0;
        public double SubTotal
        {
            get => _SubTotal;
            set => SetProperty(ref _SubTotal, value);
        }
        public ICommand CheckoutCommand { get; }
        public ICommand ApplyVoucherCommand { get; }

        public CartCalculationViewModel(ObservableCollection<ProductListModel> ProductList)
        {
            AllProductDataList = ProductList;
            SubTotal = AllProductDataList.Sum(item => (item.Qty * item.Price));
            CheckoutCommand = new Command(Checkout);
            ApplyVoucherCommand = new Command<string>(ApplyVoucher);
            IsLoaded = true;
        }

        private void Checkout()
        {
            
        }
        private void ApplyVoucher(string vaucher)
        {

        }
    }
}

using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class CartCalculationViewModel : BaseViewModel
    {
        private ObservableCollection<ProductListModel> _Products = [];
        public ObservableCollection<ProductListModel> Products
        {
            get => _Products;
            set => SetProperty(ref _Products, value);
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
        public ICommand BackCommand { get; }

        public CartCalculationViewModel(ObservableCollection<ProductListModel> products)
        {
            Products = products;
            SubTotal = Products.Sum(item => (item.Qty * item.Price));
            CheckoutCommand = new Command(Checkout);
            ApplyVoucherCommand = new Command<string>(ApplyVoucher);
            BackCommand = new Command(GoBack);
            IsLoaded = true;
        }

        private async void Checkout()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new DeliveryTypeView(Products));
        }
        private void ApplyVoucher(string vaucher)
        {

        }

        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}

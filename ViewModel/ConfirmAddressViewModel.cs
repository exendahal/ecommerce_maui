﻿using EcommerceMAUI.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace EcommerceMAUI.ViewModel
{
    public class ConfirmAddressViewModel : BaseViewModel
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

        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public ICommand NextCommand { get; private set; }
        public ConfirmAddressViewModel(ObservableCollection<ProductListModel> products, DeliveryTypeModel deliveryType)
        {
            DeliveryType = deliveryType;
            Products = products;
            NextCommand = new Command(ConfirmAddress);
            _ = InitializeAsync();
        }

        private async Task InitializeAsync()
        {
            await PopulateDataAsync();
        }
        async Task PopulateDataAsync()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API if needed
            PrimaryAddress = new AddressModel()
            {
                StreetOne = "21, Alex Davidson Avenue",
                StreetTwo = "Opposite Omegatron, Vicent Quarters",
                City = "Victoria Island",
                State = "Lagos State"
            };
             IsLoaded = true;
        }

        private void ConfirmAddress()
        {
           
        }
    }
}

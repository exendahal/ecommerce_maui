using EcommerceMAUI.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class TrackOrderViewModel : BaseViewModel
    {
        private ObservableCollection<DeliveryStepsModel> _TrackStatus = [];
        public ObservableCollection<DeliveryStepsModel> TrackStatus
        {
            get => _TrackStatus;
            set => SetProperty(ref _TrackStatus, value);

        }  
        public Track TrackOrderData { get; set; }
        public string PageTitle
        {
            get
            {
                return TrackOrderData.OrderId;
            }
        }
        private bool _IsLoaded = false;
        public bool IsLoaded
        {
            get => _IsLoaded;
            set => SetProperty(ref _IsLoaded, value);
        }
        public ICommand BackCommand { get; set; }

        public TrackOrderViewModel(Track data, bool emptyGroups = false)
        {
            TrackOrderData = data;
            BackCommand = new Command<object>(GoBack);
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
            TrackStatus.Add(new DeliveryStepsModel() { Id = 1, DeliveryStatusDate = DateTime.Now.AddDays(-4), IsComplete = true, Name = "Order Placed", Location = "Lagos State, Nigeria" });
            TrackStatus.Add(new DeliveryStepsModel() { Id = 2, DeliveryStatusDate = DateTime.Now.AddDays(-3), IsComplete = true, Name = "Order Confirmed", Location = "Lagos State, Nigeria" });
            TrackStatus.Add(new DeliveryStepsModel() { Id = 3, DeliveryStatusDate = DateTime.Now.AddDays(-2), IsComplete = true, Name = "Order Dispatched", Location = "Lagos State, Nigeria" });
            TrackStatus.Add(new DeliveryStepsModel() { Id = 4, DeliveryStatusDate = DateTime.Now.AddDays(-1), IsComplete = false, Name = "Out for Delivery", Location = "Lagos State, Nigeria" });
            TrackStatus.Add(new DeliveryStepsModel() { Id = 5, DeliveryStatusDate = DateTime.Now, IsComplete = false, Name = "Order Delivered", Location = "Lagos State, Nigeria" , IsLineVisible  = false});
            IsLoaded = true;
        }

        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}



using EcommerceMAUI.Model;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class TrackOrderViewModel : BaseViewModel
    {
        public List<DeliveryStepsModel> TrackStatusData { get; private set; } = [];
        public ICommand BackCommand { get; set; }
        Track TrackOrderData { get; set; }
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
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 1, DateMonth = "04/06/2023", IsComplete = true, Time = "08:00", Name = "Order Placed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 2, DateMonth = "04/06/2023", IsComplete = true, Time = "10:00", Name = "Order Confirmed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 3, DateMonth = "05/06/2023", IsComplete = true, Time = "09:30", Name = "Order Dispatched", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 4, DateMonth = "06/06/2023", IsComplete = false, Time = "14:00", Name = "Out for Delivery", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 5, DateMonth = "06/06/2023", IsComplete = false, Time = "17:00", Name = "Order Delivered", Location = "Lagos State, Nigeria" , IsLineVisible  = false});
            IsLoaded = true;
        }

        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}

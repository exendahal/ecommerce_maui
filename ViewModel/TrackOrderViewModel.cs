

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
            InitializeAsync();
        }

        private async void InitializeAsync()
        {
            await PopulateData();
        }
        async Task PopulateData()
        {
            await Task.Delay(500);
            //TODO: Remove Delay here and call API if needed
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 1, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 2, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 3, DateMonth = "20/18", IsComplete = true, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 4, DateMonth = "20/18", IsComplete = false, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            TrackStatusData.Add(new DeliveryStepsModel() { Id = 5, DateMonth = "20/18", IsComplete = false, Time = "12:00", Name = "Order Signed", Location = "Lagos State, Nigeria" });
            IsLoaded = true;
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}

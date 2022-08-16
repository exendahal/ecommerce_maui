

using EcommerceMAUI.Model;
using System.Windows.Input;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.ViewModel
{
    public class TrackOrderViewModel : BaseViewModel
    {
        public ICommand TapBackCommand { get; set; }
        public List<TrackOrderModel> TrackData { get; private set; } = new List<TrackOrderModel>();

        public TrackOrderViewModel(bool emptyGroups = false)
        {
            PopulateData();
            TapBackCommand = new Command<object>(GoBack);
        }
        private async void GoBack(object obj)
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
        void PopulateData()
        {
            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered"
                }
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$500",
                    Status = "Delivered"
                },
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$700",
                    Status = "Delivered"
                }
            }));

            TrackData.Add(new TrackOrderModel("Sept 22, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$1500",
                    Status = "Delivered"
                },
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$2700",
                    Status = "Delivered"
                }
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered"
                }
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered"
                }
            }));

            TrackData.Add(new TrackOrderModel("Sept 23, 2018", new List<Track>
            {
                new Track
                {
                    OrderId = "OD - 424923192 - N",
                    Price = "$4500",
                    Status = "Delivered"
                }
            }));
        }

    }
}

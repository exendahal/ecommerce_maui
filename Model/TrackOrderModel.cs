using EcommerceMAUI.ViewModel;
using static EcommerceMAUI.Model.TrackOrderModel;

namespace EcommerceMAUI.Model
{
    public class TrackOrderModel : List<Track>
    {
        public string Date { get; private set; }

        public TrackOrderModel(string date, List<Track> tracks) : base(tracks)
        {
            Date = date;
        }

        public override string ToString()
        {
            return Date;
        }

        public class Track : BaseViewModel
        {
            private string _OrderId;
            public string OrderId
            {
                get => _OrderId;
                set => SetProperty(ref _OrderId, value);
            }
            private string _Price;
            public string Price
            {
                get => _Price;
                set => SetProperty(ref _Price, value);
            }
            private string _Status;
            public string Status
            {
                get => _Status;
                set => SetProperty(ref _Status, value);
            }
            private List<ImageList> _Images = [];
            public List<ImageList> Images
            {
                get => _Images;
                set => SetProperty(ref _Images, value);
            }
            public int NumberOfItems { get { return Images.Count(); } }
            public bool ImageOneVisibility { get { return NumberOfItems >= 1; } }
            public string ImageOneUrl { get { return Images[0].ImageUrl; } }
            public bool ImageTwoVisibility { get { return NumberOfItems >= 2; } }
            public string ImageTwoUrl { get { return Images[1].ImageUrl; } }
            public bool ImageThreeVisibility { get { return NumberOfItems >= 3; } }
            public string ImageThreeUrl { get { return Images[2].ImageUrl; } }
            public bool ImageMoreVisibility { get { return NumberOfItems >= 4; } }
            public int RemainingImages { get { return NumberOfItems - 3; } }
            public override string ToString()
            {
                return OrderId;
            }
        }

        public class ImageList
        {
            public string ImageUrl { get; set; }
        }
    }
}
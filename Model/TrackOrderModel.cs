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

        public class Track: BaseViewModel
        {
            public string _OrderId { get; set; }
            public string OrderId
            {
                get { return _OrderId; }
                set
                {
                    _OrderId = value;
                    OnPropertyChanged("OrderId");
                }
            }
            public string _Price { get; set; }
            public string Price
            {
                get { return _Price; }
                set
                {
                    _Price = value;
                    OnPropertyChanged("Price");
                }
            }
            public string _Status { get; set; }
            public string Status
            {
                get { return _Status; }
                set
                {
                    _Status = value;
                    OnPropertyChanged("Status");
                }
            }
            public List<ImageList> _Images { get; set; }
            public List<ImageList> Images
            {
                get { return _Images; }
                set
                {
                    _Images = value;
                    OnPropertyChanged("Images");
                }
            }
            public int NumberOfItems { get { return Images.Count(); } }
            public bool ImageOneVisibility { get { return NumberOfItems >= 1 ? true : false; } }
            public string ImageOneUrl { get { return Images[0].ImageUrl; } }
            public bool ImageTwoVisibility { get { return NumberOfItems >= 2 ? true : false; } }
            public string ImageTwoUrl { get { return Images[1].ImageUrl; } }
            public bool ImageThreeVisibility { get { return NumberOfItems >= 3 ? true : false; } }
            public string ImageThreeUrl { get { return Images[2].ImageUrl; } }
            public bool ImageMoreVisibility { get { return NumberOfItems >= 4 ? true : false; } }
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

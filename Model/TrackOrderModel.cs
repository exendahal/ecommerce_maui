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

        public class Track
        {
            public string OrderId { get; set; }
            public string Price { get; set; }
            public string Status { get; set; }
            public List<ImageList> Images { get; set; }
            public int NumberOfItems { get { return Images.Count(); } }
            public bool ImageOneVisibility { get { return NumberOfItems == 1 ? true:false; } }
            public bool ImageTwoVisibility { get { return NumberOfItems == 2 ? true : false; } }
            public bool ImageThreeVisibility { get { return NumberOfItems == 3 ? true : false; } }
            public bool ImageMoreVisibility { get { return NumberOfItems >= 4 ? true : false; } }
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

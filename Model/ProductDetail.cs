using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{
    public class ProductDetail: BaseViewModel
    {
        public string _ImageUrl { get; set; }
        public string ImageUrl
        {
            get
            {
                return _ImageUrl;
            }
            set
            {
                _ImageUrl = value;
                OnPropertyChanged("ImageUrl");
            }
        }

        public string _Name { get; set; }

        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public List<string> _Sizes { get; set; }

        public List<string> Sizes
        {
            get
            {
                return _Sizes;
            }
            set
            {
                _Sizes = value;
                OnPropertyChanged("Sizes");
            }
        }

        public List<ReviewModel> _Reviews { get; set; }

        public List<ReviewModel> Reviews
        {
            get
            {
                return _Reviews;
            }
            set
            {
                _Reviews = value;
                OnPropertyChanged("Reviews");
            }
        }

        public Color _Colors { get; set; }

        public Color Colors
        {
            get
            {
                return _Colors;
            }
            set
            {
                _Colors = value;
                OnPropertyChanged("Colors");
            }
        }

        public string _Details { get; set; }

        public string Details
        {
            get
            {
                return _Details;
            }
            set
            {
                _Details = value;
                OnPropertyChanged("Details");
            }
        }

        public double _Price { get; set; }

        public double Price
        {
            get
            {
                return _Price;
            }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }


    }

    public class ReviewModel
    {
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Review { get; set; }
        public float Rating { get; set; }
    }
}

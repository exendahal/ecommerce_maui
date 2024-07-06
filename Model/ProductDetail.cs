using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{
    public class ProductDetail : BaseViewModel
    {
        private string _ImageUrl;
        public string ImageUrl
        {
            get => _ImageUrl;
            set => SetProperty(ref _ImageUrl, value);
        }

        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }

        private List<string> _Sizes;
        public List<string> Sizes
        {
            get => _Sizes;
            set => SetProperty(ref _Sizes, value);
        }

        private List<ReviewModel> _Reviews;

        public List<ReviewModel> Reviews
        {
            get => _Reviews;
            set => SetProperty(ref _Reviews, value);
        }

        private Color _Colors;
        public Color Colors
        {
            get => _Colors;
            set => SetProperty(ref _Colors, value);
        }

        private string _Details;
        public string Details
        {
            get => _Details;
            set => SetProperty(ref _Details, value);
        }

        private double _Price;
        public double Price
        {
            get => _Price;
            set => SetProperty(ref _Price, value);
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
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{
    public class ProductModel: BaseViewModel
    {
        public int CategoryId { get; set; }
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string BrandName { get; set; }
        public double Price { get; set; }
        public string Details { get; set; }
        public double Qty { get; set; } = 1;

        private bool _IsAvailable;
        public bool IsAvailable
        {
            get => _IsAvailable;
            set
            {
                if (_IsAvailable != value)
                {
                    _IsAvailable = value;
                    OnPropertyChanged(nameof(IsAvailable));
                    OnPropertyChanged(nameof(AvailableColor));
                }
            }
        }
        public Color AvailableColor
        {
            get
            {
                if (IsAvailable)
                {
                    return Color.FromArgb("#00C569");
                }
                return Color.FromArgb("#FFB900");
            }
        }

        public string AvailableText
        {
            get
            {
                if (IsAvailable)
                {
                    return "In Stock";
                }
                return "Out of Stock";
            }
        }

        public bool IsBestSelling { get; set; }
        public bool IsFeatured { get; set; }
        public bool IsWishList { get; set; }

    }
}

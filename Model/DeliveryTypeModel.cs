using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{
    public class DeliveryTypeModel : BaseViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private bool _IsSelected = false;
        public bool IsSelected
        {
            get => _IsSelected;
            set => SetProperty(ref _IsSelected, value);
        }
    }
}

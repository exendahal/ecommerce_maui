
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{

    public class DeliveryStepsModel : BaseViewModel
    {
        public int Id { get; set; }
        private string _Name;
        public string Name
        {
            get => _Name;
            set => SetProperty(ref _Name, value);
        }
        private string _Location;
        public string Location
        {
            get => _Location;
            set => SetProperty(ref _Location, value);
        }
        private DateTime _DeliveryStatusDate;
        public DateTime DeliveryStatusDate
        {
            get => _DeliveryStatusDate;
            set => SetProperty(ref _DeliveryStatusDate, value);
        }       

        private bool _IsComplete;
        public bool IsComplete
        {
            get => _IsComplete;
            set
            {
                if (_IsComplete != value)
                {
                    _IsComplete = value;
                    OnPropertyChanged(nameof(IsComplete));
                    OnPropertyChanged(nameof(StatusColor));
                    OnPropertyChanged(nameof(IsLineVisible));
                }
            }

        }

        public Color StatusColor
        {
            get { return IsComplete ? Color.FromArgb("#00C569") : Color.FromArgb("#C8C8C8"); }
        }

        private bool _IsLineVisible = true;
        public bool IsLineVisible
        {
            get => _IsLineVisible;
            set => SetProperty(ref _IsLineVisible, value);
        }
    }
}
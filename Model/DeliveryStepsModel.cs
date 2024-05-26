
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{

    public class DeliveryStepsModel: BaseViewModel
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
        private string _DateMonth;
        public string DateMonth
        {
            get => _DateMonth;
            set => SetProperty(ref _DateMonth, value);
        }
        private string _Time;
        public string Time
        {
            get => _Time;
            set => SetProperty(ref _Time, value);
        }

        private bool _IsComplete;
        public bool IsComplete
        {
            get => _IsComplete;
            set => SetProperty(ref _IsComplete, value);
        }

        private Color _StatusColor;
        public Color StatusColor
        {
            get => _StatusColor;
            set => SetProperty(ref _StatusColor, value);
        }

        private bool _IsLineVisible;
        public bool IsLineVisible
        {
            get => _IsLineVisible;
            set => SetProperty(ref _IsLineVisible, value);
        }

    }
}

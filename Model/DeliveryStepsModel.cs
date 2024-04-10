
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Model
{

    public class DeliveryStepsModel: BaseViewModel
    {
        public int Id { get; set; }    
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
        public string _Location { get; set; }
        public string Location
        {
            get
            {
                return _Location;
            }
            set
            {
                _Location = value;
                OnPropertyChanged("Location");
            }
        }      
        public string _DateMonth { get; set; }
        public string DateMonth
        {
            get
            {
                return _DateMonth;
            }
            set
            {
                _DateMonth = value;
                OnPropertyChanged("DateMonth");
            }
        }
        public string _Time { get; set; }
        public string Time
        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
                OnPropertyChanged("Time");
            }
        }

        public bool _IsComplete { get; set; }
        public bool IsComplete
        {
            get
            {
                return _IsComplete;
            }
            set
            {
                _IsComplete = value;
                OnPropertyChanged("IsComplete");
            }
        }

        public Color _StatusColor { get; set; }
        public Color StatusColor
        {
            get
            {
                return _StatusColor;
            }
            set
            {
                _StatusColor = value;
                OnPropertyChanged("StatusColor");
            }
        }

        public bool _IsLineVisible { get; set; }
        public bool IsLineVisible
        {
            get
            {
                return _IsLineVisible;
            }
            set
            {
                _IsLineVisible = value;
                OnPropertyChanged("IsLineVisible");
            }
        }

    }
}

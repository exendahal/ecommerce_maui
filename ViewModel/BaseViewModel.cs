
namespace EcommerceMAUI.ViewModel
{
    public class BaseViewModel : BindableBase, INavigationAware, IActiveAware
    {
        private bool _isActive;
        public event EventHandler IsActiveChanged;

        public bool IsActive
        {
            get { return _isActive; }
            set { SetProperty(ref _isActive, value, () => OnActiveChanged()); }
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }
        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }
        public virtual void OnActiveChanged()
        {

        }



    }
}

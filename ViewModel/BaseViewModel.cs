
using CommunityToolkit.Mvvm.ComponentModel;

namespace EcommerceMAUI.ViewModel
{
    public class BaseViewModel : ObservableObject, INavigatedEvents, INavigatingEvents
    {

        #region Fields

        protected INavigationService navigationService { get; }

        #endregion Fields

        #region Constructors

        public BaseViewModel(
            INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        #endregion Constructors

        #region Lifecycle events

        public virtual Task OnNavigatedTo(NavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatedFrom(NavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public virtual Task OnNavigatingFrom(NavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        #endregion Lifecycle events

        //public event PropertyChangedEventHandler PropertyChanged;

        //protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}

        //protected bool SetProperty<T>(ref T backingStore, T value,
        //    [CallerMemberName] string propertyName = "",
        //    Action onChanged = null)
        //{
        //    if (EqualityComparer<T>.Default.Equals(backingStore, value))
        //        return false;

        //    backingStore = value;
        //    onChanged?.Invoke();
        //    OnPropertyChanged(propertyName);
        //    return true;
        //}
    }
}

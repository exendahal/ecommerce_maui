

using EcommerceMAUI.Model;
using EcommerceMAUI.Views;
using System.Collections.ObjectModel;
using System.Windows.Input;
using static Android.Content.ClipData;

namespace EcommerceMAUI.ViewModel
{
    public class ProfileViewModel : BaseViewModel
    {
        public ICommand TapCommand { get; private set; }

        public List<MenuItems> MenuItems = new List<MenuItems>();
       
        public ProfileViewModel()
        {
            PopulateData();
            CommandInit();
        }

        void PopulateData()
        {
            MenuItems.Clear();
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
            MenuItems.Add(new Model.MenuItems() { Title = "Edit Profile", Body = "\U000f056e", TargetType = typeof(HomePage) });
        }

        private void CommandInit()
        {
            TapCommand = new Command<MenuItems>(item =>
            {
                Application.Current.MainPage.Navigation.PushAsync(new NavigationPage((Page)Activator.CreateInstance(item.TargetType)));
            });

        }
    }
}

using EcommerceMAUI.Model;
using EcommerceMAUI.ViewModel;

namespace EcommerceMAUI.Views;

public partial class CategoryDetailView : ContentPage
{
    public CategoryDetailView(CategoriesModel data)
    {
        InitializeComponent();
        BindingContext = new CategoryDetailViewModel(data);
    }
}
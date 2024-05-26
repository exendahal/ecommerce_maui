using EcommerceMAUI.ViewModel;
using EcommerceMAUI.Views;

namespace EcommerceMAUI;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
        .UseMauiApp<App>()
        .UsePrism(prism => prism.ConfigureServices(services =>
        {
            services.RegisterForNavigation<HomePageView, HomePageViewModel>();
            services.RegisterForNavigation<AllProductView, AllProductViewModel>();
            services.RegisterForNavigation<BrandDetailView, BrandDetailViewModel>();
            services.RegisterForNavigation<CartView, CartViewModel>();
            services.RegisterForNavigation<CategoryDetailView, CategoryDetailViewModel>();
            services.RegisterForNavigation<OrderDetailsView, OrderDetailsViewModel>();
            services.RegisterForNavigation<ProductDetailsView, ProductDetailsViewModel>();
            services.RegisterForNavigation<ProfileView, ProfileViewModel>();
            services.RegisterForNavigation<TrackOrderView, TrackOrderViewModel>();
            services.RegisterForNavigation<AppShell>();
        })
        .RegisterTypes(container =>
        {
           
        })
        .CreateWindow("/AppShell")

        )
        .ConfigureFonts(fonts =>
        {
            fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            fonts.AddFont("icon.ttf", "icon");
        });
        return builder.Build();
    }
}

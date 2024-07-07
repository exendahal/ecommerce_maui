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
             .UseBurkusMvvm(mvvm =>
             {
                 mvvm.OnStart(async (navigationService, serviceProvider) =>
                 {
                     await navigationService.Navigate("/LoginView");
                 });
             })
            .RegisterViewModels()
            .RegisterViews()
            .RegisterServices()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Material-Icon.ttf", "MaterialIcon");
                fonts.AddFont("FontAwesome6-Brands.otf", "FA6Brands");
                fonts.AddFont("FontAwesome6-Regular.otf", "FA6Regular");
            });

        return builder.Build();
    }

    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<AllProductViewModel>();
        mauiAppBuilder.Services.AddTransient<BrandDetailViewModel>();
        mauiAppBuilder.Services.AddTransient<CardViewModel>();
        mauiAppBuilder.Services.AddTransient<CartViewModel>();
        mauiAppBuilder.Services.AddTransient<CategoryDetailViewModel>();
        mauiAppBuilder.Services.AddTransient<HomePageViewModel>();
        mauiAppBuilder.Services.AddTransient<LoginViewModel>();
        mauiAppBuilder.Services.AddTransient<OrderDetailsViewModel>();
        mauiAppBuilder.Services.AddTransient<ProductDetailsViewModel>();
        mauiAppBuilder.Services.AddTransient<ProfileViewModel>();
        mauiAppBuilder.Services.AddTransient<RegisterViewModel>();
        mauiAppBuilder.Services.AddTransient<ShippingAddressViewModel>();
        mauiAppBuilder.Services.AddTransient<TrackOrderViewModel>();
        mauiAppBuilder.Services.AddTransient<VerificationViewModel>();
        mauiAppBuilder.Services.AddTransient<WishListViewModel>();
        mauiAppBuilder.Services.AddTransient<AppShellViewModel>();
        return mauiAppBuilder;
    }

    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<AllProductView>();
        mauiAppBuilder.Services.AddTransient<BrandDetailView>();
        mauiAppBuilder.Services.AddTransient<CardView>();
        mauiAppBuilder.Services.AddTransient<CartView>();
        mauiAppBuilder.Services.AddTransient<CategoryDetailView>();
        mauiAppBuilder.Services.AddTransient<HomePageView>();
        mauiAppBuilder.Services.AddTransient<LoginView>();
        mauiAppBuilder.Services.AddTransient<OrderDetailsView>();
        mauiAppBuilder.Services.AddTransient<ProductDetailsView>();
        mauiAppBuilder.Services.AddTransient<ProfileView>();
        mauiAppBuilder.Services.AddTransient<RegisterView>();
        mauiAppBuilder.Services.AddTransient<ShippingAddressView>();
        mauiAppBuilder.Services.AddTransient<TrackOrderView>();
        mauiAppBuilder.Services.AddTransient<VerificationView>();
        mauiAppBuilder.Services.AddTransient<WishListView>();
        mauiAppBuilder.Services.AddTransient<AppShellView>();
        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
    {
        return mauiAppBuilder;
    }

}

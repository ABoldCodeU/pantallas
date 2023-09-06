﻿using AxitHome.ViewModels;
using AxitHome.Views.Pages;
using AxitHome.Views.Pages.Reservaciones;
using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;

namespace AxitHome;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder.UseMauiApp<App>()
			.RegisterViewModels().RegisterSingletons().RegisterViews().ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Poppins-SemiBold.ttf", "PoppinsSemiBold");
                fonts.AddFont("Poppins-Regular.ttf", "Poppins");
                fonts.AddFont("CustomIcon.ttf", "CustomIcon");
                fonts.AddFont("Font-Awesome-6-Pro-Regular.otf", "FontAwesome");
                fonts.AddFont("Font-Awesome-6-Pro-Solid.otf", "FontAwesomeSolid");
            }).UseMauiCompatibility();

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
    public static MauiAppBuilder RegisterSingletons(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddSingleton<AppShell>();
        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
	{
        mauiAppBuilder.Services.AddTransient<LoginPageViewModel>();
        mauiAppBuilder.Services.AddTransient<CreateAccountViewModel>();
        mauiAppBuilder.Services.AddTransient<ReservacionesListViewModel>();
        return mauiAppBuilder;
    }
    public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
    {
        mauiAppBuilder.Services.AddTransient<LoginPage>();
        mauiAppBuilder.Services.AddTransient<CreateAccountPage>();
        mauiAppBuilder.Services.AddTransient<HomePage>();
        mauiAppBuilder.Services.AddTransient<ReservacionesListPage>();
        mauiAppBuilder.Services.AddTransient<ReservacionPage>();
        return mauiAppBuilder;
    }
}

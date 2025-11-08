using Microsoft.Extensions.Logging;
using MVVMFrameworkDotNet9.Interfaces;
using MVVMFrameworkDotNet9.Services;
using MVVMFrameworkDotNet9.ViewModels;
using MVVMFrameworkDotNet9.Views;

namespace MVVMFrameworkDotNet9;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<IDemoService, DemoService>();

        builder.Services.AddTransient<DemoViewModel>();
        builder.Services.AddTransient<DemoView>();

        return builder.Build();
    }
}
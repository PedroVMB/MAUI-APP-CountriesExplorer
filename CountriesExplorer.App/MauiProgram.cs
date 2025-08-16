using CountriesExplorer.App.ViewModels;
using CountriesExplorer.App.Views;
using CountriesExplorer.Core.Interfaces;
using CountriesExplorer.Services;
using Microsoft.Extensions.Logging;

namespace CountriesExplorer.App;

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
        
        //Services
        builder.Services.AddSingleton<HttpClient>();
        builder.Services.AddSingleton<ICountryService, CountryService>();

        // ViewModels e Pages
        builder.Services.AddTransient<CountriesViewModel>();
        builder.Services.AddTransient<CountriesPage>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
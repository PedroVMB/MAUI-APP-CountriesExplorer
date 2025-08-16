using CountriesExplorer.App.Views;

namespace CountriesExplorer.App;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(nameof(CountryDetailPage), typeof(Views.CountryDetailPage));
    }
}
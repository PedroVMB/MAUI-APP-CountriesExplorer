namespace CountriesExplorer.App;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new Views.SplashScreen();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountriesExplorer.App.Views;

public partial class SplashScreen : ContentPage
{
    public SplashScreen()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();

        // Espera 3 segundos
        await Task.Delay(3000);

        // Navega para a página inicial
        Application.Current.MainPage = new AppShell();
    }
}
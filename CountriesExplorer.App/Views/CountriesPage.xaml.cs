using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountriesExplorer.App.ViewModels;
using CountriesExplorer.Core.Models;

namespace CountriesExplorer.App.Views;

public partial class CountriesPage : ContentPage
{
    private CountriesViewModel ViewModel => BindingContext as CountriesViewModel;

    public CountriesPage(CountriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        ViewModel.LoadCountriesCommand.Execute(null);
    }

    private async void OnCountrySelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Core.Models.Country selectedCountry)
        {
            var navigationParameter = new Dictionary<string, object>
            {
                { "Country", selectedCountry }
            };

            await Shell.Current.GoToAsync(nameof(CountryDetailPage), navigationParameter);
        }
    }
}
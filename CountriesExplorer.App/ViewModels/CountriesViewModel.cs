using System.Collections.ObjectModel;
using CountriesExplorer.App.ViewModels.Base;
using CountriesExplorer.Core.Interfaces;
using CountriesExplorer.Core.Models;

namespace CountriesExplorer.App.ViewModels;

public class CountriesViewModel : BaseViewModel
{
    private readonly ICountryService _countryService;
    public ObservableCollection<Country> Countries { get; }
    public bool IsBusy { get; set; }

    public CountriesViewModel(ICountryService countryService)
    {
        _countryService = countryService;
        LoadCountriesCommand = new Command(async () => await LoadCountriesAsync());
    }

    public Command LoadCountriesCommand { get; }

    private async Task LoadCountriesAsync()
    {
        if (IsBusy) return;
        IsBusy = true;
        try
        {
            Countries.Clear();
            var countries = await _countryService.GetAllCountriesAsync();
            foreach (var country in countries)
                Countries.Add(country);
        }
        finally
        {
            IsBusy = false;
        }

    }
}
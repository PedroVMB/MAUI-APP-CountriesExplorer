using CountriesExplorer.App.ViewModels.Base;
using CountriesExplorer.Core.Models;

namespace CountriesExplorer.App.ViewModels;

public class CountryDetailViewModel : BaseViewModel
{
    private Country _country = null!;
    public Country Country
    {
        get => _country;
        set { _country = value; OnPropertyChanged(); }
    }

    public CountryDetailViewModel(Country country)
    {
        Country = country;
    }
}
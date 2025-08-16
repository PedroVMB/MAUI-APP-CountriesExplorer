using CountriesExplorer.Core.Models;

namespace CountriesExplorer.App.ViewModels.Base;

public class CountryDetailViewModel(Country country) : BaseViewModel
{
    public Country Country { get; } = country;

    public string CapitalDisplay =>
        Country?.Capital != null && Country.Capital.Length > 0 ? Country.Capital[0] : "N/A";

    public string CurrencyDisplay =>
        Country?.Currencies != null && Country.Currencies.Count > 0
            ? string.Join(", ", Country.Currencies.Keys)
            : "N/A";
}
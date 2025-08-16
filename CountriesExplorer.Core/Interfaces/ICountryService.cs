using CountriesExplorer.Core.Models;

namespace CountriesExplorer.Core.Interfaces;

public interface ICountryService
{
    Task<IEnumerable<Country>?> GetAllCountriesAsync();
}
using System.Net.Http.Json;
using CountriesExplorer.Core.Interfaces;
using CountriesExplorer.Core.Models;

namespace CountriesExplorer.Services;

public class CountryService : ICountryService
{
    private readonly HttpClient httpClient;

    public CountryService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");
    }
    
    public async Task<IEnumerable<Country>?> GetAllCountriesAsync()
    {
        return await httpClient.GetFromJsonAsync<IEnumerable<Country>>("all?fields=name,capital,region,currencies,flags");
    }
}
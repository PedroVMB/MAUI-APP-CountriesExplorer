using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CountriesExplorer.App.ViewModels;
using CountriesExplorer.App.ViewModels.Base;
using CountriesExplorer.Core.Models;

namespace CountriesExplorer.App.Views;

[QueryProperty(nameof(Country), "Country")]
public partial class CountryDetailPage : ContentPage
{
    private Country _country;
    public Country Country
    {
        get => _country;
        set
        {
            _country = value;
            BindingContext = new CountryDetailViewModel(value);
        }
    }

    public CountryDetailPage()
    {
        InitializeComponent();
    }
}

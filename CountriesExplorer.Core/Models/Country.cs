namespace CountriesExplorer.Core.Models;

public class Country
{
    public Name Name { get; set; }
    public string[] Capital { get; set; }
    public string Region { get; set; }
    public Dictionary<string, Currency> Currencies { get; set; }
    public Flags Flags { get; set; }
}

public class Name
{
    public string Common { get; set; }
    public string Official { get; set; }
}

public class Currency
{
    public string Name { get; set; }
    public string Symbol { get; set; }
}

public class Flags
{
    public string Png { get; set; }
    public string Svg { get; set; }
}
using System.Globalization;
using ServerApp.Data;

namespace ServerApp;

public class LocalizationFactory2 : ILocalizationFactory2
{
    private readonly List<IDataSource2> _sources = new ();

    public string? GetString(string code, CultureInfo? culture)
    {
        culture ??= CultureInfo.CurrentCulture;

        string? localizedString = null;

        foreach (var source in _sources.Where(source => source.Culture.Equals(culture)))
        {
            localizedString = source.GetString(code);
            if (localizedString != null) break;
        }
        
        return localizedString;
    }

    public void RegisterSource(IDataSource2 source)
    {
        _sources.Add(source);
    }
}
using System.Globalization;
using ServerApp.Data;

namespace ServerApp;

public class LocalizationFactory : ILocalizationFactory
{
    private readonly List<IDataSource> _sources = new ();

    public string? GetString(string code, CultureInfo? culture)
    {
        culture ??= CultureInfo.CurrentCulture;

        string? localizedString = null;

        foreach (var source in _sources)
        {
            localizedString = source.GetString(code, culture);
            if (localizedString != null)
            {
                break;
            }
        }
        
        return localizedString;
    }

    public void RegisterSource(IDataSource source)
    {
        _sources.Add(source);
    }
}
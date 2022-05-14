using System.Globalization;
using ServerApp.Data;

namespace ServerApp;

public class LocalizationFactory : ILocalizationFactory
{
    private readonly List<IDataSource> _sources = new ();

    public string? GetString(string code, CultureInfo? culture = null)
    {
        culture ??= CultureInfo.CurrentCulture;

        var localizedString = _sources.FirstOrDefault(s => s.CheckIfCultureSupported(culture))?.GetString(code, culture);
        
        return localizedString;
    }

    public void RegisterSource(IDataSource source)
    {
        _sources.Add(source);
    }
}
using System.Globalization;

namespace ServerApp;

public interface ILocalizationFactory
{
    string? GetString(string code, CultureInfo culture);
}
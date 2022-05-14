using System.Globalization;
using ServerApp.Data;

namespace ServerApp;

public interface ILocalizationFactory2
{
    string? GetString(string code, CultureInfo culture);
    void RegisterSource(IDataSource2 source);
}
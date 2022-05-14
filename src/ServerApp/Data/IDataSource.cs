using System.Globalization;

namespace ServerApp.Data;

public interface IDataSource
{
    string? GetString(string name, CultureInfo culture);
    bool CheckIfCultureSupported(CultureInfo culture);
}
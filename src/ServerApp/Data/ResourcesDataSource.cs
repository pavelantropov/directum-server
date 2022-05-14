using System.Globalization;
using ServerApp.Properties;

namespace ServerApp.Data;

public class ResourcesDataSource : IDataSource
{
    public string? GetString(string name, CultureInfo culture) =>
        Resources.ResourceManager.GetString(name, culture);
}
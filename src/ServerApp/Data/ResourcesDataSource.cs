using System.Globalization;
using ServerApp.Properties;

namespace ServerApp.Data;

public class ResourcesDataSource : IDataSource
{
    public string? GetString(string name, CultureInfo culture) =>
        Resources.ResourceManager.GetResourceSet(culture, true, false)?.GetString(name);

    public bool CheckIfCultureSupported(CultureInfo culture) =>
        Resources.ResourceManager.GetResourceSet(culture, true, false) != null;
}
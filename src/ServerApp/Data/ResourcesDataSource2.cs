using System.Globalization;
using ServerApp.Properties;

namespace ServerApp.Data;

public class ResourcesDataSource2 : IDataSource2
{
    public CultureInfo Culture { get; set; } = CultureInfo.InvariantCulture;

    public string? GetString(string name) =>
        Resources.ResourceManager.GetString(name, Culture);
}
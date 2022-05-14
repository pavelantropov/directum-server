using System.Globalization;

namespace ServerApp.Data;

public interface IDataSource2
{
    CultureInfo Culture { get; set; }

    string? GetString(string name);
}
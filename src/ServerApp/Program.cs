using System.Globalization;
using ServerApp;
using ServerApp.Data;

// Change these the way you need
const string code = "hello";
var cultures = new[]
{
    CultureInfo.InvariantCulture,
    CultureInfo.GetCultureInfo("es-ES"),
    CultureInfo.GetCultureInfo("fr-FR")
};

var factory = new LocalizationFactory();

// Register the sources
factory.RegisterSource(new ResourcesDataSource());

// Print the results
foreach (var culture in cultures)
{
    Console.WriteLine($@"{culture.EnglishName}: {factory.GetString(code, culture)}");
}

Console.ReadKey();

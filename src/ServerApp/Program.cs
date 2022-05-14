using System.Globalization;
using ServerApp;
using ServerApp.Data;

var factory = new LocalizationFactory();

// Register the sources
factory.RegisterSource(new ResourcesDataSource());

// Change these the way you need
const string code = "hello";
var culture = CultureInfo.InvariantCulture;

Console.WriteLine(factory.GetString(code, culture));
Console.ReadKey();

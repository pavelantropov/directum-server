using System.Globalization;
using ServerApp;
using ServerApp.Data;

// Change these the way you need
const string code = "hello";
var culture = CultureInfo.GetCultureInfo("es-ES");

var factory = new LocalizationFactory();

// Register the sources
factory.RegisterSource(new ResourcesDataSource());

Console.WriteLine($@"1: {factory.GetString(code, culture)}");
Console.ReadKey();

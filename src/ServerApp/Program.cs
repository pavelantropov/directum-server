using System.Globalization;
using ServerApp;
using ServerApp.Data;

// Change these the way you need
const string code = "hello";
var cultureEn = CultureInfo.InvariantCulture;
var cultureEs = CultureInfo.GetCultureInfo("es-ES");
var cultureFr = CultureInfo.GetCultureInfo("fr-FR");

var factory = new LocalizationFactory();

// Register the sources
factory.RegisterSource(new ResourcesDataSource());

Console.WriteLine($@"{cultureEn.EnglishName}: {factory.GetString(code, cultureEn)}");
Console.WriteLine($@"{cultureEs.EnglishName}: {factory.GetString(code, cultureEs)}");
Console.WriteLine($@"{cultureFr.EnglishName}: {factory.GetString(code, cultureFr)}");
Console.ReadKey();

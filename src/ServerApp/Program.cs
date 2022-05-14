using System.Globalization;
using ServerApp;
using ServerApp.Data;

// Change these the way you need
const string code = "hello";
var culture = CultureInfo.InvariantCulture;

var factory1 = new LocalizationFactory();
var factory2 = new LocalizationFactory2();

// Register the sources
factory1.RegisterSource(new ResourcesDataSource());
factory2.RegisterSource(new ResourcesDataSource2 { Culture = culture });

Console.WriteLine($@"1: {factory1.GetString(code, culture)}");
Console.WriteLine($@"2: {factory2.GetString(code, culture)}");
Console.ReadKey();

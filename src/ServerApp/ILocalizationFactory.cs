﻿using System.Globalization;
using ServerApp.Data;

namespace ServerApp;

public interface ILocalizationFactory
{
    string? GetString(string code, CultureInfo culture);
    void RegisterSource(IDataSource source);
}
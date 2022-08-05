// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public static class Helpers
{
    public static ClangScraper CreateScraper()
    {
        var configuration = new ConfigurationBuilder()
            .AddEnvironmentVariables(source => source.Prefix = "SILK_DOTNET_")
            .Build();
        var serviceProvider = new ServiceCollection()
            .AddLogging(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Trace);
                }
            )
            .Configure<ClangScraperConfiguration>(configuration.GetSection("Scraper"))
            .BuildServiceProvider();

        return ActivatorUtilities.CreateInstance<ClangScraper>(serviceProvider);
    }
}

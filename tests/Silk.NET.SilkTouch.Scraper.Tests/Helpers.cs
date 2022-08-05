// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Symbols;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public static class Helpers
{
    private static IServiceProvider CreateServiceProvider()
    {
        return new ServiceCollection()
            .AddLogging(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Trace);
                }
            )
            .BuildServiceProvider();
    }
    
    public static ClangScraper CreateScraper()
    {
        var serviceProvider = CreateServiceProvider();

        return new ClangScraper(serviceProvider.GetRequiredService<ILoggerFactory>());
    }
}

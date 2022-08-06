// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace Silk.NET.SilkTouch.TypeResolution.Tests;

public class Helpers
{
    public static IServiceProvider CreateServiceProvider()
    {
        var serviceProvider = new ServiceCollection()
            .AddLogging(builder =>
                {
                    builder.AddConsole();
                    builder.SetMinimumLevel(LogLevel.Trace);
                }
            )
            .BuildServiceProvider();

        return serviceProvider;
    }
}

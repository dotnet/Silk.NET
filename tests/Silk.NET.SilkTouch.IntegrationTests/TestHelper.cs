// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Data;
using System.IO;
using System.Linq;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Scraper;
using Silk.NET.SilkTouch.Symbols;
using Silk.NET.SilkTouch.TypeResolution;
using Xunit;

namespace Silk.NET.SilkTouch.IntegrationTests;

public static class TestHelper
{
    public static string GetCSharpOutputFromCpp(string cpp)
    {
        var tempFile = Path.GetTempFileName();
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
        
        File.WriteAllText(tempFile, "/* THIS IS A GENERATED FILE, PIPED TO CLANG FOR TESTING BY SILK.NET */" + cpp);

        var scraper = ActivatorUtilities.CreateInstance<ClangScraper>(serviceProvider);
        var defaultIncludes = scraper.ResolveStandardIncludes().ToArray();
        var xml = scraper.GenerateXML
            (tempFile, Array.Empty<string>(), Array.Empty<string>(), defaultIncludes, Array.Empty<string>());
        
        try
        {
            File.Delete(tempFile);
        } catch { /* It's a Temporary File. We dont' care. */}

        Assert.NotNull(xml);

        var typeStore = new TypeStore();
        var symbols = scraper.ScrapeXML(xml!, typeStore).ToArray();

        var typeScopeSymbolVisitor = ActivatorUtilities.CreateInstance<TypeScopeSymbolVisitor>(serviceProvider, typeStore);
        var processors = new SymbolVisitor[]
        {
            ActivatorUtilities.CreateInstance<PointerTypeResolver>(serviceProvider, typeStore),
            ActivatorUtilities.CreateInstance<FunctionPointerTypeResolver>(serviceProvider, typeStore),
            ActivatorUtilities.CreateInstance<PrimitiveTypeResolver>(serviceProvider, typeStore),

            typeScopeSymbolVisitor,
            ActivatorUtilities.CreateInstance<NameResolverSymbolVisitor>
                (serviceProvider, typeScopeSymbolVisitor.RootScope, typeStore)
        };

        foreach (var processor in processors)
        {
            symbols = symbols.Select(processor.Visit).ToArray();
        }

        var emitter = new CSharpEmitter();
        var outputs = symbols.Select(x => emitter.Transform(x, typeStore));
        return outputs.Aggregate
        (
            "",
            (old, node) => old + "\n\n/* -------------------------- NEW OUTPUT -------------------------- */\n\n" +
                           node.ToFullString()
        );
    }
}

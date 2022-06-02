// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Silk.NET.SilkTouch.Emitter;
using Silk.NET.SilkTouch.Scraper;
using Xunit;

namespace Silk.NET.SilkTouch.IntegrationTests;

public static class TestHelper
{
    public static string GetCSharpOutputFromCpp(string cpp)
    {
        var tempFile = Path.GetTempFileName();
        
        File.WriteAllText(tempFile, "/* THIS IS A GENERATED FILE, PIPED TO CLANG FOR TESTING BY SILK.NET */" + cpp);

        var scraper = new ClangScraper();
        var xml = scraper.GenerateXML
            (tempFile, Array.Empty<string>(), Array.Empty<string>(), Array.Empty<string>(), Array.Empty<string>());

        Assert.NotNull(xml);
        
        try
        {
            File.Delete(tempFile);
        } catch { /* It's a Temporary File. We dont' care. */}

        var symbols = scraper.ScrapeXML(xml!);
        var emitter = new CSharpEmitter();
        var outputs = symbols.Select(x => emitter.Transform(x));
        return outputs.Aggregate
        (
            "",
            (old, node) => old + "\n\n/* -------------------------- NEW OUTPUT -------------------------- */\n\n" +
                           node.ToFullString()
        );
    }
}

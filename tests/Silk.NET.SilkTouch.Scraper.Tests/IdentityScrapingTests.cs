// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class IdentityScrapingTests
{
    [Fact,
     Trait("Category", "Scraper")]
    public void GeneratesNoSymbols()
    {
        var doc = new XmlDocument();

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        Assert.Empty(symbols);
    }

    [Fact,
     Trait("Category", "Scraper")]
    public void BindingsGeneratesNoSymbols()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
</bindings>
");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        Assert.Empty(symbols);
    }
}
       

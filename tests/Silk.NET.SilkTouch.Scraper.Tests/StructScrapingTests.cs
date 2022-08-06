// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class StructScrapingTests
{
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Structs")]
    public void StructSymbol()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<struct name=""Test""></struct>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var @struct = Assert.IsType<StructSymbol>(symbol);
    }
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Structs")]
    public void CorrectIdentifier()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<struct name=""Test""></struct>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var @struct = Assert.IsType<StructSymbol>(symbol);
        Assert.Equal("Test", @struct.Identifier.Value);
    }
}

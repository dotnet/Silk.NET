// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Linq;
using System.Xml;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class IdentityScrapingTests
{
    [Fact]
    public void EmptyXmlGeneratesNoSymbols()
    {
        var doc = new XmlDocument();

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        Assert.Empty(symbols);
    }

    [Fact]
    public void EmptyBindingsXmlGeneratesNoSymbols()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
</bindings>
");

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        Assert.Empty(symbols);
    }
}
       

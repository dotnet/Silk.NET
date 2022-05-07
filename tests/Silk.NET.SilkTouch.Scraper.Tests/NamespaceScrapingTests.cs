// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class NamespaceScrapingTests
{
    [Fact]
    public void NamespaceXMLGeneratesNamespaceSymbol()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
    <namespace name=""" + ClangScraper.LibraryNamespacePlaceholder + @""">
    </namespace>
</bindings>
");

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        var symbol = Assert.Single(symbols);
        var @namespace = Assert.IsType<NamespaceSymbol>(symbol);
        Assert.Equal(ClangScraper.LibraryNamespacePlaceholder, @namespace.Identifier.Value);
    }
}

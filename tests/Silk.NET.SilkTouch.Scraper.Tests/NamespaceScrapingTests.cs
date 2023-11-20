// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class NamespaceScrapingTests
{
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Namespaces")]
    public void NamespaceSymbol()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
    <namespace name=""" + ClangScraper.LibraryNamespacePlaceholder + @""">
    </namespace>
</bindings>
");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var @namespace = Assert.IsType<NamespaceSymbol>(symbol);
        Assert.Equal(ClangScraper.LibraryNamespacePlaceholder, @namespace.Identifier.Value);
    }
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Namespaces")]
    public void NamespaceMember()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
    <namespace name=""" + ClangScraper.LibraryNamespacePlaceholder + @""">
        <struct name=""Test"">
        </struct>
    </namespace>
</bindings>
");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var @namespace = Assert.IsType<NamespaceSymbol>(symbol);
        var structSymbol = Assert.Single(@namespace.Types);
        var @struct = Assert.IsType<StructSymbol>(structSymbol);
        Assert.Equal("Test", @struct.Identifier.Value);
    }
    
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Namespaces")]
    public void MultipleNamespaceMembers()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<bindings>
    <namespace name=""" + ClangScraper.LibraryNamespacePlaceholder + @""">
        <struct name=""Test1"">
        </struct>
        <struct name=""Test2"">
        </struct>
    </namespace>
</bindings>
");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var @namespace = Assert.IsType<NamespaceSymbol>(symbol);
        Assert.Collection(@namespace.Types,
            (s) => Assert.Equal("Test1", Assert.IsType<StructSymbol>(s).Identifier.Value),
            (s) => Assert.Equal("Test2", Assert.IsType<StructSymbol>(s).Identifier.Value));
    }
}

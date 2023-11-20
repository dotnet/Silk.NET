// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Scraper.Annotations;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class FieldScrapingTests
{
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Fields")]
    public void FieldSymbol()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
    }
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Fields")]
    public void CorrectIdentifier()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
        Assert.Equal("f2", field.Identifier.Value);
    }
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Fields")]
    public void CorrectType()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
        var type = Assert.IsType<UnresolvedTypeReference>(field.Type);
        Assert.Equal("int", type.Text);
        Assert.Equal("int32_t", Assert.IsType<NativeNameAnnotation>(Assert.Single(type.Annotations)).NativeName);
    }
}

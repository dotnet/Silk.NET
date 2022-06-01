// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class FieldScrapingTests
{
    [Fact]
    public void FieldSymbol()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
    }
    
    [Fact]
    public void CorrectIdentifier()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
        Assert.Equal("f2", field.Identifier.Value);
    }
    
    [Fact]
    public void CorrectType()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<field name=""f2""><type native=""int32_t"">int</type></field>");

        var symbols = new ClangScraper().ScrapeXML(doc);
        
        var symbol = Assert.Single(symbols);
        var field = Assert.IsType<FieldSymbol>(symbol);
        Assert.Equal("int", field.Type.Identifier.Value);
    }
}

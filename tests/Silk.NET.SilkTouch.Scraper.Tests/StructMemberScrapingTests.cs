// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Xml;
using Silk.NET.SilkTouch.Symbols;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class StructMemberScrapingTests
{
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public void SingleMember()
    {
        var doc = new XmlDocument();
        doc.LoadXml(@"<struct name=""Test""><field name=""f1""><type native=""int32_t"">int</type></field></struct>");

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());

        var symbol = Assert.Single(symbols);
        var @struct = Assert.IsType<StructSymbol>(symbol);
        var fields = @struct.Members;
        Assert.Collection(fields, 
            (e) =>
            {
                Assert.Equal("f1", e.Identifier.Value);
            }
        );
    }

    [Fact,
     Trait("Category", "Scraper"),
     Trait("Feature", "Structs"),
     Trait("Feature", "Fields")]
    public void MultipleMembers()
    {
        var doc = new XmlDocument();
        doc.LoadXml
        (
            @"<struct name=""Test""><field name=""f1""><type native=""int32_t"">int</type></field><field name=""f2""><type native=""int32_t"">int</type></field></struct>"
        );

        var symbols = Helpers.CreateScraper().ScrapeXML(doc, new TypeStore());

        var symbol = Assert.Single(symbols);
        var @struct = Assert.IsType<StructSymbol>(symbol);
        var fields = @struct.Members;
        Assert.Collection(fields, 
            (e) =>
            {
                Assert.Equal("f1", e.Identifier.Value);
            }, 
            (e) =>
            {
                Assert.Equal("f2", e.Identifier.Value);
            }
        );
    }
}

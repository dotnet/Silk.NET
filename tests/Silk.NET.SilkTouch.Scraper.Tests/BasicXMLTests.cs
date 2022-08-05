using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using System.Xml;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class BasicXMLTests
{
    /*
     * NOTE:
     * MOST OF THE FUNCTIONALITY TESTED HERE REALLY DEPENDS ON CLANG(SHARP).
     * THEREFORE IT IS UNNECESSARY TO TEST IT AS DETAILED AS OTHER PARTS OF THIS SYSTEM.
     * ONLY CREATE TESTS HERE IF THERE IS AN ISSUE IN OUR SYSTEM THAT YOU NEED TO TRACK DOWN
     * DO NOT JUST CREATE TESTS TO TEST CLANGSHARP.
     * IF THERE ARE ISSUES WITH THE XML NOT REFLECTING PART OF A HEADER:
     * 1. CHECK OUR CONFIGURATION. ITS FAIRLY SIMPLE AND BAREBONES.
     * 2. IF 1. DID NOT RESOLVE THE PROBLEM, RAISE WITH CLANGSHARP/CLANG INSTEAD.
     * WE DO NOT WANT TO REWRITE THE XML IN ANY WAY.
     */
    
    
    private const string TempFileHeader = @"/* This file is temporarily created for use by Silk.NET tests. If you don't intend to run such a test, feel free to delete this file. */";
    
    
    [Fact,
     Trait("Category", "Scraper"),
     Trait("Source Language", "C++")]
    public void BasicStructScrapingTest()
    {
        var tempFile = Path.GetTempFileName();
        
        File.WriteAllText(tempFile, TempFileHeader + @"
#include <stdint.h>

typedef struct {
    int32_t f1;
    int32_t f2;
} Test;");

        var scraper = Helpers.CreateScraper();
        var defaultIncludes = scraper.ResolveStandardIncludes().ToArray();
        var xml = scraper.GenerateXML
            (tempFile, Array.Empty<string>(), Array.Empty<string>(), defaultIncludes, Array.Empty<string>());

        /*
         Next, Assert the XML looks something like this:
<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>
<bindings>
    <namespace name="<PLACEHOLDER>">
        <struct name="Test">
            <field name="f1">
                <type native="int32_t">int</type>
            </field>
            <field name="f2">
                <type native="int32_t">int</type>
            </field>
        </struct>
        </namespace>
</bindings>
         */
        
        Assert.NotNull(xml);
        // Root
        Assert.Collection(xml!.ChildNodes.Cast<XmlNode>(), 
            static dec => Assert.IsType<XmlDeclaration>(dec), // Top Declaration 
            static bindings => // Root Bindings Element
            {
                var e = Assert.IsType<XmlElement>(bindings);
                Assert.Equal("bindings", e.LocalName);
                Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // namespaces
                    static @namespace =>
                {
                    var e = Assert.IsType<XmlElement>(@namespace);
                    var nameAtt = e.Attributes["name"];
                    Assert.NotNull(nameAtt);
                    Assert.Equal(ClangScraper.LibraryNamespacePlaceholder, nameAtt!.Value);
                    
                    Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // namespace members 
                        static @struct =>
                    {
                        var e = Assert.IsType<XmlElement>(@struct);
                        var nameAtt = e.Attributes["name"];
                        Assert.NotNull(nameAtt);
                        Assert.Equal("Test", nameAtt!.Value);
                        
                        Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // struct members
                            static field =>
                        {
                            var e = Assert.IsType<XmlElement>(field);
                            var nameAtt = e.Attributes["name"];
                            Assert.NotNull(nameAtt);
                            Assert.Equal("f1", nameAtt!.Value);
                            
                            Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // field infos 
                                static type =>
                            {
                                var e = Assert.IsType<XmlElement>(type);
                                var nativeAtt = e.Attributes["native"];
                                Assert.NotNull(nativeAtt);
                                Assert.Equal("int32_t", nativeAtt!.Value);
                                
                                Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // unwrap converted type
                                    static type =>
                                {
                                    var e = Assert.IsType<XmlText>(type);
                                    Assert.Equal("int", e.Value);
                                });
                            });
                        }, static field =>
                        {
                            var e = Assert.IsType<XmlElement>(field);
                            var nameAtt = e.Attributes["name"];
                            Assert.NotNull(nameAtt);
                            Assert.Equal("f2", nameAtt!.Value);
                            
                            Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // field infos
                                static type =>
                            {
                                var e = Assert.IsType<XmlElement>(type);
                                var nativeAtt = e.Attributes["native"];
                                Assert.NotNull(nativeAtt);
                                Assert.Equal("int32_t", nativeAtt!.Value);
                                
                                Assert.Collection(e.ChildNodes.Cast<XmlNode>(), // unwrap converted type
                                    static type =>
                                {
                                    var e = Assert.IsType<XmlText>(type);
                                    Assert.Equal("int", e.Value);
                                });
                            });
                        });
                    });
                });
            });
    }
}

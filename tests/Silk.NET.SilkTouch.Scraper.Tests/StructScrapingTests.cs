using System;
using System.ComponentModel;
using System.IO;
using Xunit;

namespace Silk.NET.SilkTouch.Scraper.Tests;

public class StructScrapingTests
{
    private const string TempFileHeader = @"// This file is temporarily created for use by Silk.NET tests. If you don't intend to run such a test, feel free to delete this file.";
    
    
    [Fact]
    public void BasicStructScrapingTest()
    {
        var tempFile = Path.GetTempFileName();
        
        File.WriteAllText(tempFile, TempFileHeader + @"
struct Test
{
    int f1;
    int f2;
};");
        
        var scraper = new ClangScraper();
        var symbols = scraper.Scrape
            (tempFile, Array.Empty<string>(), Array.Empty<string>(), Array.Empty<string>(), Array.Empty<string>());
    }
}

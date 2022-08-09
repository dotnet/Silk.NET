# Scraper

The scraper calls into clang to generate XML and can scrape this XML for Symbols of the [Symbol Layer](./symbol-layer/README.md)

## Scraping XML

To scrape XML there is a visitor that visits each XML node and outputs several symbols per node.
This is what happens in `XmlVisitor.cs`

## Generating XML using clang

This is what happens in `ClangScraper.cs`, which is configured using `ClangScraperConfiguration.cs`
Check XML docs for details on what methods do.

# Scraper

The scraper calls into clang to generate XML and can scrape this XML for Symbols of the [Symbol Layer](./symbol-layer/README.md)

## Scraping XML

To scrape XML there is a visitor that visits each XML node and outputs several symbols per node.

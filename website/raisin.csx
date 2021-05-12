#package HtmlAgilityPack 1.11.13

await Raisin
    .WithInputDirectory(".")
    .WithOutputDirectory("../docs")
    .WithRazorRoot("_theme/src/00-root.cshtml")
    .WithDirectoryCopy("_theme/lib", "theme")
    .WithDirectoryCopy("images")
    .WithInnerHtml("index.html")
    .WithMarkdown()
    .WithTableOfContents()
    .WithForceCleanOutput()
    .GenerateAsync(); 

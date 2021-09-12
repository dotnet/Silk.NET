// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.Statiq.TableOfContents.ProcessModules;
using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Markdown;
using Statiq.Razor;
using Statiq.Yaml;
using Ultz.Extensions.Logging;

namespace Silk.NET.Statiq;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        return await Bootstrapper.Factory
            .CreateDefault(args)
            .ConfigureFileSystem
            (
                x =>
                {
                    x.InputPaths.Clear();
                    x.InputPaths.Add("../../../website");
                    x.OutputPath = "../../../docs";
                }
            )
            .BuildPipeline
            (
                "DirectCopying",
                builder => builder.WithInputReadFiles()
                    .WithProcessModules
                    (
                        new CopyFiles("_theme/lib/**/*").To
                        (
                            x => Task.FromResult
                            (
                                "theme" /
                                new NormalizedPath("_theme/lib").GetRelativePath(x.Path.GetRelativeInputPath())
                            )
                        ),
                        new CopyFiles("images/**/*")
                    )
            )
            .BuildPipeline
            (
                "FrontMatter",
                x => x.WithInputReadFiles("**/*.cshtml", "!_theme/**/*.cshtml", "**/*.md", "!_*.cshtml")
                    .WithProcessModules((IModule) new ExtractFrontMatter(new ParseYaml()))
            )
            .BuildPipeline
            (
                "Markdown",
                x => x.WithDependencies("FrontMatter")
                    .WithProcessModules(new FilterSources("**/*.md"), new RenderMarkdown())
            )
            .BuildPipeline
            (
                "Razor",
                x => x.WithDependencies("Markdown", "FrontMatter")
                    .WithInputReadFiles("_*.cshtml", "**/toc.json")
                    .WithProcessModules
                    (
                        //new AddTableOfContents("**/toc.json"),
                        new LoadRawToc("**/toc.json"),
                        new BakeTocModels(),
                        new BakeTocIntoDocuments(),
                        new RenderRazor()
                    )
                    .WithOutputWriteFiles(".html")
            )
            .RunAsync();
    }
}

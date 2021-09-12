// See https://aka.ms/new-console-template for more information

using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Silk.NET.Statiq;
using Silk.NET.Statiq.TableOfContents.ProcessModules;
using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Markdown;
using Statiq.Razor;
using Statiq.Yaml;

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
                "Static",
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
                "Content",
                x => x.WithInputReadFiles("{**,!_theme/**}/*.cshtml", "**/*.md", "**/toc.json")
                    .WithProcessModules
                    (
                        new ExtractFrontMatter(new ParseYaml()),
                        new ForAllMatching()
                            .WithFilterPatterns("**/*.md")
                            .WithExecuteModules(new RenderMarkdown()),
                        new AddTableOfContents
                        (
                            (tocPath, docPath) => tocPath == docPath.ChangeExtension(".html"),
                            "**/toc.json"
                        ),
                        new RenderRazor()
                    )
                    .WithOutputWriteFiles(".html")
            )
            .RunAsync();
    }
}

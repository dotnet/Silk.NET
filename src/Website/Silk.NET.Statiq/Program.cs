// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Threading.Tasks;
using Silk.NET.Statiq;
using Silk.NET.Statiq.TableOfContents.ProcessModules;
using Statiq.App;
using Statiq.Common;
using Statiq.Core;
using Statiq.Feeds;
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
                        new ExtractFrontMatter(new ParseJson()),
                        new ForAllMatching().WithFilterPatterns("**/*.md").WithExecuteModules(new RenderMarkdown()),
                        new AddTableOfContents
                        (
                            (tocPath, docPath) => tocPath == docPath.ChangeExtension(".html"),
                            "**/toc.json"
                        ),
                        new RenderRazor(),
                        new ProcessShortcodes(),
                        new SetDestination(".html"),
                        new ForAllMatching(true)
                            .WithFilterPatterns("blog/{**/*,!index.cshtml}")
                            .WithExecuteModules
                            (
                                new GenerateFeeds()
                                    .WithItemLink
                                    (
                                        Config.FromDocument
                                        (
                                            (y, z)
                                                => new Uri(new("https://dotnet.github.io/Silk.NET"), z.GetLink(y, true))
                                        )
                                    )
                                    .WithAtomPath("blog/feed.atom")
                                    .WithRssPath("blog/feed.rss")
                                    .WithFeedTitle("Silk.NET Blog")
                                    .WithFeedAuthor(".NET Foundation and Contributors")
                                    .WithFeedCopyright
                                    (
                                        $"Copyright (C) {DateTime.UtcNow.Year} .NET Foundation and Contributors"
                                    )
                            )
                    )
                    .WithOutputWriteFiles()
            )
            .AddShortcode<FancyImageShortCode>("FancyImage")
            .AddShortcode<CaptionShortCode>("Caption")
            .AddShortcode<InfoShortCode>("Info")
            .AddShortcode<WarningShortCode>("Warning")
            .RunAsync();
    }
}

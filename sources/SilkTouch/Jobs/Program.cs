// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Silk.NET.SilkTouch.Jobs;

internal static class Program
{
    // ClangScrapers's output is not platform-independent,
    // so for consistency the scraped set of bindings are locked to one platform (usually Windows)
    // You'll see this set as the ScrapeIf option for ClangScraper

    public static Task Main(string[] args) =>
        SilkTouchHost
            .Create()
            .DefineMicrosoftJob()
            .DefineOpenALJob()
            .DefineOpenCLJob()
            .DefineOpenGLJob()
            .DefineOpenXRJob()
            .DefineSDLJob()
            .DefineVulkanJob()
            .RunAsync(args);
}

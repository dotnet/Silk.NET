// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    [Parameter("The API key used to push packages and symbols packages to NuGet")] readonly string NugetApiKey;
    [Parameter("NuGet -NoServiceEndpoint")] readonly bool NugetNoServiceEndpoint;
    [Parameter("NuGet feed")] readonly string NugetFeed = "https://api.nuget.org/v3/index.json";
    [Parameter("NuGet username")] readonly string NugetUsername;
    [Parameter("NuGet password")] readonly string NugetPassword;
    static string PackageDirectory => RootDirectory / "build" / "output_packages";

    static IEnumerable<string> Packages => Directory.GetFiles(PackageDirectory, "*.nupkg")
        .Where(x => Path.GetFileName(x).StartsWith("Silk.NET") || Path.GetFileName(x).StartsWith("Ultz.Native"));

    static IEnumerable<string> SymbolPackages => Directory.GetFiles(PackageDirectory, "*.snupkg")
        .Where(x => Path.GetFileName(x).StartsWith("Silk.NET") || Path.GetFileName(x).StartsWith("Ultz.Native"));

    Target PushToNuGet => CommonTarget
    (
        x => x.DependsOn(Pack)
            .After(SignPackages)
            .Executes(PushPackages)
    );

    async Task<IEnumerable<Output>> PushPackages()
    {
        var outputs = Enumerable.Empty<Output>();
        const int rateLimit = 300;

        var allFiles = Packages.Concat(SymbolPackages)
            .Select((x, i) => new { Index = i, Value = x })
            .GroupBy(x => x.Index / rateLimit)
            .Select(x => x.Select(v => v.Value).ToList())
            .ToList();
        var first = true;
        Log.Information($"Searching for packages in \"{RootDirectory / "build" / "output_packages"}\"...");
        foreach (var files in allFiles)
        {
            if (first)
            {
                first = false;
            }
            else
            {
                await Task.Delay(TimeSpan.FromHours(1));
            }

            if (!NugetFeed.Contains("nuget.org"))
            {
                var srcSettings = new DotNetNuGetAddSourceSettings().SetName("Silk-PushPackages").SetSource(NugetFeed);

                if (NugetUsername is not null || NugetPassword is not null)
                {
                    if (NugetUsername is null || NugetPassword is null)
                    {
                        Assert.Fail
                        (
                            "Both \"NugetUsername\" and \"NugetPassword\" must be specified if either are used."
                        );
                    }

                    srcSettings = srcSettings.SetUsername(NugetUsername).SetPassword(NugetPassword).SetStorePasswordInClearText(true);
                }

                outputs = outputs.Concat(DotNetNuGetAddSource(srcSettings));
            }

            foreach (var pushSettings in files.Select
            (
                file =>
                {
                    var x = new DotNetNuGetPushSettings()
                        .SetNoServiceEndpoint(NugetNoServiceEndpoint)
                        .EnableSkipDuplicate()
                        .SetSource(NugetFeed.Contains("nuget.org") ? "nuget.org" : "Silk-PushPackages")
                        .SetTargetPath(file);
                    if (NugetApiKey is not null)
                    {
                        x = x.SetApiKey(NugetApiKey);
                    }

                    return x;
                }
            ))
            {
                outputs = outputs.Concat(DotNetNuGetPush(pushSettings));
            }

            if (!NugetFeed.Contains("nuget.org"))
            {
                outputs = outputs.Concat(DotNet("dotnet nuget remove source \"Silk-PushPackages\""));
            }
        }

        return outputs;
    }
}

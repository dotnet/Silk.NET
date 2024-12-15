// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;

partial class Build
{
    const string TemporaryNuGetFeed = "Silk-PushPackages";

    [Parameter("The API key used to push packages and symbols packages to NuGet")]
    readonly string? NugetApiKey;

    [Parameter("NuGet -NoServiceEndpoint")]
    readonly bool NugetNoServiceEndpoint;

    [Parameter("NuGet feed")]
    readonly string NugetFeed = "https://api.nuget.org/v3/index.json";

    [Parameter("NuGet username")]
    readonly string? NugetUsername;

    [Parameter("NuGet password")]
    readonly string? NugetPassword;

    AbsolutePath OutputPackageDir => RootDirectory / "artifacts" / "pkg";

    private void RemoveTemporaryFeeds()
    {
        try
        {
            if (DotNet("nuget list source").Any(x => x.Text.Contains(TemporaryNuGetFeed)))
            {
                DotNet($"nuget remove source \"{TemporaryNuGetFeed}\"");
            }
        }
        catch
        {
            // probably hasn't existed yet, don't care.
        }
    }

    private IEnumerable<Output> AddTemporaryFeed()
    {
        if (NugetFeed.Contains("nuget.org"))
        {
            return [];
        }

        var srcSettings = new DotNetNuGetAddSourceSettings()
            .SetName(TemporaryNuGetFeed)
            .SetSource(NugetFeed);

        if (NugetUsername is null != NugetPassword is null)
        {
            Assert.Fail(
                "Both \"NugetUsername\" and \"NugetPassword\" must be specified if either are used."
            );
        }

        if (NugetUsername is not null && NugetPassword is not null)
        {
            srcSettings = srcSettings
                .SetUsername(NugetUsername)
                .SetPassword(NugetPassword)
                .SetStorePasswordInClearText(true);
        }

        return DotNetNuGetAddSource(srcSettings);
    }

    async IAsyncEnumerable<AbsolutePath> GetPackagesToPublish()
    {
        const int rateLimit = 300;
        var first = true;
        foreach (
            var packages in Packages
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / rateLimit)
                .Select(x => x.Select(v => v.Value))
        )
        {
            if (first)
            {
                first = false;
            }
            else
            {
                Log.Warning(
                    "We have just pushed over {} packages in quick succession, delaying for an hour to avoid rate "
                        + "limits. Publishing will continue at {}",
                    rateLimit,
                    DateTime.Now.AddHours(1).TimeOfDay
                );
                await Task.Delay(TimeSpan.FromHours(1));
            }

            foreach (var package in packages)
            {
                yield return package;
            }
        }
    }

    DotNetNuGetPushSettings NuGetPushSettings
    {
        get
        {
            var ret = new DotNetNuGetPushSettings()
                .SetNoServiceEndpoint(NugetNoServiceEndpoint)
                .EnableSkipDuplicate()
                .SetSource(NugetFeed.Contains("nuget.org") ? "nuget.org" : TemporaryNuGetFeed);
            if (NugetApiKey is not null)
            {
                ret = ret.SetApiKey(NugetApiKey);
            }

            return ret;
        }
    }
}

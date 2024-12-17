// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Humanizer;
using Markdig;
using Markdig.Renderers.Normalize;
using Markdig.Renderers.Normalize.Inlines;
using Markdig.Syntax.Inlines;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Octokit;
using Serilog;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;

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

    private void GetVersionInfo(
        string changelog,
        out string silkVersion,
        out string silkVersionSuffix,
        out string silkReleaseNotes
    )
    {
        var lines = changelog.Split(["\r\n", "\r", "\n"], StringSplitOptions.None);

        var capturing = false;
        var notes = new StringBuilder();
        string? version = null;
        string? versionSuffix = null;
        foreach (var theLine in lines)
        {
            var line = theLine.Trim();
            if (!line.StartsWith("##"))
            {
                if (capturing)
                {
                    notes.AppendLine(line);
                }
                continue;
            }

            if (capturing)
            {
                break;
            }

            version = line[2..].Trim();
            var versionStop = version.IndexOf(' ');
            if (versionStop != -1)
            {
                version = version[..versionStop];
            }
            versionSuffix = string.Empty;
            var versionSuffixStart = version.IndexOf('-');
            if (versionSuffixStart != -1)
            {
                versionSuffix = version[(versionSuffixStart + 1)..];
                version = version[..versionSuffixStart];
            }
            versionSuffix = versionSuffix.Trim();
            version = version.Trim();
            capturing = true;
        }

        if (!capturing)
        {
            throw new Exception("Failed to determine version information.");
        }

        silkVersion = version ?? "3.0.0";
        silkVersionSuffix = versionSuffix ?? "unknown";
        silkReleaseNotes = notes.ToString();
    }

    private async Task CreateReleaseAsync(string version, string versionSuffix, string releaseNotes)
    {
        var tag =
            $"v{version}{(string.IsNullOrWhiteSpace(versionSuffix) ? string.Empty : $"-{versionSuffix}")}";
        Git($"config user.email \"9011267+dotnet-bot@users.noreply.github.com\"");
        Git($"config user.name \"The Silk.NET Automaton\"");
        Git($"tag {tag}");
        Git($"push origin {tag}");
        var github = new GitHubClient(
            new ProductHeaderValue("Silk.NET-CI"),
            new Octokit.Internal.InMemoryCredentialStore(
                new Credentials(GitHubActions.Instance.Token)
            )
        );
        var lines = releaseNotes
            .Split(["\r\n", "\r", "\n"], StringSplitOptions.None)
            .SkipWhile(string.IsNullOrWhiteSpace)
            .ToList();
        await github.Repository.Release.Create(
            "dotnet",
            "Silk.NET",
            new NewRelease(tag)
            {
                Prerelease = !string.IsNullOrWhiteSpace(versionSuffix),
                Body = releaseNotes,
                DiscussionCategoryName = "Q&A",
                Name = lines[0].Replace("Silk.NET", string.Empty).Trim(), // tradition
                TargetCommitish = GitCurrentCommit(),
            }
        );
    }

    private void CommitAfterShipping(string version, string versionSuffix)
    {
        if (GitIsDetached())
        {
            Git($"checkout {GitHubActions.Instance.RefName}");
        }
        string nextVersion;
        string nextVersionHeadline;
        if (string.IsNullOrWhiteSpace(versionSuffix))
        {
            var ver = Version.Parse(version);
            ver = new Version(ver.Major, ver.Minor + 1, ver.Build);
            nextVersion = ver.ToString();
            nextVersionHeadline = $"Silk.NET {ver.ToString(2)}";
        }
        else
        {
            var suffixSpan = versionSuffix.AsSpan();
            var suffixNumberStart = suffixSpan.IndexOfAnyInRange('0', '9');
            if (suffixNumberStart == -1)
            {
                versionSuffix = $"{versionSuffix}2";
            }
            else
            {
                var suffixNumberEnd =
                    suffixSpan[suffixNumberStart..].IndexOfAnyExceptInRange('0', '9')
                    + suffixNumberStart;
                versionSuffix =
                    versionSuffix[..suffixNumberStart]
                    + (
                        int.Parse(
                            suffixSpan[
                                suffixNumberEnd == -1
                                    ? suffixNumberStart..
                                    : suffixNumberStart..suffixNumberEnd
                            ]
                        ) + 1
                    )
                    + (suffixNumberEnd == -1 ? string.Empty : versionSuffix[suffixNumberEnd..]);
            }

            nextVersion = $"{version}-{versionSuffix}";
            nextVersionHeadline =
                $"Silk.NET {Version.Parse(version)} {versionSuffix.Humanize(LetterCasing.Title)}";
        }

        var lines = File.ReadAllLines(RootDirectory / "docs" / "CHANGELOG.md").ToList();
        for (var i = 0; i < lines.Count; i++)
        {
            if (!lines[i].StartsWith("## "))
            {
                continue;
            }

            lines[i] = $"{lines[i]} ({DateTime.UtcNow:dd/MM/yyyy})";
            lines.InsertRange(
                i,
                [$"## {nextVersion}", string.Empty, nextVersionHeadline, string.Empty]
            );
            break;
        }

        File.WriteAllLines(RootDirectory / "docs" / "CHANGELOG.md", lines);
        Git("add **/PublicAPI.*.txt docs/CHANGELOG.md");

        // Must be an interpolated string even if we're not interpolating because NUKE specially recognises this idfk.
        // The issue this caused if you omitted the $ is as follows:
        // 20:14:58 [INF] > "C:\Program Files\Git\bin\git.exe" config user.email "9011267+dotnet-bot@users.noreply.github.com"
        // 20:14:58 [INF] > "C:\Program Files\Git\bin\git.exe" config user.name "The Silk.NET Automaton"
        // 20:14:58 [INF] > "C:\Program Files\Git\bin\git.exe" tag v3.0.0-preview
        // 20:14:59 [DBG] ...
        // 20:15:00 [INF] > "C:\Program Files\Git\bin\git.exe" "commit -m \"Update public API after release\""
        // 20:15:00 [DBG] git: 'commit -m "Update public API after release"' is not a git command. See 'git --help'.
        // Error: Target "FinishRelease" has thrown an exception
        // THE ONLY DISCERNABLE DIFFERENCE BETWEEN THE GIT CONFIG COMMANDS AND GIT COMMIT COMMAND WAS THE LACK OF A $
        Git($"commit -m \"Update public API and changelog for next release\"");
        Git("push");
    }

    private readonly record struct VersionsList(
        [property: JsonPropertyName("versions")] List<string> Versions
    );

    private async Task WaitForNuGetToUpdateAsync(string version, string versionSuffix)
    {
        return; // TODO while testing release flow
        var fullVersion = string.IsNullOrWhiteSpace(versionSuffix)
            ? version
            : $"{version}-{versionSuffix}";
        using var http = new HttpClient();
        for (var i = 0; i < 60; i++)
        {
            var versions = await (
                await http.GetAsync("https://api.nuget.org/v3-flatcontainer/silk.net/index.json")
            )
                .EnsureSuccessStatusCode()
                .Content.ReadFromJsonAsync<VersionsList>();
            if (versions.Versions.Contains(fullVersion))
            {
                return;
            }

            await Task.Delay(TimeSpan.FromMinutes(1));
        }

        throw new Exception("NuGet didn't update after an hour.");
    }

    [Parameter("Discord release announcement webhook.")]
    readonly string? DiscordWebhook;

    private readonly record struct Webhook(
        [property: JsonPropertyName("content")] string Content,
        [property: JsonPropertyName("allowed_mentions")]
            Dictionary<string, string[]> AllowedMentions
    );

    private async Task SendWebhookAsync(string version, string versionSuffix, string releaseNotes)
    {
        if (DiscordWebhook is null)
        {
            return;
        }

        var fullVersion = string.IsNullOrWhiteSpace(versionSuffix)
            ? version
            : $"{version}-{versionSuffix}";
        var lines = releaseNotes
            .Trim()
            .Split(["\r\n", "\r", "\n"], StringSplitOptions.None)
            .SkipWhile(string.IsNullOrWhiteSpace)
            .ToList();
        var headline = $"{lines[0].Trim()} (v{fullVersion})";
        var message =
            $"**__{headline}__** <@335783158223994890>\n\n"
            + $"Get it on NuGet: TODOINSERTRELEASENUGETURLHERE\n\n"
            + string.Join('\n', lines.Skip(1).SkipWhile(string.IsNullOrWhiteSpace))
            + $"\n\n**__Get {headline} on NuGet__**";
        var sw = new StringWriter();
        var normRenderer = new NormalizeRenderer(sw);
        normRenderer.ObjectRenderers.Replace<LinkInlineRenderer>(new DiscordUrlEscapeRenderer());
        normRenderer.Render(Markdown.Parse(message));
        message = sw.ToString()
            .Replace(
                "TODOINSERTRELEASENUGETURLHERE",
                $"https://nuget.org/packages/Silk.NET/{fullVersion}"
            );
        using var http = new HttpClient();
        (
            await http.PostAsJsonAsync(
                DiscordWebhook,
                new Webhook(
                    message,
                    new Dictionary<string, string[]> { { "users", ["335783158223994890"] } }
                )
            )
        ).EnsureSuccessStatusCode();
    }

    class DiscordUrlEscapeRenderer : NormalizeObjectRenderer<LinkInline>
    {
        private LinkInlineRenderer _fallback = new();

        protected override void Write(NormalizeRenderer renderer, LinkInline obj)
        {
            if (obj.IsAutoLink)
            {
                renderer.Write($"<{obj.Url}>");
                return;
            }

            _fallback.Write(renderer, obj);
        }
    }
}

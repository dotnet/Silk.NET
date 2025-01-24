// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Octokit;
using Serilog;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    readonly record struct VersionDescription(
        AbsolutePath Path,
        AbsolutePath StaticPath,
        string Name,
        AbsolutePath? Changelog = null
    );

    [Parameter("If enabled, skips scraping the contributors for the authors.yml file of the blog.")]
    readonly bool SkipContributorsScrape;

    VersionDescription[] Versions =>
        [
            new(
                RootDirectory / "eng" / "submodules" / "silk.net-2.x" / "documentation",
                RootDirectory / "eng" / "submodules" / "silk.net-2.x" / "documentation" / "images",
                "v2"
            ),
            new(
                RootDirectory / "docs",
                RootDirectory / "sources" / "Website" / "static" / "img",
                "v3",
                RootDirectory / "docs" / "CHANGELOG.md"
            ),
        ];

    readonly record struct JsonVersion(
        [property: JsonPropertyName("label")] string Label,
        [property:
            JsonPropertyName("path"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Path,
        [property: JsonPropertyName("badge")] bool Badge = true
    );

    async Task FullBuildWebsiteAsync()
    {
        if (!SkipContributorsScrape)
        {
            await File.WriteAllLinesAsync(
                RootDirectory / "sources" / "Website" / "blog" / "authors.yml",
                await GetAuthorsContents().ToListAsync()
            );
        }

        (RootDirectory / "sources" / "Website" / "node_modules").CreateOrCleanDirectory();
        Npm("i", RootDirectory / "sources" / "Website");
        (TemporaryDirectory / "docs").CreateOrCleanDirectory();
        (RootDirectory / "docs").Copy(
            TemporaryDirectory / "docs",
            ExistsPolicy.MergeAndOverwriteIfNewer
        );
        (TemporaryDirectory / "website").CreateOrCleanDirectory();
        (RootDirectory / "sources" / "Website").Copy(
            TemporaryDirectory / "website",
            ExistsPolicy.MergeAndOverwriteIfNewer
        );
        try
        {
            var versions = Versions;
            var jsonVersions = new Dictionary<string, JsonVersion>(versions.Length);
            for (var i = 0; i < versions.Length; i++)
            {
                var version = versions[i];
                (RootDirectory / "docs").CreateOrCleanDirectory();
                (
                    version.Path == RootDirectory / "docs"
                        ? TemporaryDirectory / "docs"
                        : version.Path
                ).Copy(RootDirectory / "docs", ExistsPolicy.MergeAndOverwriteIfNewer);
                if (i != versions.Length - 1)
                {
                    version.StaticPath.CopyToDirectory(
                        RootDirectory / "sources" / "Website" / "static",
                        ExistsPolicy.MergeAndOverwriteIfNewer
                    );

                    Npm(
                        $"run docusaurus docs:version {version.Name}",
                        RootDirectory / "sources" / "Website"
                    );
                }

                jsonVersions[i == versions.Length - 1 ? "current" : version.Name] = new JsonVersion(
                    version.Changelog is { } changelog ? GetVersionFromChangelog(changelog)
                        : File.Exists(version.Path / "version.txt")
                            ? File.ReadAllText(version.Path / "version.txt")
                        : Git($"describe --tags --abbrev=0", version.Path)
                            .First(x => x.Type == OutputType.Std)
                            .Text.Trim(),
                    i == versions.Length - 1 ? version.Name : null
                );
            }

            (RootDirectory / "artifacts" / "docs").CreateOrCleanDirectory();
            File.WriteAllText(
                RootDirectory / "sources" / "Website" / "silkversions.json",
                JsonSerializer.Serialize(jsonVersions)
            );
            Npm(
                $"run build -- --out-dir {RootDirectory / "artifacts" / "docs" / "Silk.NET"}",
                RootDirectory / "sources" / "Website"
            );
            CreateRedirectsFromOldWebsiteUrlsToNewWebsiteUrls(
                RootDirectory / "artifacts" / "docs" / "Silk.NET"
            );
        }
        finally
        {
            File.Delete(RootDirectory / "sources" / "Website" / "silkversions.json");
            (RootDirectory / "docs").CreateOrCleanDirectory();
            (TemporaryDirectory / "docs").Copy(
                RootDirectory / "docs",
                ExistsPolicy.MergeAndOverwriteIfNewer
            );
            (TemporaryDirectory / "docs").CreateOrCleanDirectory();
            (RootDirectory / "sources" / "Website").CreateOrCleanDirectory();
            (TemporaryDirectory / "website").Copy(
                RootDirectory / "sources" / "Website",
                ExistsPolicy.MergeAndOverwriteIfNewer
            );
            (TemporaryDirectory / "website").CreateOrCleanDirectory();
        }
    }

    string GetVersionFromChangelog(AbsolutePath path)
    {
        GetVersionInfo(File.ReadAllText(path), out var ver, out var suffix, out _);
        return string.IsNullOrWhiteSpace(suffix) ? $"v{ver}" : $"v{ver}-{suffix}";
    }

    class SocialAccount(string? provider, string? url)
    {
        public SocialAccount()
            : this(null, null) { }

        public string? Provider { get; private set; } = provider;
        public string? Url { get; private set; } = url;
    }

    async IAsyncEnumerable<string> GetAuthorsContents()
    {
        var github = new GitHubClient(
            new ProductHeaderValue("Silk.NET-CI"),
            new Octokit.Internal.InMemoryCredentialStore(
                new Credentials(
                    string.IsNullOrWhiteSpace(GitHubActions.Instance?.Token)
                        ? StartProcess("gh", "auth token")
                            .AssertZeroExitCode()
                            .Output.First(x => x.Type == OutputType.Std)
                            .Text.Trim()
                        : GitHubActions.Instance.Token
                )
            )
        );
        var contributors = await github.Repository.GetAllContributors("dotnet", "Silk.NET");
        foreach (var contributor in contributors ?? [])
        {
            if (contributor.Login.AsSpan().ContainsAny('[', ']'))
            {
                continue;
            }

            Log.Information("Fetching user info for {Login}", contributor.Login);
            var user = await github.User.Get(contributor.Login);
            if (user is null)
            {
                continue;
            }

            yield return $"{user.Login}:";
            yield return $"  name: {user.Name ?? user.Login}";
            yield return $"  url: https://github.com/{user.Login}";
            yield return $"  image_url: https://github.com/{user.Login}.png";
            yield return "  page: true";
            Log.Information("Fetching user socials for {Login}", contributor.Login);
            var socials = (
                await github.Connection.Get<IReadOnlyList<SocialAccount>>(
                    new Uri($"https://api.github.com/users/{user.Login}/social_accounts"),
                    new Dictionary<string, string>(),
                    "application/vnd.github+json"
                )
            ).Body;
            if (socials is not { Count: > 0 })
            {
                continue;
            }

            yield return "  socials:";
            foreach (var social in socials.DistinctBy(x => x.Provider))
            {
                yield return $"    {social.Provider}: \"{social.Url}\"";
            }
        }
    }

    const string BaseUrl = "https://dotnet.github.io/Silk.NET/";

    string GetRedirect(string url) =>
        $"""
            <!DOCTYPE HTML>
            <html>
            <head>
            <meta charset="UTF-8">
            <meta http-equiv="refresh" content="1; url="{BaseUrl}{url}">
            <script>
              window.location.href = "{BaseUrl}{url}"
            </script>
            <title>Redirecting...</title>
            </head>
            <body>
            <p>If you are not redirected automatically, <a href="{BaseUrl}{url}">click here</a>.</p>
            </body>
            </html>
            """;

    void CreateRedirectsFromOldWebsiteUrlsToNewWebsiteUrls(AbsolutePath basePath)
    {
        foreach (var dirStr in Directory.GetDirectories(basePath, "*", SearchOption.AllDirectories))
        {
            var dir = (AbsolutePath)dirStr;
            var index = dir / "index.html";
            if (!index.FileExists())
            {
                continue;
            }

            File.WriteAllText(
                dir.Parent / $"{dir.Name}.html",
                GetRedirect(basePath.GetRelativePathTo(dir).ToString().Replace('\\', '/'))
            );
        }

        (basePath / "blog" / "rss.xml").Copy(basePath / "blog" / "feed.rss");
        (basePath / "blog" / "atom.xml").Copy(basePath / "blog" / "feed.atom");
    }
}

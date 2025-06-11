// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using GlobExpressions;
using Markdig;
using Markdig.Extensions.Yaml;
using Markdig.Syntax;
using Nuke.Common;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.IO;
using Nuke.Common.Tooling;
using Serilog;
using YamlDotNet.RepresentationModel;
using static Nuke.Common.Tooling.ProcessTasks;
using static Nuke.Common.Tools.Git.GitTasks;
using static Nuke.Common.Tools.Npm.NpmTasks;

partial class Build
{
    readonly record struct VersionDescription(
        AbsolutePath Path,
        AbsolutePath StaticPath,
        string Name,
        string Version,
        bool IsPreviewOnly
    );

    [Parameter("If enabled, skips scraping the contributors for the authors.yml file of the blog.")]
    readonly bool SkipContributorsScrape;

    [GeneratedRegex(@"^develop\/([0-9]+)\.0$")]
    private static partial Regex NextVersionRegex();

    private async Task<VersionDescription[]> CreateVersionsArray()
    {
        using var http = new HttpClient();

        // Figure out if we're currently working on the next version of Silk.NET.
        var nextVersion = Git($"ls-remote -h origin")
            .Where(x => x.Type == OutputType.Std)
            .SelectMany(x => x.Text.Split('\n'))
            .Where(x => x.Contains("\trefs/heads/"))
            .Select(x =>
                NextVersionRegex()
                    .Match(
                        x.Split('\t', StringSplitOptions.RemoveEmptyEntries)[1].Trim()[
                            "refs/heads/".Length..
                        ]
                    )
                    is { Success: true, Groups.Count: 2 } match
                    ? int.Parse(match.Groups[1].ValueSpan)
                    : (int?)null
            )
            .FirstOrDefault();

        // Get the branch we're currently on.
        var thisBranch = GitCurrentBranch();
        var thisVersionName = GetVersionFromChangelog(RootDirectory / "docs" / "CHANGELOG.md");
        var thisVersion =
            (
                NextVersionRegex().Match(thisBranch) is { Success: true, Groups.Count: 2 } match
                    ? int.Parse(match.Groups[1].ValueSpan)
                    : (int?)null
            )
            // We're on main. Changelog will tell us which major version main tracks.
            ?? int.Parse(thisVersionName.AsSpan()[1..2]);
        var releasedVersions = Git($"ls-remote -t origin")
            .Where(x => x.Type == OutputType.Std)
            .SelectMany(x => x.Text.Split('\n'))
            .Where(x => x.Contains("\trefs/tags/"))
            .Select(x =>
                x.Split('\t', StringSplitOptions.RemoveEmptyEntries)[1].Trim()[
                    "refs/tags/".Length..
                ]
            )
            .Where(x => !x.StartsWith("v1.")) // <-- not generating manual docs for v1
            // OrderByDescending so DistinctBy will take the newest version for each major version.
            .OrderByDescending(x =>
                Version.Parse(x.AsSpan()[1..(x.IndexOf('-') is var i and not -1 ? i : x.Length)])
            )
            .ThenBy(x => x) // <-- for previews
            .DistinctBy(x => x[1..x.IndexOf('.')])
            .OrderBy(x => x[1..x.IndexOf('.')])
            .ToList();

        // Allocate the result. Note that we are skipping v1, hence `- 1`.
        var versions = new VersionDescription[(nextVersion ?? thisVersion) - 1];
        for (var i = 0; i < versions.Length; i++)
        {
            var v = i + 2; // + 1 as it's an index, + 1 to skip v1
            AbsolutePath rootDir;
            if (v == thisVersion)
            {
                rootDir = RootDirectory;
            }
            else if ((RootDirectory / "eng" / "submodules" / $"silk.net-{v}.x").DirectoryExists())
            {
                rootDir = RootDirectory / "eng" / "submodules" / $"silk.net-{v}.x";
            }
            else
            {
                rootDir = TemporaryDirectory / $"v{v}";
                // nextVersion is non-null if a develop branch exists. If a develop branch exists, the main branch
                // tracks the previous major version. Otherwise, we assume a branch doesn't exist and download the tag
                // instead. Note that this could result in some loss of doc changes for the old version if changes
                // happened on the branch and no new version followed prior to the merge of a develop branch to main,
                // but oh well. If no develop branch exists, we assume that we're on main.
                var refToDownload =
                    v + 1 == nextVersion ? "refs/heads/main"
                    : v == nextVersion ? $"refs/heads/develop/{v}.0"
                    : $"refs/tags/{releasedVersions[i]}";

                if (!rootDir.DirectoryExists())
                {
                    rootDir.CreateDirectory();
                    Log.Information("Downloading {RefToDownload}", refToDownload);
                    ZipFile.ExtractToDirectory(
                        await http.GetStreamAsync(
                            $"https://github.com/dotnet/Silk.NET/archive/{refToDownload}.zip"
                        ),
                        rootDir
                    );
                }
                rootDir = Directory.GetDirectories(rootDir)[0];
            }

            versions[i] = new VersionDescription(
                v == 2 ? rootDir / "documentation" : rootDir / "docs",
                v == 2
                    ? rootDir / "documentation" / "images"
                    : rootDir / "sources" / "Website" / "static" / "img",
                $"v{v}",
                File.Exists(rootDir / "version.txt") ? File.ReadAllText(rootDir / "version.txt")
                    : i > releasedVersions.Count - 1
                        ? v == thisVersion ? thisVersionName
                            : GetVersionFromChangelog(rootDir / "docs" / "CHANGELOG.md")
                    : releasedVersions[i],
                releasedVersions.Where(x => x.StartsWith($"v{v}.")).All(x => x.Contains('-'))
            );
        }

        return versions;
    }

    readonly record struct JsonVersion(
        [property: JsonPropertyName("label")] string Label,
        [property:
            JsonPropertyName("path"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Path,
        [property: JsonPropertyName("badge")] bool Badge = true
    );

    readonly record struct SilkVersionsJson(
        [property: JsonPropertyName("versions")] Dictionary<string, JsonVersion> Versions,
        [property: JsonPropertyName("lastVersion")] string? LastVersion = null,
        [property: JsonPropertyName("nextVersion")] string? NextVersion = null
    );

    async Task FullBuildWebsiteAsync()
    {
        if (!SkipContributorsScrape)
        {
            var authors = await GetAuthorsContents().ToListAsync();
            Log.Information("Result: {0}", string.Join(' ', authors));
            await File.WriteAllLinesAsync(
                RootDirectory / "sources" / "Website" / "blog" / "authors.yml",
                authors
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
            var versions = await CreateVersionsArray();
            var jsonVersions = new Dictionary<string, JsonVersion>(versions.Length);
            string? lastVersion = null;
            string? nextVersion = null;
            for (var i = 0; i < versions.Length; i++)
            {
                var version = versions[i];
                (RootDirectory / "docs").CreateOrCleanDirectory();
                (
                    version.Path == RootDirectory / "docs"
                        ? TemporaryDirectory / "docs"
                        : version.Path
                ).Copy(RootDirectory / "docs", ExistsPolicy.MergeAndOverwriteIfNewer);
                (
                    version.StaticPath == RootDirectory / "sources" / "Website" / "static" / "img"
                        ? TemporaryDirectory / "website" / "static" / "img"
                        : version.StaticPath
                ).CopyToDirectory(
                    RootDirectory / "sources" / "Website" / "static",
                    ExistsPolicy.MergeAndOverwriteIfNewer
                );

                // HACK: 2.X made an incorrect interpretation on the above, so we fix it up here in lieu of it changing
                // there (if ever). Didn't feel like breaking things here.
                if (version.StaticPath.Name == "images")
                {
                    (
                        version.StaticPath / "opengl" / "chapter1" / "final-result-t2.png"
                    ).CopyToDirectory(
                        RootDirectory / "sources" / "Website" / "static" / "opengl" / "chapter1",
                        ExistsPolicy.MergeAndOverwriteIfNewer
                    );
                }

                if (i != versions.Length - 1)
                {
                    Npm(
                        $"run docusaurus docs:version {version.Name}",
                        RootDirectory / "sources" / "Website"
                    );
                }

                var k = i == versions.Length - 1 ? "current" : version.Name;
                jsonVersions[k] = new JsonVersion(
                    version.Version,
                    i == versions.Length - 1 ? version.Name : null
                );
                if (!version.IsPreviewOnly)
                {
                    lastVersion = k;
                }
                else
                {
                    nextVersion = k;
                }
            }

            (RootDirectory / "artifacts" / "docs").CreateOrCleanDirectory();
            File.WriteAllText(
                RootDirectory / "sources" / "Website" / "silkversions.json",
                JsonSerializer.Serialize(
                    new SilkVersionsJson(jsonVersions, lastVersion, nextVersion)
                )
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

    record SocialAccount(
        [property: JsonPropertyName("provider")] string Provider,
        [property: JsonPropertyName("url")] string Url
    );

    record NodesWrapper<T>([property: JsonPropertyName("nodes")] T[] Nodes);

    record User(
        [property: JsonPropertyName("email")] string? Email,
        [property: JsonPropertyName("avatarUrl")] string AvatarUrl,
        [property: JsonPropertyName("url")] string Url,
        [property: JsonPropertyName("name")] string? Name,
        [property: JsonPropertyName("websiteUrl")] string? WebsiteUrl,
        [property: JsonPropertyName("socialAccounts")] NodesWrapper<SocialAccount>? SocialAccounts
    );

    record QueryInput([property: JsonPropertyName("query")] string Query);

    record QueryOutput([property: JsonPropertyName("data")] Dictionary<string, User?> Data);

    const string QueryTemplate = """
        {0}: user(login: "{0}"){{
          email,
          avatarUrl,
          url,
          name,
          websiteUrl,
          socialAccounts(first: 16) {{
            nodes {{
              provider,
              url
            }}
          }}
        }}
        """;

    async IAsyncEnumerable<string> GetAuthorsContents()
    {
        using var http = new HttpClient();
        var token = (
            string.IsNullOrWhiteSpace(GitHubActions.Instance?.Token)
                ? StartProcess("gh", "auth token")
                    .AssertZeroExitCode()
                    .Output.First(x => x.Type == OutputType.Std)
                    .Text.Trim()
                : GitHubActions.Instance.Token
        ).NotNullOrWhiteSpace(
            message: "\"gh auth token\" did not yield GitHub token. Please \"gh login\""
        );
        http.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        http.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Silk.NET-CI", "3.0"));

        // Get all author names from the front matter
        var authors = new HashSet<string>();
        var mdp = new MarkdownPipelineBuilder().UseYamlFrontMatter().Build();
        foreach (var file in Glob.Files(RootDirectory, "sources/Website/blog/**/*.{md,mdx}"))
        {
            try
            {
                var md = Markdown.Parse(await File.ReadAllTextAsync(file), mdp);
                var ys = new YamlStream();
                var fm = md.Descendants().OfType<YamlFrontMatterBlock>().First();
                ys.Load(new StringReader(fm.Lines.ToString()));
                foreach (
                    var node in ys
                        .Documents.First()
                        .AllNodes.OfType<YamlMappingNode>()
                        .Select(x =>
                            x.Children.FirstOrDefault(x =>
                                x.Key.ToString() is "author" or "authors"
                            ).Value
                        )
                )
                {
                    // ReSharper disable once ConvertIfStatementToSwitchStatement <-- more code...
                    if (node is YamlSequenceNode seq)
                    {
                        foreach (var scalar in seq.Children.OfType<YamlScalarNode>())
                        {
                            authors.Add(scalar.ToString());
                        }
                    }
                    else if (node is YamlScalarNode scalar)
                    {
                        authors.Add(scalar.ToString());
                    }
                }
                Log.Information("Scanned {0} for authors.", file);
            }
            catch
            {
                // skip, best effort...
                continue;
            }
        }

        authors.RemoveWhere(x => x.Any(y => !char.IsLetterOrDigit(y) && y != '-'));
        var query =
            $"query {{ {string.Join(',', authors.Select(x => string.Format(QueryTemplate, x)))} }}";
        Log.Information("GraphQL query: {0}", query);
        var contributors = await (
            await http.PostAsJsonAsync("https://api.github.com/graphql", new QueryInput(query))
        )
            .EnsureSuccessStatusCode()
            .Content.ReadFromJsonAsync<QueryOutput>();
        foreach (var (contributorLogin, contributor) in contributors?.Data ?? [])
        {
            if (contributor is null)
            {
                continue;
            }

            yield return $"{contributorLogin}:";
            yield return $"  name: {contributor.Name ?? contributorLogin}";
            yield return $"  url: \"{contributor.WebsiteUrl ?? $"https://github.com/{contributorLogin}"}\"";
            yield return $"  image_url: \"{contributor.AvatarUrl}\"";
            if (!string.IsNullOrWhiteSpace(contributor.Email))
            {
                yield return $"  email: \"{contributor.Email}\"";
            }

            yield return "  page: true";
            if (contributor.SocialAccounts?.Nodes is not { Length: > 0 } socials)
            {
                continue;
            }

            yield return "  socials:";
            foreach (var social in socials.DistinctBy(x => x.Provider))
            {
                yield return $"    {social.Provider.ToLower()}: \"{social.Url}\"";
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

            Directory.CreateDirectory(dir.Parent / $"{dir.Name}.html");
            File.WriteAllText(
                dir.Parent / $"{dir.Name}.html" / "index.html",
                GetRedirect(basePath.GetRelativePathTo(dir).ToString().Replace('\\', '/'))
            );
        }

        (basePath / "blog" / "rss.xml").Copy(basePath / "blog" / "feed.rss");
        (basePath / "blog" / "atom.xml").Copy(basePath / "blog" / "feed.atom");
    }
}

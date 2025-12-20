using System;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Web;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Caching;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// Uses NuGet as an input source i.e. so we can use files within NuGet packages.
/// </summary>
public class NuGetInputSource(ICacheProvider? cache, ILogger<NuGetInputSource> logger)
    : IInputSource
{
    private const string VersionsUrl = "https://api.nuget.org/v3-flatcontainer/{0}/index.json";
    private const string DownloadUrl = "https://www.nuget.org/api/v2/package/{0}/{1}";
    private HttpClient _client = new();

    /// <inheritdoc />
    public async Task<string?> TryResolvePath(string path)
    {
        var uri = new Uri(path);
        var packageName = uri.Authority.ToLower();
        var queryString = HttpUtility.ParseQueryString(uri.Query);
        var version = queryString["version"]?.ToLower() ?? "latest";
        if (version == "latest")
        {
            version = JsonSerializer
                .Deserialize<VersionsPayload>(
                    await _client.GetStringAsync(string.Format(VersionsUrl, packageName))
                )
                .Versions.Last();
        }

        var pathInPackage = uri.GetComponents(UriComponents.Path, UriFormat.Unescaped);
        var cacheDir = await (
            cache?.GetDirectoryAsync(
                $"{packageName}.{version}",
                CacheIntent.ResolvedForeignInput,
                CacheFlags.AllowNew | CacheFlags.RequireHostDirectory,
                FileAccess.ReadWrite
            ) ?? ValueTask.FromResult<ICacheDirectory?>(null)
        );

        string dir;
        var needsDownload = true;
        if (cacheDir is { Path: { } fsPath })
        {
            dir = fsPath;
            needsDownload = !Directory.GetFiles(fsPath, "*", SearchOption.AllDirectories).Any();
        }
        else
        {
            logger.LogWarning(
                "Failed to open cache for {0} v{1}, download will not be cached.",
                packageName,
                version
            );
            dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        }

        if (needsDownload)
        {
            var url = string.Format(DownloadUrl, packageName, version);
            logger.LogInformation("Downloading & extracting {} into {}", url, dir);
            await new ZipArchive(await _client.GetStreamAsync(url)).ExtractToDirectoryAsync(dir);
            await (cacheDir?.CommitAsync() ?? ValueTask.CompletedTask);
        }

        var semver1x4 = version[..(version.IndexOf('-') is not -1 and var v ? v : ^0)];
        var missingDots = 3 - semver1x4.AsSpan().Count('.');
        for (var i = 0; i < missingDots; i++)
        {
            semver1x4 += ".0";
        }

        return Path.Combine(
            dir,
            pathInPackage.Replace("$versionsv1x4", semver1x4).Replace("$version", version)
        );
    }

    /// <inheritdoc />
    public string Scheme => "nuget";

    private readonly record struct VersionsPayload(
        [property: JsonPropertyName("versions")] string[] Versions
    );
}

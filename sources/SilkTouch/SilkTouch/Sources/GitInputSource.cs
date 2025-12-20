using System;
using System.Diagnostics;
using System.IO;
using System.IO.Hashing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Silk.NET.SilkTouch.Caching;

namespace Silk.NET.SilkTouch.Sources;

/// <summary>
/// An input source that clones a repo in which the path is contained.
/// </summary>
/// <param name="logger">The logger.</param>
/// <param name="cache">The cache into which the repo is cloned.</param>
public class GitInputSource(ILogger<GitInputSource> logger, ICacheProvider? cache) : IInputSource
{
    /// <inheritdoc />
    public async Task<string?> TryResolvePath(string path)
    {
        var cacheKey = Convert.ToHexString(
            XxHash32.Hash(MemoryMarshal.Cast<char, byte>(path.AsSpan()))
        );
        logger.LogDebug("Cache key for {} = {}", path, cacheKey);
        var cacheDir = await (
            cache?.GetDirectoryAsync(
                cacheKey,
                CacheIntent.ResolvedForeignInput,
                CacheFlags.AllowNew | CacheFlags.RequireHostDirectory,
                FileAccess.ReadWrite
            ) ?? ValueTask.FromResult<ICacheDirectory?>(null)
        );

        string dir;
        var shouldClone = true;
        if (cacheDir is { Path: { } fsPath })
        {
            dir = fsPath;
            shouldClone = !Directory.GetFiles(fsPath, "*", SearchOption.AllDirectories).Any();
        }
        else
        {
            logger.LogWarning(
                "Failed to open cache for \"{0}\" (cache key {1}), clone will not be cached.",
                path,
                cacheKey
            );
            dir = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        }

        path = path[4..].TrimStart('/');
        var url = path;
        var argString = string.Empty;
        string? pathInRepo = null;
        if (path.LastIndexOf('?') is not -1 and var i)
        {
            argString = path[(i + 1)..]
                .Split('&', StringSplitOptions.RemoveEmptyEntries)
                .Aggregate(
                    string.Empty,
                    (args, x) =>
                    {
                        if (!x.StartsWith("path=", StringComparison.CurrentCultureIgnoreCase))
                        {
                            return args
                                + (
                                    x.LastIndexOf('=') is not -1 and var j
                                        ? $" --{x[..j]} {x[(j + 1)..]}"
                                        : $" --{x}"
                                );
                        }

                        pathInRepo = x[5..];
                        return args;
                    }
                )
                .TrimStart(' ');
            url = url[..i];
        }

        if (pathInRepo is null)
        {
            logger.LogWarning("No path in repo given: {}", path);
            return null;
        }

        if (shouldClone)
        {
            using var proc = Process.Start("git", $"clone \"{url}\" \"{dir}\" {argString}");
            await proc.WaitForExitAsync();
            if (proc.ExitCode != 0)
            {
                throw new ExternalException(
                    $"\"{proc.StartInfo.FileName} {proc.StartInfo.Arguments}\" exited with code {proc.ExitCode}"
                );
            }

            await (cacheDir?.CommitAsync() ?? ValueTask.CompletedTask);
        }

        return Path.Combine(dir, pathInRepo);
    }

    /// <inheritdoc />
    public string Scheme => "git";
}

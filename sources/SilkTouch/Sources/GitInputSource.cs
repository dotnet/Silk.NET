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
public class GitInputSource(ILogger<GitInputSource> logger, ICacheProvider cache) : IInputSource
{
    /// <inheritdoc />
    public async Task<string?> TryResolvePath(string path)
    {
        var cacheKey = Convert.ToHexString(
            XxHash32.Hash(MemoryMarshal.Cast<char, byte>(path.AsSpan()))
        );
        logger.LogDebug("Cache key for {} = {}", path, cacheKey);
        var (dir, shouldClone) = (
            await cache.GetDirectory(
                cacheKey,
                CacheIntent.ResolvedForeignInput,
                CacheFlags.AllowNewLocked
            )
        )!.Value;

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

            await cache.CommitDirectory(
                cacheKey,
                CacheIntent.ResolvedForeignInput,
                CacheFlags.NoHostDirectory
            );
        }

        return Path.Combine(dir, pathInRepo);
    }

    /// <inheritdoc />
    public string Scheme => "git";
}
